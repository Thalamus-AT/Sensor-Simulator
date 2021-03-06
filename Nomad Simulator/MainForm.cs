﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace Nomad_Simulator {

    public partial class MainForm : Form {

        private int jitter = 5;     // Magnitude of the random amount added to sensor readings (+/- jitter)
        private int pollTime = 100; // Length of pause between polls when recording

        // Define the angle between the sensors in Degrees and Radians
        private static double sensorAngleDiffDeg = 25;
        private static double sensorAngleDiffRad = (sensorAngleDiffDeg / 180) * Math.PI;
        private static int runningAverageWindowSize = 10;

        private bool recording;     // Whether the form is currently recording

        private int sensorCircleDiam = 1;

        private Label[] sensorLabels;
        private Label[] padLabels;
        private Sensor[] sensors;
        private Plane plane;

        public MainForm() {
            InitializeComponent();

            // Add the sensors to an array for easier access and iteration
            sensorLabels = new Label[] {SensorLabel11, SensorLabel12, SensorLabel13,
                                        SensorLabel21, SensorLabel22, SensorLabel23,
                                        SensorLabel31, SensorLabel32, SensorLabel33};

            padLabels = new Label[] {PadLabel1, PadLabel2, PadLabel3};

            // Create the plane that will act as the obstacle
            plane = new Plane(new V3(400, 145, -100), new V3(600, 145, -100), new V3(400, 265, -100), new V3(600, 265, -100));

            // Initialise the set of nine sensors representing Nomad
            double dirOffset = Math.Tan(sensorAngleDiffRad);
            double corner = Math.Sqrt(dirOffset / 2);
            Random rand = new Random();
            sensors = new Sensor[9];
            sensors[0] = new Sensor(new V3(500, 205, 0), new V3(-corner, -corner, -1), jitter, 30, rand);
            sensors[1] = new Sensor(new V3(500, 205, 0), new V3(0, -dirOffset, -1), jitter, 30, rand);
            sensors[2] = new Sensor(new V3(500, 205, 0), new V3(corner, -corner, -1), jitter, 30, rand);
            sensors[3] = new Sensor(new V3(500, 205, 0), new V3(-dirOffset, 0, -1), jitter, 30, rand);
            sensors[4] = new Sensor(new V3(500, 205, 0), new V3(0, 0, -1), jitter, 30, rand);
            sensors[5] = new Sensor(new V3(500, 205, 0), new V3(dirOffset, 0, -1), jitter, 30, rand);
            sensors[6] = new Sensor(new V3(500, 205, 0), new V3(-corner, corner, -1), jitter, 30, rand);
            sensors[7] = new Sensor(new V3(500, 205, 0), new V3(0, dirOffset, -1), jitter, 30, rand);
            sensors[8] = new Sensor(new V3(500, 205, 0), new V3(corner, corner, -1), jitter, 30, rand);

            recording = false;

            // Set up the worker which runs the recording
            RecordingWorker.DoWork += new DoWorkEventHandler(RecordingWorker_DoWork);
            RecordingWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RecordingWorker_Completed);
        }

        private void DistanceSldr_ValueChanged(object sender, EventArgs e) {
            // Move the plane in the Z-axis and update the distance label
            plane.Move(new V3(0, 0, -plane.TopLeftPoint.Z - DistanceSldr.Value));
            string num = DistanceSldr.Value.ToString();
            DistanceValueLabel.Text = num;

            Refresh();
        }

        private void JitterSldr_ValueChanged(object sender, EventArgs e) {
            // Update all of the sensors with the new jitter value
            jitter = JitterSldr.Value;
            for (int i = 0; i < sensors.Length; i++) {
                sensors[i].Jitter = jitter;
            }

            // Update the label value
            string num = JitterSldr.Value.ToString();
            JitterValueLabel.Text = num;
        }

        private void VerticalSldr_ValueChanged(object sender, EventArgs e) {
            // Calculate the vertical centre of the panel
            double centre = plane.TopLeftPoint.Y + (PlanePnl.Size.Height / 2);

            // Calculate the required change to move the plane with the slider
            double change = -(centre - (VerticalSldr.Maximum - VerticalSldr.Value + 12));
            
            // Move the plane and the panel
            plane.Move(new V3(0, change, 0));
            PlanePnl.Top += (int) change;
        }

        private void HorizontalSldr_Scroll(object sender, EventArgs e) {
            // Calculate the horizontal centre of the panel
            double centre = plane.TopLeftPoint.X + (PlanePnl.Size.Width / 2);

            // Calcualte the required change to move the plane with the slider
            double change = -(centre - (HorizontalSldr.Value + 15));
            
            // Move the plane and the panel
            plane.Move(new V3(change, 0, 0));
            PlanePnl.Left += (int) change;
        }

        private void SensorAngleOffsetSldr_ValueChanged(object sender, EventArgs e) {
            // Change the offset angle between the sensors
            sensorAngleDiffDeg = SensorAngleOffsetSldr.Value;
            sensorAngleDiffRad = (sensorAngleDiffDeg / 180) * Math.PI;
            recalibrateSensors();

            string num = SensorAngleOffsetSldr.Value.ToString();
            SensorAngleOffsetValueLabel.Text = num;

            Refresh();
        }

        private void recalibrateSensors() {
            double dirOffset = Math.Tan(sensorAngleDiffRad);
            double corner = Math.Sqrt(dirOffset / 2);
            sensors[0].Direction = new V3(-corner, -corner, -1);
            sensors[1].Direction = new V3(0, -dirOffset, -1);
            sensors[2].Direction = new V3(corner, -corner, -1);
            sensors[3].Direction = new V3(-dirOffset, 0, -1);
            sensors[4].Direction = new V3(0, 0, -1);
            sensors[5].Direction = new V3(dirOffset, 0, -1);
            sensors[6].Direction = new V3(-corner, corner, -1);
            sensors[7].Direction = new V3(0, dirOffset, -1);
            sensors[8].Direction = new V3(corner, corner, -1);
        }

        private void PollBtn_Click(object sender, EventArgs e) {
            // Poll all the sensors then set the labels to the polled values
            double[] values = PollSensors();
            for (int i = 0; i < values.Length; i++) {
                string num = values[i].ToString();
                
                // Change the label value to the polled valu (max 5 characters) 
                sensorLabels[i].Text = num.Substring(0, Math.Min(5, num.Length));
            }

            double[] intensities = CalculateIntensities(values);
            for (int i = 0; i < intensities.Length; i++) {
                String num = intensities[i].ToString();

                padLabels[i].Text = num.Substring(0, Math.Min(5, num.Length));

                int colourVal = 255 - (int)(intensities[i] * 2.4);
                padLabels[i].BackColor = Color.FromArgb(colourVal, colourVal, 240);
            }
        }

        private static double[] leftWeights = {     1.5,    1,      0,
                                                    2.5,    1.5,    0,
                                                    1.5,    1,      0 };

        private static double[] centreWeights = {   0.5,     1.25,  0.5,
                                                    1.25,   2,      1.25,
                                                    0.5,    1.25,   0.5 };

        private static double[] rightWeights = {    0,      1,      1.5,
                                                    0,      1.5,    2.5,
                                                    0,      1,      1.5 };

        private double[][] prevValues = new double[runningAverageWindowSize][];
        private int lastIndex = 0;

        private double[] CalculateIntensities(double[] values) {
            double change = calculateChangeMagnitude(values);
            double normalisedChange = (-1 / (1 + 10000 * (Math.Pow(100000, change - 1)))) + 1;

            prevValues[lastIndex] = values;
            lastIndex = (lastIndex + 1) % runningAverageWindowSize;

            double leftAvg = getAverage(values, leftWeights);
            double centreAvg = getAverage(values, centreWeights);
            double rightAvg = getAverage(values, rightWeights);

            double leftNum = (500 - leftAvg) / 5;
            double centreNum = (500 - centreAvg) / 5;
            double rightNum = (500 - rightAvg) / 5;

            Console.WriteLine("Normalised Change: " + normalisedChange);
            return new double[] { normalisedChange * leftNum, normalisedChange * centreNum, normalisedChange * rightNum };
        }

        private double getAverage(double[] values, double[] weights) {
            double total = 0;
            for (int i = 0; i < values.Length; i++) {
                total += values[i] * weights[i];
            }
            return total / 9;
        }

        private double calculateChangeMagnitude(double[] values) {
            double[] totals = new double[9];
            for (int i = 0; i < prevValues.Length; i++) {
                if (prevValues[i] == null)
                    continue;

                for (int j = 0; j < totals.Length; j++) {
                    totals[j] += prevValues[i][j];
                }
            }

            double totalDiff = 0;
            for (int i = 0; i < totals.Length; i++) {
                totalDiff += Math.Abs((totals[i] / 9) - values[i]);
            }

            return (totalDiff / totals.Length) / 500;
        }

        private double[] PollSensors() {
            // Poll each of the sensors and return the results in an array
            double[] values = new double[9];
            for (int i = 0; i < sensors.Length; i++) {
                double distance = sensors[i].Poll(new Plane[] { plane });
                values[i] = distance;
            }
            return values;
        }

        private void RecordBtn_Click(object sender, EventArgs e) {
            // Toggle the recording state
            recording = !recording;

            if (recording) {
                // If we are beginning to record then chaneg the button text and start the worker
                (sender as Button).Text = "Recording";
                RecordingWorker.RunWorkerAsync();
            } else {
                (sender as Button).Text = "Record";
            }
        }

        private void RecordingWorker_DoWork(object sender, DoWorkEventArgs e) {
            // Start the worker recording
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = RecordSensors();
        }

        private int RecordSensors() {
            int count = 0;

            // Open a file to record into
            using (FileStream fs = File.Create(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".data")) {

                // Keep recording to the file until stopped by the user
                while (recording) {
                    // Poll the sensors and append the values to the file
                    double[] values = PollSensors();
                    for (int i = 0; i < values.Length - 1; i++) {
                        Byte[] line = new UTF8Encoding(true).GetBytes(values[i].ToString() + ",");
                        fs.Write(line, 0, line.Length);
                    }
                    Byte[] lastLine = new UTF8Encoding(true).GetBytes(values[8].ToString() + "\n");
                    fs.Write(lastLine, 0, lastLine.Length);

                    count++;

                    // Wait before polling again
                    Thread.Sleep(pollTime);
                }
            }

            return count;
        }

        private void RecordingWorker_Completed(object sender, RunWorkerCompletedEventArgs e) {
            Console.WriteLine("Finished recording");
            Console.WriteLine(e.Result.ToString() + " Recordings made");
        }

        private void MainForm_Paint(object sender, PaintEventArgs e) {
            // Create the necessary graphics objects
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.LightGray);
            SolidBrush brush = new SolidBrush(Color.Red);

            // Calculate the diameter of the sensing range based on the distance
            int diameter = (int)(sensorCircleDiam * DistanceSldr.Value);

            for (int i = 0; i < sensors.Length; i++) {
                Sensor curr = sensors[i];

                // Calculate the centre point of the sensor's sensing range
                int xCentre = (int)(curr.Position.X + (curr.Direction.X * DistanceSldr.Value));
                int yCentre = (int)(curr.Position.Y + (curr.Direction.Y * DistanceSldr.Value));

                if (500 < Math.Sqrt(Math.Pow(xCentre - curr.Position.X, 2) + Math.Pow(yCentre - curr.Position.Y, 2) + Math.Pow(DistanceSldr.Value, 2)))
                    continue;

                // Draw the small dot at the sensing points
                Rectangle centreRect = new Rectangle(xCentre - 2, yCentre - 2, 4, 4);
                g.FillEllipse(brush, centreRect);
                Rectangle topRect = new Rectangle(xCentre - 2, yCentre - (diameter / 2) - 2, 4, 4);
                g.FillEllipse(brush, topRect);
                Rectangle bottomRect = new Rectangle(xCentre - 2, yCentre + (diameter / 2) - 2, 4, 4);
                g.FillEllipse(brush, bottomRect);
                Rectangle leftRect = new Rectangle(xCentre - (diameter / 2) - 2, yCentre - 2, 4, 4);
                g.FillEllipse(brush, leftRect);
                Rectangle rightRect = new Rectangle(xCentre + (diameter / 2) - 2, yCentre - 2, 4, 4);
                g.FillEllipse(brush, rightRect);

                // Draw the surrounding circle representing the full sensing range.
                Rectangle largeRect = new Rectangle(xCentre - (diameter / 2), yCentre - (diameter / 2), diameter, diameter);
                g.DrawEllipse(pen, largeRect);
            }
        }
    }
}

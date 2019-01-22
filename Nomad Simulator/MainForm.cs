using System;
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

        private bool recording;     // Whether the form is currently recording

        private Label[] sensorLabels;
        private Sensor[] sensors;
        private Plane plane;

        public MainForm() {
            InitializeComponent();

            // Add the sensors to an array for easier access and iteration
            sensorLabels = new Label[] {SensorLabel11, SensorLabel12, SensorLabel13,
                                        SensorLabel21, SensorLabel22, SensorLabel23,
                                        SensorLabel31, SensorLabel32, SensorLabel33};

            // Create the plane that will act as the obstacle
            plane = new Plane(new V3(400, 145, -100), new V3(600, 145, -100), new V3(400, 265, -100), new V3(600, 265, -100));

            // Initialise the set of nine sensors representing Nomad
            double corner = Math.Sqrt(Math.PI / 12);
            sensors = new Sensor[9];
            sensors[0] = new Sensor(new V3(500, 205, 0), new V3(-corner, -corner, -1), jitter);
            sensors[1] = new Sensor(new V3(500, 205, 0), new V3(0, -Math.PI / 6, -1), jitter);
            sensors[2] = new Sensor(new V3(500, 205, 0), new V3(corner, -corner, -1), jitter);
            sensors[3] = new Sensor(new V3(500, 205, 0), new V3(-Math.PI / 6, 0, -1), jitter);
            sensors[4] = new Sensor(new V3(500, 205, 0), new V3(0, 0, -1), jitter);
            sensors[5] = new Sensor(new V3(500, 205, 0), new V3(Math.PI / 6, 0, -1), jitter);
            sensors[6] = new Sensor(new V3(500, 205, 0), new V3(-corner, corner, -1), jitter);
            sensors[7] = new Sensor(new V3(500, 205, 0), new V3(0, Math.PI / 6, -1), jitter);
            sensors[8] = new Sensor(new V3(500, 205, 0), new V3(corner, corner, -1), jitter);

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

        private void PollBtn_Click(object sender, EventArgs e) {
            // Poll all the sensors then set the labels to the polled values
            double[] values = PollSensors();
            for (int i = 0; i < values.Length; i++) {
                string num = values[i].ToString();
                
                // Change the label value to the polled valu (max 5 characters) 
                sensorLabels[i].Text = num.Substring(0, Math.Min(5, num.Length));
            }
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

    }
}

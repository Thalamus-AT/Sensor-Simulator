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

        private int jitter = 6;
        private int pollTime = 100;

        private bool recording;

        private Label[] sensorLabels;
        private Sensor[] sensors;
        private Plane plane;

        public MainForm() {
            InitializeComponent();

            sensorLabels = new Label[] {SensorLabel11, SensorLabel12, SensorLabel13,
                                        SensorLabel21, SensorLabel22, SensorLabel23,
                                        SensorLabel31, SensorLabel32, SensorLabel33};

            plane = new Plane(new V3(400, 145, -100), new V3(600, 145, -100), new V3(400, 265, -100), new V3(600, 265, -100));

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
            BackgroundWorker1.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker1_Completed);
        }

        private void DistanceSldr_ValueChanged(object sender, EventArgs e) {
            plane.Move(new V3(0, 0, -plane.TopLeftPoint.Z - DistanceSldr.Value));
        }

        private void JitterSldr_ValueChanged(object sender, EventArgs e) {
            jitter = JitterSldr.Value;
            for (int i = 0; i < sensors.Length; i++) {
                sensors[i].Jitter = jitter;
            }
        }

        private void VerticalSldr_ValueChanged(object sender, EventArgs e) {
            double centre = plane.TopLeftPoint.Y + (PlanePnl.Size.Height / 2);
            double change = -(centre - (VerticalSldr.Maximum - VerticalSldr.Value + 12));
            Console.WriteLine("Centre: " + centre);
            Console.WriteLine("Change: " + change);
            plane.Move(new V3(0, change, 0));
            PlanePnl.Top += (int) change;
        }

        private void HorizontalSldr_Scroll(object sender, EventArgs e) {
            double centre = plane.TopLeftPoint.X + (PlanePnl.Size.Width / 2);
            double change = -(centre - (HorizontalSldr.Value + 15));
            Console.WriteLine("Centre: " + centre);
            Console.WriteLine("Change: " + change);
            plane.Move(new V3(change, 0, 0));
            PlanePnl.Left += (int) change;
        }

        private void PollBtn_Click(object sender, EventArgs e) {
            double[] values = PollSensors();
            for (int i = 0; i < values.Length; i++) {
                string num = values[i].ToString();
                sensorLabels[i].Text = num.Substring(0, Math.Min(5, num.Length));
            }
        }

        private double[] PollSensors() {
            double[] values = new double[9];
            for (int i = 0; i < sensors.Length; i++) {
                double distance = sensors[i].Poll(new Plane[] { plane });
                values[i] = distance;
            }
            return values;
        }

        private void RecordBtn_Click(object sender, EventArgs e) {
            recording = !recording;
            if (recording) {
                (sender as Button).Text = "Recording";
                BackgroundWorker1.RunWorkerAsync();
            } else {
                (sender as Button).Text = "Record";
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = RecordSensors();
        }

        private int RecordSensors() {
            int count = 0;

            using (FileStream fs = File.Create(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".data")) {
                while (recording) {
                    double[] values = PollSensors();
                    for (int i = 0; i < values.Length - 1; i++) {
                        Byte[] line = new UTF8Encoding(true).GetBytes(values[i].ToString() + ",");
                        fs.Write(line, 0, line.Length);
                    }
                    Byte[] lastLine = new UTF8Encoding(true).GetBytes(values[8].ToString() + "\n");
                    fs.Write(lastLine, 0, lastLine.Length);

                    count++;
                    Thread.Sleep(pollTime);
                }
            }

            return count;
        }

        private void BackgroundWorker1_Completed(object sender, RunWorkerCompletedEventArgs e) {
            Console.WriteLine("Finished recording");
            Console.WriteLine(e.Result.ToString() + " Recordings made");
        }

    }
}

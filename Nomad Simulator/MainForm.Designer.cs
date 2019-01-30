namespace Nomad_Simulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlanePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SensorLabel11 = new System.Windows.Forms.Label();
            this.SensorLabel12 = new System.Windows.Forms.Label();
            this.SensorLabel13 = new System.Windows.Forms.Label();
            this.SensorLabel21 = new System.Windows.Forms.Label();
            this.SensorLabel22 = new System.Windows.Forms.Label();
            this.SensorLabel23 = new System.Windows.Forms.Label();
            this.SensorLabel31 = new System.Windows.Forms.Label();
            this.SensorLabel32 = new System.Windows.Forms.Label();
            this.SensorLabel33 = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.DistanceSldr = new System.Windows.Forms.TrackBar();
            this.PollBtn = new System.Windows.Forms.Button();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.RecordingWorker = new System.ComponentModel.BackgroundWorker();
            this.JitterLabel = new System.Windows.Forms.Label();
            this.JitterSldr = new System.Windows.Forms.TrackBar();
            this.VerticalSldr = new System.Windows.Forms.TrackBar();
            this.HorizontalSldr = new System.Windows.Forms.TrackBar();
            this.DistanceValueLabel = new System.Windows.Forms.Label();
            this.JitterValueLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SensorAngleOffsetValueLabel = new System.Windows.Forms.Label();
            this.SensorAngleOffsetSldr = new System.Windows.Forms.TrackBar();
            this.SensorAngleOffsetLabel = new System.Windows.Forms.Label();
            this.OutPanel = new System.Windows.Forms.Panel();
            this.PadLabel1 = new System.Windows.Forms.Label();
            this.PadLabel2 = new System.Windows.Forms.Label();
            this.PadLabel3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JitterSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorAngleOffsetSldr)).BeginInit();
            this.OutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlanePnl
            // 
            this.PlanePnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlanePnl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlanePnl.Location = new System.Drawing.Point(400, 120);
            this.PlanePnl.Name = "PlanePnl";
            this.PlanePnl.Size = new System.Drawing.Size(200, 120);
            this.PlanePnl.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SensorLabel11);
            this.panel1.Controls.Add(this.SensorLabel12);
            this.panel1.Controls.Add(this.SensorLabel13);
            this.panel1.Controls.Add(this.SensorLabel21);
            this.panel1.Controls.Add(this.SensorLabel22);
            this.panel1.Controls.Add(this.SensorLabel23);
            this.panel1.Controls.Add(this.SensorLabel31);
            this.panel1.Controls.Add(this.SensorLabel32);
            this.panel1.Controls.Add(this.SensorLabel33);
            this.panel1.Location = new System.Drawing.Point(12, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 112);
            this.panel1.TabIndex = 5;
            // 
            // SensorLabel11
            // 
            this.SensorLabel11.AutoSize = true;
            this.SensorLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel11.Location = new System.Drawing.Point(14, 17);
            this.SensorLabel11.Name = "SensorLabel11";
            this.SensorLabel11.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel11.TabIndex = 0;
            this.SensorLabel11.Text = "00.00";
            // 
            // SensorLabel12
            // 
            this.SensorLabel12.AutoSize = true;
            this.SensorLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel12.Location = new System.Drawing.Point(64, 17);
            this.SensorLabel12.Name = "SensorLabel12";
            this.SensorLabel12.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel12.TabIndex = 1;
            this.SensorLabel12.Text = "00.00";
            // 
            // SensorLabel13
            // 
            this.SensorLabel13.AutoSize = true;
            this.SensorLabel13.BackColor = System.Drawing.SystemColors.Control;
            this.SensorLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel13.Location = new System.Drawing.Point(114, 17);
            this.SensorLabel13.Name = "SensorLabel13";
            this.SensorLabel13.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel13.TabIndex = 2;
            this.SensorLabel13.Text = "00.00";
            // 
            // SensorLabel21
            // 
            this.SensorLabel21.AutoSize = true;
            this.SensorLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel21.Location = new System.Drawing.Point(14, 45);
            this.SensorLabel21.Name = "SensorLabel21";
            this.SensorLabel21.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel21.TabIndex = 3;
            this.SensorLabel21.Text = "00.00";
            // 
            // SensorLabel22
            // 
            this.SensorLabel22.AutoSize = true;
            this.SensorLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel22.Location = new System.Drawing.Point(64, 45);
            this.SensorLabel22.Name = "SensorLabel22";
            this.SensorLabel22.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel22.TabIndex = 4;
            this.SensorLabel22.Text = "00.00";
            // 
            // SensorLabel23
            // 
            this.SensorLabel23.AutoSize = true;
            this.SensorLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel23.Location = new System.Drawing.Point(114, 45);
            this.SensorLabel23.Name = "SensorLabel23";
            this.SensorLabel23.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel23.TabIndex = 5;
            this.SensorLabel23.Text = "00.00";
            // 
            // SensorLabel31
            // 
            this.SensorLabel31.AutoSize = true;
            this.SensorLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel31.Location = new System.Drawing.Point(14, 74);
            this.SensorLabel31.Name = "SensorLabel31";
            this.SensorLabel31.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel31.TabIndex = 6;
            this.SensorLabel31.Text = "00.00";
            // 
            // SensorLabel32
            // 
            this.SensorLabel32.AutoSize = true;
            this.SensorLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel32.Location = new System.Drawing.Point(64, 74);
            this.SensorLabel32.Name = "SensorLabel32";
            this.SensorLabel32.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel32.TabIndex = 7;
            this.SensorLabel32.Text = "00.00";
            // 
            // SensorLabel33
            // 
            this.SensorLabel33.AutoSize = true;
            this.SensorLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorLabel33.Location = new System.Drawing.Point(114, 74);
            this.SensorLabel33.Name = "SensorLabel33";
            this.SensorLabel33.Size = new System.Drawing.Size(44, 17);
            this.SensorLabel33.TabIndex = 8;
            this.SensorLabel33.Text = "00.00";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceLabel.Location = new System.Drawing.Point(776, 423);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(67, 17);
            this.DistanceLabel.TabIndex = 0;
            this.DistanceLabel.Text = "Distance:";
            // 
            // DistanceSldr
            // 
            this.DistanceSldr.Location = new System.Drawing.Point(779, 443);
            this.DistanceSldr.Maximum = 500;
            this.DistanceSldr.Minimum = 10;
            this.DistanceSldr.Name = "DistanceSldr";
            this.DistanceSldr.Size = new System.Drawing.Size(172, 45);
            this.DistanceSldr.TabIndex = 6;
            this.DistanceSldr.TickFrequency = 20;
            this.DistanceSldr.Value = 100;
            this.DistanceSldr.ValueChanged += new System.EventHandler(this.DistanceSldr_ValueChanged);
            // 
            // PollBtn
            // 
            this.PollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PollBtn.Location = new System.Drawing.Point(191, 423);
            this.PollBtn.Name = "PollBtn";
            this.PollBtn.Size = new System.Drawing.Size(90, 26);
            this.PollBtn.TabIndex = 7;
            this.PollBtn.Text = "Poll Sensors";
            this.PollBtn.UseVisualStyleBackColor = true;
            this.PollBtn.Click += new System.EventHandler(this.PollBtn_Click);
            // 
            // RecordBtn
            // 
            this.RecordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBtn.Location = new System.Drawing.Point(191, 455);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(90, 26);
            this.RecordBtn.TabIndex = 8;
            this.RecordBtn.Text = "Record";
            this.RecordBtn.UseVisualStyleBackColor = true;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // RecordingWorker
            // 
            this.RecordingWorker.WorkerSupportsCancellation = true;
            // 
            // JitterLabel
            // 
            this.JitterLabel.AutoSize = true;
            this.JitterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JitterLabel.Location = new System.Drawing.Point(776, 482);
            this.JitterLabel.Name = "JitterLabel";
            this.JitterLabel.Size = new System.Drawing.Size(43, 17);
            this.JitterLabel.TabIndex = 9;
            this.JitterLabel.Text = "Jitter:";
            // 
            // JitterSldr
            // 
            this.JitterSldr.Location = new System.Drawing.Point(779, 502);
            this.JitterSldr.Maximum = 50;
            this.JitterSldr.Name = "JitterSldr";
            this.JitterSldr.Size = new System.Drawing.Size(172, 45);
            this.JitterSldr.TabIndex = 10;
            this.JitterSldr.TickFrequency = 5;
            this.JitterSldr.Value = 5;
            this.JitterSldr.ValueChanged += new System.EventHandler(this.JitterSldr_ValueChanged);
            // 
            // VerticalSldr
            // 
            this.VerticalSldr.Location = new System.Drawing.Point(927, 12);
            this.VerticalSldr.Maximum = 393;
            this.VerticalSldr.Name = "VerticalSldr";
            this.VerticalSldr.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VerticalSldr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VerticalSldr.RightToLeftLayout = true;
            this.VerticalSldr.Size = new System.Drawing.Size(45, 393);
            this.VerticalSldr.TabIndex = 11;
            this.VerticalSldr.Value = 200;
            this.VerticalSldr.ValueChanged += new System.EventHandler(this.VerticalSldr_ValueChanged);
            // 
            // HorizontalSldr
            // 
            this.HorizontalSldr.Location = new System.Drawing.Point(15, 12);
            this.HorizontalSldr.Maximum = 928;
            this.HorizontalSldr.Name = "HorizontalSldr";
            this.HorizontalSldr.Size = new System.Drawing.Size(928, 45);
            this.HorizontalSldr.TabIndex = 12;
            this.HorizontalSldr.Value = 485;
            this.HorizontalSldr.Scroll += new System.EventHandler(this.HorizontalSldr_Scroll);
            // 
            // DistanceValueLabel
            // 
            this.DistanceValueLabel.AutoSize = true;
            this.DistanceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceValueLabel.Location = new System.Drawing.Point(952, 443);
            this.DistanceValueLabel.Name = "DistanceValueLabel";
            this.DistanceValueLabel.Size = new System.Drawing.Size(32, 17);
            this.DistanceValueLabel.TabIndex = 13;
            this.DistanceValueLabel.Text = "100";
            // 
            // JitterValueLabel
            // 
            this.JitterValueLabel.AutoSize = true;
            this.JitterValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JitterValueLabel.Location = new System.Drawing.Point(952, 502);
            this.JitterValueLabel.Name = "JitterValueLabel";
            this.JitterValueLabel.Size = new System.Drawing.Size(16, 17);
            this.JitterValueLabel.TabIndex = 14;
            this.JitterValueLabel.Text = "5";
            // 
            // SensorAngleOffsetValueLabel
            // 
            this.SensorAngleOffsetValueLabel.AutoSize = true;
            this.SensorAngleOffsetValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorAngleOffsetValueLabel.Location = new System.Drawing.Point(952, 564);
            this.SensorAngleOffsetValueLabel.Name = "SensorAngleOffsetValueLabel";
            this.SensorAngleOffsetValueLabel.Size = new System.Drawing.Size(24, 17);
            this.SensorAngleOffsetValueLabel.TabIndex = 17;
            this.SensorAngleOffsetValueLabel.Text = "25";
            // 
            // SensorAngleOffsetSldr
            // 
            this.SensorAngleOffsetSldr.Location = new System.Drawing.Point(779, 564);
            this.SensorAngleOffsetSldr.Maximum = 80;
            this.SensorAngleOffsetSldr.Name = "SensorAngleOffsetSldr";
            this.SensorAngleOffsetSldr.Size = new System.Drawing.Size(172, 45);
            this.SensorAngleOffsetSldr.TabIndex = 16;
            this.SensorAngleOffsetSldr.TickFrequency = 20;
            this.SensorAngleOffsetSldr.Value = 25;
            this.SensorAngleOffsetSldr.ValueChanged += new System.EventHandler(this.SensorAngleOffsetSldr_ValueChanged);
            // 
            // SensorAngleOffsetLabel
            // 
            this.SensorAngleOffsetLabel.AutoSize = true;
            this.SensorAngleOffsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorAngleOffsetLabel.Location = new System.Drawing.Point(776, 544);
            this.SensorAngleOffsetLabel.Name = "SensorAngleOffsetLabel";
            this.SensorAngleOffsetLabel.Size = new System.Drawing.Size(139, 17);
            this.SensorAngleOffsetLabel.TabIndex = 15;
            this.SensorAngleOffsetLabel.Text = "Sensor Angle Offset:";
            // 
            // OutPanel
            // 
            this.OutPanel.Controls.Add(this.PadLabel1);
            this.OutPanel.Controls.Add(this.PadLabel2);
            this.OutPanel.Controls.Add(this.PadLabel3);
            this.OutPanel.Location = new System.Drawing.Point(12, 544);
            this.OutPanel.Name = "OutPanel";
            this.OutPanel.Size = new System.Drawing.Size(172, 50);
            this.OutPanel.TabIndex = 18;
            // 
            // PadLabel1
            // 
            this.PadLabel1.AutoSize = true;
            this.PadLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PadLabel1.Location = new System.Drawing.Point(15, 15);
            this.PadLabel1.Name = "PadLabel1";
            this.PadLabel1.Size = new System.Drawing.Size(44, 17);
            this.PadLabel1.TabIndex = 19;
            this.PadLabel1.Text = "00.00";
            // 
            // PadLabel2
            // 
            this.PadLabel2.AutoSize = true;
            this.PadLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PadLabel2.Location = new System.Drawing.Point(65, 15);
            this.PadLabel2.Name = "PadLabel2";
            this.PadLabel2.Size = new System.Drawing.Size(44, 17);
            this.PadLabel2.TabIndex = 20;
            this.PadLabel2.Text = "00.00";
            // 
            // PadLabel3
            // 
            this.PadLabel3.AutoSize = true;
            this.PadLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PadLabel3.Location = new System.Drawing.Point(115, 15);
            this.PadLabel3.Name = "PadLabel3";
            this.PadLabel3.Size = new System.Drawing.Size(44, 17);
            this.PadLabel3.TabIndex = 21;
            this.PadLabel3.Text = "00.00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.OutPanel);
            this.Controls.Add(this.SensorAngleOffsetValueLabel);
            this.Controls.Add(this.SensorAngleOffsetSldr);
            this.Controls.Add(this.SensorAngleOffsetLabel);
            this.Controls.Add(this.JitterValueLabel);
            this.Controls.Add(this.DistanceValueLabel);
            this.Controls.Add(this.HorizontalSldr);
            this.Controls.Add(this.VerticalSldr);
            this.Controls.Add(this.JitterSldr);
            this.Controls.Add(this.JitterLabel);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.PollBtn);
            this.Controls.Add(this.DistanceSldr);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PlanePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomad Simulator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JitterSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorAngleOffsetSldr)).EndInit();
            this.OutPanel.ResumeLayout(false);
            this.OutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PlanePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SensorLabel11;
        private System.Windows.Forms.Label SensorLabel12;
        private System.Windows.Forms.Label SensorLabel13;
        private System.Windows.Forms.Label SensorLabel21;
        private System.Windows.Forms.Label SensorLabel22;
        private System.Windows.Forms.Label SensorLabel23;
        private System.Windows.Forms.Label SensorLabel31;
        private System.Windows.Forms.Label SensorLabel32;
        private System.Windows.Forms.Label SensorLabel33;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.TrackBar DistanceSldr;
        private System.Windows.Forms.Button PollBtn;
        private System.Windows.Forms.Button RecordBtn;
        private System.ComponentModel.BackgroundWorker RecordingWorker;
        private System.Windows.Forms.Label JitterLabel;
        private System.Windows.Forms.TrackBar JitterSldr;
        private System.Windows.Forms.TrackBar VerticalSldr;
        private System.Windows.Forms.TrackBar HorizontalSldr;
        private System.Windows.Forms.Label DistanceValueLabel;
        private System.Windows.Forms.Label JitterValueLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label SensorAngleOffsetValueLabel;
        private System.Windows.Forms.TrackBar SensorAngleOffsetSldr;
        private System.Windows.Forms.Label SensorAngleOffsetLabel;
        private System.Windows.Forms.Panel OutPanel;
        private System.Windows.Forms.Label PadLabel1;
        private System.Windows.Forms.Label PadLabel2;
        private System.Windows.Forms.Label PadLabel3;
    }
}


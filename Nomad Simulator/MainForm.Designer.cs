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
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.JitterLabel = new System.Windows.Forms.Label();
            this.JitterSldr = new System.Windows.Forms.TrackBar();
            this.VerticalSldr = new System.Windows.Forms.TrackBar();
            this.HorizontalSldr = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JitterSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSldr)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanePnl
            // 
            this.PlanePnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlanePnl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlanePnl.Location = new System.Drawing.Point(400, 145);
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
            this.DistanceLabel.Location = new System.Drawing.Point(12, 538);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(67, 17);
            this.DistanceLabel.TabIndex = 0;
            this.DistanceLabel.Text = "Distance:";
            // 
            // DistanceSldr
            // 
            this.DistanceSldr.Location = new System.Drawing.Point(12, 558);
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
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // JitterLabel
            // 
            this.JitterLabel.AutoSize = true;
            this.JitterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JitterLabel.Location = new System.Drawing.Point(14, 597);
            this.JitterLabel.Name = "JitterLabel";
            this.JitterLabel.Size = new System.Drawing.Size(43, 17);
            this.JitterLabel.TabIndex = 9;
            this.JitterLabel.Text = "Jitter:";
            // 
            // JitterSldr
            // 
            this.JitterSldr.Location = new System.Drawing.Point(17, 617);
            this.JitterSldr.Maximum = 50;
            this.JitterSldr.Name = "JitterSldr";
            this.JitterSldr.Size = new System.Drawing.Size(172, 45);
            this.JitterSldr.TabIndex = 10;
            this.JitterSldr.TickFrequency = 20;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
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
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.Text = "Nomad Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JitterSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSldr)).EndInit();
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
        private System.ComponentModel.BackgroundWorker BackgroundWorker1;
        private System.Windows.Forms.Label JitterLabel;
        private System.Windows.Forms.TrackBar JitterSldr;
        private System.Windows.Forms.TrackBar VerticalSldr;
        private System.Windows.Forms.TrackBar HorizontalSldr;
    }
}


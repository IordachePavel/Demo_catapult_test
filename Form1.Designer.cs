namespace Catapult
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox ComList;
        private System.Windows.Forms.TextBox BaudBox;
        private System.Windows.Forms.Button BeginSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label TensionLabel;
        private System.Windows.Forms.Label ArmingLabel;
        private System.Windows.Forms.TextBox TensionValue;
        private System.Windows.Forms.TextBox ArmingValue;
        private System.Windows.Forms.Button StepSequenceButton;
        private System.Windows.Forms.TextBox StartPosTARM;
        private System.Windows.Forms.TextBox StartPosET;
        private System.Windows.Forms.TextBox ClsTriggerTARM;
        private System.Windows.Forms.TextBox ClsTriggerET;
        private System.Windows.Forms.TextBox MTATARM;
        private System.Windows.Forms.TextBox MTARS;
        private System.Windows.Forms.TextBox RTMTARM;
        private System.Windows.Forms.TextBox RTMET;
        private System.Windows.Forms.TextBox FireTARM;
        private System.Windows.Forms.TextBox FireET;
        private System.Windows.Forms.TextBox STEP;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ComList = new System.Windows.Forms.ComboBox();
            this.BaudBox = new System.Windows.Forms.TextBox();
            this.BeginSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.TensionLabel = new System.Windows.Forms.Label();
            this.ArmingLabel = new System.Windows.Forms.Label();
            this.TensionValue = new System.Windows.Forms.TextBox();
            this.ArmingValue = new System.Windows.Forms.TextBox();
            this.StepSequenceButton = new System.Windows.Forms.Button();
            this.StartPosTARM = new System.Windows.Forms.TextBox();
            this.StartPosET = new System.Windows.Forms.TextBox();
            this.ClsTriggerTARM = new System.Windows.Forms.TextBox();
            this.ClsTriggerET = new System.Windows.Forms.TextBox();
            this.MTATARM = new System.Windows.Forms.TextBox();
            this.MTARS = new System.Windows.Forms.TextBox();
            this.RTMTARM = new System.Windows.Forms.TextBox();
            this.RTMET = new System.Windows.Forms.TextBox();
            this.FireTARM = new System.Windows.Forms.TextBox();
            this.FireET = new System.Windows.Forms.TextBox();
            this.STEP = new System.Windows.Forms.TextBox();
            this.TransmitterTimer = new System.Windows.Forms.Timer(this.components);
            this.FireButton = new System.Windows.Forms.Button();
            this.Lock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ViewTrajectory = new System.Windows.Forms.Button();
            this.ApproxDistanceLabel = new System.Windows.Forms.Label();
            this.TimeOfFlightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // ComList
            // 
            this.ComList.FormattingEnabled = true;
            this.ComList.Location = new System.Drawing.Point(12, 12);
            this.ComList.Name = "ComList";
            this.ComList.Size = new System.Drawing.Size(121, 21);
            this.ComList.TabIndex = 0;
            // 
            // BaudBox
            // 
            this.BaudBox.Location = new System.Drawing.Point(12, 39);
            this.BaudBox.Name = "BaudBox";
            this.BaudBox.Size = new System.Drawing.Size(121, 20);
            this.BaudBox.TabIndex = 1;
            // 
            // BeginSerial
            // 
            this.BeginSerial.Location = new System.Drawing.Point(12, 65);
            this.BeginSerial.Name = "BeginSerial";
            this.BeginSerial.Size = new System.Drawing.Size(121, 23);
            this.BeginSerial.TabIndex = 2;
            this.BeginSerial.Text = "Begin Serial";
            this.BeginSerial.UseVisualStyleBackColor = true;
            this.BeginSerial.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 94);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(206, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 145);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(206, 45);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // TensionLabel
            // 
            this.TensionLabel.AutoSize = true;
            this.TensionLabel.Location = new System.Drawing.Point(224, 94);
            this.TensionLabel.Name = "TensionLabel";
            this.TensionLabel.Size = new System.Drawing.Size(45, 13);
            this.TensionLabel.TabIndex = 7;
            this.TensionLabel.Text = "Tension";
            // 
            // ArmingLabel
            // 
            this.ArmingLabel.AutoSize = true;
            this.ArmingLabel.Location = new System.Drawing.Point(224, 145);
            this.ArmingLabel.Name = "ArmingLabel";
            this.ArmingLabel.Size = new System.Drawing.Size(39, 13);
            this.ArmingLabel.TabIndex = 8;
            this.ArmingLabel.Text = "Arming";
            // 
            // TensionValue
            // 
            this.TensionValue.Location = new System.Drawing.Point(273, 91);
            this.TensionValue.Name = "TensionValue";
            this.TensionValue.Size = new System.Drawing.Size(49, 20);
            this.TensionValue.TabIndex = 9;
            // 
            // ArmingValue
            // 
            this.ArmingValue.Location = new System.Drawing.Point(273, 142);
            this.ArmingValue.Name = "ArmingValue";
            this.ArmingValue.Size = new System.Drawing.Size(49, 20);
            this.ArmingValue.TabIndex = 10;
            // 
            // StepSequenceButton
            // 
            this.StepSequenceButton.Location = new System.Drawing.Point(12, 196);
            this.StepSequenceButton.Name = "StepSequenceButton";
            this.StepSequenceButton.Size = new System.Drawing.Size(310, 23);
            this.StepSequenceButton.TabIndex = 11;
            this.StepSequenceButton.Text = "Run Step Sequence";
            this.StepSequenceButton.UseVisualStyleBackColor = true;
            this.StepSequenceButton.Click += new System.EventHandler(this.StepSequenceButton_Click);
            // 
            // StartPosTARM
            // 
            this.StartPosTARM.Location = new System.Drawing.Point(12, 225);
            this.StartPosTARM.Name = "StartPosTARM";
            this.StartPosTARM.Size = new System.Drawing.Size(49, 20);
            this.StartPosTARM.TabIndex = 12;
            // 
            // StartPosET
            // 
            this.StartPosET.Location = new System.Drawing.Point(67, 225);
            this.StartPosET.Name = "StartPosET";
            this.StartPosET.Size = new System.Drawing.Size(49, 20);
            this.StartPosET.TabIndex = 13;
            // 
            // ClsTriggerTARM
            // 
            this.ClsTriggerTARM.Location = new System.Drawing.Point(12, 251);
            this.ClsTriggerTARM.Name = "ClsTriggerTARM";
            this.ClsTriggerTARM.Size = new System.Drawing.Size(49, 20);
            this.ClsTriggerTARM.TabIndex = 14;
            // 
            // ClsTriggerET
            // 
            this.ClsTriggerET.Location = new System.Drawing.Point(67, 251);
            this.ClsTriggerET.Name = "ClsTriggerET";
            this.ClsTriggerET.Size = new System.Drawing.Size(49, 20);
            this.ClsTriggerET.TabIndex = 15;
            // 
            // MTATARM
            // 
            this.MTATARM.Location = new System.Drawing.Point(12, 277);
            this.MTATARM.Name = "MTATARM";
            this.MTATARM.Size = new System.Drawing.Size(49, 20);
            this.MTATARM.TabIndex = 16;
            // 
            // MTARS
            // 
            this.MTARS.Location = new System.Drawing.Point(67, 277);
            this.MTARS.Name = "MTARS";
            this.MTARS.Size = new System.Drawing.Size(49, 20);
            this.MTARS.TabIndex = 17;
            // 
            // RTMTARM
            // 
            this.RTMTARM.Location = new System.Drawing.Point(12, 303);
            this.RTMTARM.Name = "RTMTARM";
            this.RTMTARM.Size = new System.Drawing.Size(49, 20);
            this.RTMTARM.TabIndex = 18;
            // 
            // RTMET
            // 
            this.RTMET.Location = new System.Drawing.Point(67, 303);
            this.RTMET.Name = "RTMET";
            this.RTMET.Size = new System.Drawing.Size(49, 20);
            this.RTMET.TabIndex = 19;
            // 
            // FireTARM
            // 
            this.FireTARM.Location = new System.Drawing.Point(12, 329);
            this.FireTARM.Name = "FireTARM";
            this.FireTARM.Size = new System.Drawing.Size(49, 20);
            this.FireTARM.TabIndex = 20;
            // 
            // FireET
            // 
            this.FireET.Location = new System.Drawing.Point(67, 329);
            this.FireET.Name = "FireET";
            this.FireET.Size = new System.Drawing.Size(49, 20);
            this.FireET.TabIndex = 21;
            // 
            // STEP
            // 
            this.STEP.Location = new System.Drawing.Point(12, 355);
            this.STEP.Name = "STEP";
            this.STEP.Size = new System.Drawing.Size(49, 20);
            this.STEP.TabIndex = 22;
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(236, 12);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(86, 32);
            this.FireButton.TabIndex = 23;
            this.FireButton.Text = "Fire";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // Lock
            // 
            this.Lock.Location = new System.Drawing.Point(236, 50);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(86, 32);
            this.Lock.TabIndex = 24;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = true;
            this.Lock.Click += new System.EventHandler(this.Lock_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Tension Setting 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Tension Setting 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ViewTrajectory
            // 
            this.ViewTrajectory.Location = new System.Drawing.Point(328, 89);
            this.ViewTrajectory.Name = "ViewTrajectory";
            this.ViewTrajectory.Size = new System.Drawing.Size(132, 41);
            this.ViewTrajectory.TabIndex = 27;
            this.ViewTrajectory.Text = "Launch with real time 2D trajectory";
            this.ViewTrajectory.UseVisualStyleBackColor = true;
            this.ViewTrajectory.Click += new System.EventHandler(this.ViewTrajectory_Click);
            // 
            // ApproxDistanceLabel
            // 
            this.ApproxDistanceLabel.AutoSize = true;
            this.ApproxDistanceLabel.Location = new System.Drawing.Point(466, 15);
            this.ApproxDistanceLabel.Name = "ApproxDistanceLabel";
            this.ApproxDistanceLabel.Size = new System.Drawing.Size(58, 13);
            this.ApproxDistanceLabel.TabIndex = 29;
            this.ApproxDistanceLabel.Text = "ApproxDist";
            this.ApproxDistanceLabel.Click += new System.EventHandler(this.ApproxDistanceLabel_Click);
            // 
            // TimeOfFlightLabel
            // 
            this.TimeOfFlightLabel.AutoSize = true;
            this.TimeOfFlightLabel.Location = new System.Drawing.Point(466, 39);
            this.TimeOfFlightLabel.Name = "TimeOfFlightLabel";
            this.TimeOfFlightLabel.Size = new System.Drawing.Size(28, 13);
            this.TimeOfFlightLabel.TabIndex = 30;
            this.TimeOfFlightLabel.Text = "TOF";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(720, 188);
            this.Controls.Add(this.TimeOfFlightLabel);
            this.Controls.Add(this.ApproxDistanceLabel);
            this.Controls.Add(this.ViewTrajectory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.FireButton);
            this.Controls.Add(this.STEP);
            this.Controls.Add(this.FireET);
            this.Controls.Add(this.FireTARM);
            this.Controls.Add(this.RTMET);
            this.Controls.Add(this.RTMTARM);
            this.Controls.Add(this.MTARS);
            this.Controls.Add(this.MTATARM);
            this.Controls.Add(this.ClsTriggerET);
            this.Controls.Add(this.ClsTriggerTARM);
            this.Controls.Add(this.StartPosET);
            this.Controls.Add(this.StartPosTARM);
            this.Controls.Add(this.StepSequenceButton);
            this.Controls.Add(this.ArmingValue);
            this.Controls.Add(this.TensionValue);
            this.Controls.Add(this.ArmingLabel);
            this.Controls.Add(this.TensionLabel);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeginSerial);
            this.Controls.Add(this.BaudBox);
            this.Controls.Add(this.ComList);
            this.Name = "Form1";
            this.Text = "Servo Control";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Timer TransmitterTimer;
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViewTrajectory;
        private System.Windows.Forms.Label ApproxDistanceLabel;
        private System.Windows.Forms.Label TimeOfFlightLabel;
    }
}

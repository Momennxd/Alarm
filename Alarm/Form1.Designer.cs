namespace Alarm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnResetTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(306, 192);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(68, 45);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "00";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(205, 192);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(68, 45);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "00";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(407, 192);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(68, 45);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(239, 403);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(187, 60);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSeconds.Location = new System.Drawing.Point(368, 318);
            this.nudSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(48, 36);
            this.nudSeconds.TabIndex = 6;
            // 
            // nudHours
            // 
            this.nudHours.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHours.Location = new System.Drawing.Point(260, 318);
            this.nudHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(48, 36);
            this.nudHours.TabIndex = 7;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutes.Location = new System.Drawing.Point(314, 318);
            this.nudMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(48, 36);
            this.nudMinutes.TabIndex = 8;
            // 
            // btnResetTimer
            // 
            this.btnResetTimer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTimer.Location = new System.Drawing.Point(239, 493);
            this.btnResetTimer.Name = "btnResetTimer";
            this.btnResetTimer.Size = new System.Drawing.Size(187, 60);
            this.btnResetTimer.TabIndex = 9;
            this.btnResetTimer.Text = "Reset Timer";
            this.btnResetTimer.UseVisualStyleBackColor = true;
            this.btnResetTimer.Click += new System.EventHandler(this.btnResetTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(119, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(445, 52);
            this.progressBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 628);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnResetTimer);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblMinutes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Button btnResetTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}


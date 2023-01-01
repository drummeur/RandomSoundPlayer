
namespace RandomSoundPlayer.GUI
{
    partial class SoundControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.nudMaxDelay = new System.Windows.Forms.NumericUpDown();
            this.nudMinDelay = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(6, 20);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(56, 104);
            this.tbVolume.TabIndex = 1;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(3, 116);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(46, 17);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "label1";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(3, 136);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(43, 43);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // nudMaxDelay
            // 
            this.nudMaxDelay.Location = new System.Drawing.Point(52, 40);
            this.nudMaxDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMaxDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDelay.Name = "nudMaxDelay";
            this.nudMaxDelay.Size = new System.Drawing.Size(56, 22);
            this.nudMaxDelay.TabIndex = 5;
            this.nudMaxDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudMaxDelay.ValueChanged += new System.EventHandler(this.nudMaxDelay_ValueChanged);
            // 
            // nudMinDelay
            // 
            this.nudMinDelay.Location = new System.Drawing.Point(52, 85);
            this.nudMinDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMinDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinDelay.Name = "nudMinDelay";
            this.nudMinDelay.Size = new System.Drawing.Size(56, 22);
            this.nudMinDelay.TabIndex = 6;
            this.nudMinDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinDelay.ValueChanged += new System.EventHandler(this.nudMinDelay_ValueChanged);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(50, 65);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 17);
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(49, 20);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(33, 17);
            this.lblMax.TabIndex = 8;
            this.lblMax.Text = "Max";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::RandomSoundPlayer.Properties.Resources.RedX;
            this.btnRemove.Location = new System.Drawing.Point(65, 136);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.nudMinDelay);
            this.Controls.Add(this.nudMaxDelay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.groupBox1);
            this.Name = "SoundControl";
            this.Size = new System.Drawing.Size(115, 186);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.NumericUpDown nudMaxDelay;
        private System.Windows.Forms.NumericUpDown nudMinDelay;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
    }
}


namespace RandomSoundPlayer.GUI
{
    partial class SoundControl2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceR = new System.Windows.Forms.Label();
            this.lblBalanceL = new System.Windows.Forms.Label();
            this.lblMinSeconds = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TrackBar();
            this.lblMaxSeconds = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance)).BeginInit();
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
            this.nudMaxDelay.Location = new System.Drawing.Point(6, 20);
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
            this.nudMinDelay.Location = new System.Drawing.Point(6, 65);
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
            this.lblMin.Location = new System.Drawing.Point(3, 45);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(70, 17);
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "Min Delay";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(3, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(73, 17);
            this.lblMax.TabIndex = 8;
            this.lblMax.Text = "Max Delay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMore);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 498);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBalanceValue);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.lblBalanceR);
            this.panel1.Controls.Add(this.lblBalanceL);
            this.panel1.Controls.Add(this.lblMinSeconds);
            this.panel1.Controls.Add(this.tbBalance);
            this.panel1.Controls.Add(this.lblMaxSeconds);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.nudMinDelay);
            this.panel1.Controls.Add(this.nudMaxDelay);
            this.panel1.Location = new System.Drawing.Point(7, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 277);
            this.panel1.TabIndex = 6;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(3, 90);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "Balance";
            // 
            // lblBalanceR
            // 
            this.lblBalanceR.AutoSize = true;
            this.lblBalanceR.Location = new System.Drawing.Point(94, 128);
            this.lblBalanceR.Name = "lblBalanceR";
            this.lblBalanceR.Size = new System.Drawing.Size(18, 17);
            this.lblBalanceR.TabIndex = 14;
            this.lblBalanceR.Text = "R";
            // 
            // lblBalanceL
            // 
            this.lblBalanceL.AutoSize = true;
            this.lblBalanceL.Location = new System.Drawing.Point(7, 128);
            this.lblBalanceL.Name = "lblBalanceL";
            this.lblBalanceL.Size = new System.Drawing.Size(16, 17);
            this.lblBalanceL.TabIndex = 13;
            this.lblBalanceL.Text = "L";
            // 
            // lblMinSeconds
            // 
            this.lblMinSeconds.AutoSize = true;
            this.lblMinSeconds.Location = new System.Drawing.Point(68, 67);
            this.lblMinSeconds.Name = "lblMinSeconds";
            this.lblMinSeconds.Size = new System.Drawing.Size(61, 17);
            this.lblMinSeconds.TabIndex = 10;
            this.lblMinSeconds.Text = "seconds";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(6, 110);
            this.tbBalance.Minimum = -10;
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(104, 56);
            this.tbBalance.TabIndex = 11;
            this.tbBalance.ValueChanged += new System.EventHandler(this.tbBalance_ValueChanged);
            // 
            // lblMaxSeconds
            // 
            this.lblMaxSeconds.AutoSize = true;
            this.lblMaxSeconds.Location = new System.Drawing.Point(68, 22);
            this.lblMaxSeconds.Name = "lblMaxSeconds";
            this.lblMaxSeconds.Size = new System.Drawing.Size(61, 17);
            this.lblMaxSeconds.TabIndex = 9;
            this.lblMaxSeconds.Text = "seconds";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::RandomSoundPlayer.Properties.Resources.RedX;
            this.btnRemove.Location = new System.Drawing.Point(3, 172);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMore
            // 
            this.btnMore.Image = global::RandomSoundPlayer.Properties.Resources.Collapsed;
            this.btnMore.Location = new System.Drawing.Point(3, 185);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(23, 23);
            this.btnMore.TabIndex = 5;
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Location = new System.Drawing.Point(30, 149);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(46, 17);
            this.lblBalanceValue.TabIndex = 15;
            this.lblBalanceValue.Text = "label1";
            // 
            // SoundControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.groupBox1);
            this.Name = "SoundControl2";
            this.Size = new System.Drawing.Size(221, 498);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance)).EndInit();
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
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceR;
        private System.Windows.Forms.Label lblBalanceL;
        private System.Windows.Forms.Label lblMinSeconds;
        private System.Windows.Forms.TrackBar tbBalance;
        private System.Windows.Forms.Label lblMaxSeconds;
        private System.Windows.Forms.Label lblBalanceValue;
    }
}

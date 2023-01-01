
namespace RandomSoundPlayer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fpSoundControls = new System.Windows.Forms.FlowLayoutPanel();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPlayAll = new System.Windows.Forms.ToolStripButton();
            this.btnStopAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpSoundControls
            // 
            this.fpSoundControls.AllowDrop = true;
            this.fpSoundControls.AutoScroll = true;
            this.fpSoundControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fpSoundControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSoundControls.Location = new System.Drawing.Point(0, 0);
            this.fpSoundControls.Name = "fpSoundControls";
            this.fpSoundControls.Size = new System.Drawing.Size(800, 423);
            this.fpSoundControls.TabIndex = 0;
            this.fpSoundControls.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.fpSoundControls.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.RestoreDirectory = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnLoad,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnPlayAll,
            this.btnStopAll,
            this.toolStripSeparator2,
            this.btnClearAll,
            this.toolStripSeparator3,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(284, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 24);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(46, 24);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlayAll.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayAll.Image")));
            this.btnPlayAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Size = new System.Drawing.Size(29, 24);
            this.btnPlayAll.Text = "Play All";
            this.btnPlayAll.Click += new System.EventHandler(this.btnPlayAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStopAll.Image = global::RandomSoundPlayer.Properties.Resources.BlackSpeaker_Slash;
            this.btnStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(29, 24);
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnClearAll
            // 
            this.btnClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearAll.Image = global::RandomSoundPlayer.Properties.Resources.RedX;
            this.btnClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(29, 24);
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 24);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.fpSoundControls);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 423);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "json";
            this.dlgSaveFile.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            this.dlgSaveFile.RestoreDirectory = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Cowboy Toad\'s Random Sound Tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpSoundControls;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPlayAll;
        private System.Windows.Forms.ToolStripButton btnStopAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.ToolStripButton btnClearAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnHelp;
    }
}


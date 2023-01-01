using RandomSoundPlayer.GUI;
using RandomSoundPlayer.Model;
using RandomSoundPlayer.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSoundPlayer
{
    public partial class FormMain : Form
    {
        List<SoundControl> SoundControls;

        public FormMain()
        {
            InitializeComponent();

            SoundControls = new List<SoundControl>();
        }

        private void AddSoundControl(string filename)
        {
            var control = new SoundControl(filename);
            SoundControls.Add(control);
            fpSoundControls.Controls.Add(control);
            control.RaiseRemoveSoundControl += RemoveSoundControl;
        }

        private void AddSoundControl(string filename, int volume, int min_delay, int max_delay)
        {
            var control = new SoundControl(filename, volume, min_delay, max_delay);
            SoundControls.Add(control);
            fpSoundControls.Controls.Add(control);
            control.RaiseRemoveSoundControl += RemoveSoundControl;
        }

        private void RemoveSoundControl(object sender, EventArgs e)
        {
            var control = sender as SoundControl;
            SoundControls.Remove(control);
            fpSoundControls.Controls.Remove(control);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "Audio Files (*.mp3;*.wav;*.flac;*.mid;*.midi)|*.mp3;*.wav;*.flac;*.mid;*.midi|All Files (*.*)|*.*";

            if (dlgOpenFile.ShowDialog() is DialogResult.OK)
            {
                try
                {
                    AddSoundControl(dlgOpenFile.FileName);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            if (dlgOpenFile.ShowDialog() is DialogResult.OK)
            {
                try
                {
                    PlayerConfiguration config = await JsonHelper.LoadConfigurationAsync(dlgOpenFile.FileName);

                    // null reference exception in the enumeration if we try to load in a valid json, but it isn't a config file
                    // so add a check to make sure that config isn't null

                    if (config == null || config.Configurations == null)
                    {
                        MessageBox.Show("Error loading JSON.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        foreach (var cfg in config.Configurations)
                        {
                            AddSoundControl(cfg.path, cfg.volume, cfg.min_delay, cfg.max_delay);

                        }

                    }

                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (JsonException ex)
                {
                    MessageBox.Show(ex.Message, "JSON Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() is DialogResult.OK)
            {
                var config = new PlayerConfiguration(SoundControls.Select(el => el.Configuration).ToArray());

                try
                {
                    await JsonHelper.SaveConfigurationAsync(config, dlgSaveFile.FileName);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (JsonException ex)
                {
                    MessageBox.Show(ex.Message, "JSON Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var help = new FormHelp();
            help.ShowDialog();
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);

            foreach (string file in files)
            {
                AddSoundControl(file);
            }
        }

        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            foreach (var control in SoundControls)
            {
                control.Playing = true;
            }
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            foreach (var control in SoundControls)
            {
                control.Playing = false;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach (var control in SoundControls)
            {
                fpSoundControls.Controls.Remove(control);
            }

            SoundControls.Clear();
        }
    }
}

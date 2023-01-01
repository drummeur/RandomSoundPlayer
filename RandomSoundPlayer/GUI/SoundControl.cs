using RandomSoundPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomSoundPlayer.Model;

namespace RandomSoundPlayer.GUI
{
    public partial class SoundControl : UserControl
    {
        private bool playing;

        public bool Playing 
        {
            get => playing; 
            set
            {
                playing = value;
                if (playing)
                {
                    SetTimerDelay();
                    PlaybackTimer.Start();
                }
                else
                {
                    PlaybackTimer.Stop();
                    // make sure that this restarts correctly
                    Player.Stop();
                }

                SetButtonImage();
                SetVolumeLabel();
            }
        }

        public event EventHandler RaiseRemoveSoundControl;

        private string filepath;

        private double Volume;

        private Random Random;
        private MediaPlayer Player;

        private delegate void PlayMedia();
        private PlayMedia PlayMediaDelegate;

        private System.Timers.Timer PlaybackTimer;

        public SoundControl(string filepath)
        {
            InitializeComponent();

            this.filepath = filepath;

            Player = new MediaPlayer();
            Player.MediaFailed += OnMediaFailed;

            PlaybackTimer = new System.Timers.Timer();
            Random = new Random();

            SetButtonImage();
            groupBox1.Text = System.IO.Path.GetFileName(filepath);

            Player.Open(new Uri(filepath));
            SetVolume(75);
            PlayMediaDelegate = new PlayMedia(PlayMediaMethod);

            PlaybackTimer.Elapsed += OnElapsed;

            Playing = false;
        }

        public SoundControl(string filepath, int volume, int min_delay, int max_delay)
        {
            InitializeComponent();

            this.filepath = filepath;

            Player = new MediaPlayer();

            PlaybackTimer = new System.Timers.Timer();
            Random = new Random();

            SetButtonImage();
            groupBox1.Text = System.IO.Path.GetFileName(filepath);

            Player.Open(new Uri(filepath));
            SetVolume(volume);
            PlayMediaDelegate = new PlayMedia(PlayMediaMethod);

            PlaybackTimer.Elapsed += OnElapsed;

            nudMinDelay.Value = min_delay;
            nudMaxDelay.Value = max_delay;

            Playing = false;
        }

        public Configuration Configuration
        {
            get
            {
                return new Configuration()
                {
                    path = filepath,
                    volume = tbVolume.Value,
                    min_delay = (int)nudMinDelay.Value,
                    max_delay = (int)nudMaxDelay.Value
                };
            }
        }

        public void OnMediaFailed(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Playback of '{filepath}' failed.  Remove?", "Media Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) is DialogResult.Yes)
            {
                OnRaiseRemoveSoundControl(new EventArgs());
            }
            else
            {
                Playing = false;
            }
        }

        public virtual void OnRaiseRemoveSoundControl(EventArgs e)
        {
            Player.Close();
            RaiseRemoveSoundControl?.Invoke(this, e);
        }

        private void SetTimerDelay()
        {
            int delay = Random.Next(1000 * (int)nudMinDelay.Value, 1000 * (int)nudMaxDelay.Value);
            PlaybackTimer.Interval = delay;
        }

        private void PlayMediaMethod()
        {
            Player.Volume = Volume;
            Player.Position = new TimeSpan(0);
            Player.Play();
        }

        private void OnElapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            Invoke(PlayMediaDelegate);
            
            SetTimerDelay();
        }

        private void SetVolumeLabel()
        {
            if (Playing)
            {
                lblVolume.ForeColor = SystemColors.ControlText;
                lblVolume.Text = $"{tbVolume.Value}%";
            }
            else
            {
                lblVolume.ForeColor = SystemColors.GrayText;
                lblVolume.Text = $"({tbVolume.Value}%)";
            }
        }

        private void SetVolume(int value)
        {
            if (value < 0)
            {
                tbVolume.Value = 0;
                
            }
            else if (value > 100)
            {
                tbVolume.Value = 100;
            }
            else
            {
                tbVolume.Value = value;
            }

            Volume = (double)value / 100;

        }

        private void SetButtonImage()
        {
            btnPlay.Image = Playing ? Resources.BlackSpeaker : Resources.BlackSpeaker_Slash;
        }

        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            SetVolumeLabel();
            Volume = (double)tbVolume.Value / 100;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Playing = !Playing;      
        }

        private void nudMinDelay_ValueChanged(object sender, EventArgs e)
        {
            nudMaxDelay.Minimum = nudMinDelay.Value;
        }

        private void nudMaxDelay_ValueChanged(object sender, EventArgs e)
        {
            nudMinDelay.Maximum = nudMaxDelay.Value;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnRaiseRemoveSoundControl(new EventArgs());
        }
    }
}

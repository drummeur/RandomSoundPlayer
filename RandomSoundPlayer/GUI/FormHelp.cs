using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSoundPlayer.GUI
{
    public partial class FormHelp : Form
    {
        // https://support.microsoft.com/en-us/topic/file-types-supported-by-windows-media-player-32d9998e-dc8f-af54-7ba1-e996f74375d9


        public FormHelp()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            label1.Text = "'Add': add a new audio file for playback\n" +
                "    (You can also drag and drop a file into the playback area to add it)\n\n" +
                "'Load': load a saved configuration of audio files\n" +
                "    (There is a file called 'example.json' included that uses Windows audio sounds -- try it out!)\n\n" +
                "'Save': save your current playback settings as a configuration\n\n" +
                "Configurations are saved as JSON files.\n\n" +
                "Click on the speaker button to start or stop playback:\n" +
                "    the icons in the toolstrip will start/stop all media files,\n" +
                "    and the icon below a volume slider will toggle the individual file's playback.\n\n" +
                "Click on the red X to remove a file from playback.\n\n" +
                "The numeric up/down rollers set the minimum and maximum delay before a playback triggers, in seconds.";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = "https://support.microsoft.com/en-us/topic/file-types-supported-by-windows-media-player-32d9998e-dc8f-af54-7ba1-e996f74375d9";

            System.Diagnostics.Process.Start(url);
        }
    }
}

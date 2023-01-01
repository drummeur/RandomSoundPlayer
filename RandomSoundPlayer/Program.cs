using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSoundPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

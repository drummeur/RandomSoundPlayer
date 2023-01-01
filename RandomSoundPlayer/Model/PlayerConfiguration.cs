using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSoundPlayer.Model
{
    public class PlayerConfiguration
    {
        public Configuration[] Configurations { get; set; }

        public PlayerConfiguration(Configuration[] configurations)
        {
            Configurations = configurations;
        }
    }

    public class Configuration
    {
        public string path { get; set; }
        public int volume { get; set; }
        public int min_delay { get; set; }
        public int max_delay { get; set; }
    }

}

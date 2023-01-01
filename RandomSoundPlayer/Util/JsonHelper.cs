using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RandomSoundPlayer.Model;
using System.IO;

namespace RandomSoundPlayer.Util
{
    public static class JsonHelper
    {
        public static async Task<PlayerConfiguration> LoadConfigurationAsync(string path)
        {
            using (FileStream fin = File.OpenRead(path))
            {
                return await JsonSerializer.DeserializeAsync<PlayerConfiguration>(fin);
            }

        }

        public static async Task SaveConfigurationAsync(PlayerConfiguration Configuration, string path)
        {
            using (FileStream fout = File.OpenWrite(path))
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                await JsonSerializer.SerializeAsync(fout, Configuration, options);
            }
        }
    }
}

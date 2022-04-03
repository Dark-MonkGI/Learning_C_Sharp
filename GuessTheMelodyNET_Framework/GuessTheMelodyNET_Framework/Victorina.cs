using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessTheMelodyNET_Framework
{
    static class Victorina
    {
        static public List<string> listWithMusic = new List<string>();
        static public int GameDuration = 60;
        static public int MusicDuration = 10;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;


        static public void ReadMusic()
        {
            string[] MusicList = Directory.GetFiles(lastFolder, "*.mp3",
                    allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            listWithMusic.Clear();
            listWithMusic.AddRange(MusicList);
        }

        static string regKeyName = "Software\\DarkMonk\\GuessMelody";

        public static void WriteParametrs()
        {
            RegistryKey registryOneKey = null;

            try
            {
                registryOneKey = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (registryOneKey == null) return;
                registryOneKey.SetValue("lastFolder", lastFolder);
                registryOneKey.SetValue("randomStart", randomStart);
                registryOneKey.SetValue("GameDuration", GameDuration);
                registryOneKey.SetValue("MusicDuration", MusicDuration);
                registryOneKey.SetValue("allDirectories", allDirectories);
            }
            finally
            {
                if (registryOneKey != null) registryOneKey.Close();
            }
        }

        public static void ReadParametrs()
        {
            RegistryKey registryOneKey = null;

            try
            {
                registryOneKey = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (registryOneKey != null)
                {
                    lastFolder = (string)registryOneKey.GetValue("lastFolder");
                    GameDuration = (int)registryOneKey.GetValue("GameDuration");
                    randomStart = Convert.ToBoolean(registryOneKey.GetValue("randomStart", false));           
                    MusicDuration = (int)registryOneKey.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(registryOneKey.GetValue("allDirectories", false));
                }
            }
            finally
            {
                if (registryOneKey != null) registryOneKey.Close();
            }
        }
    }
}

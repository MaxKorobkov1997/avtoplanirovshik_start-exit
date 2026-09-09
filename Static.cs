using System;
using System.Collections.Generic;
using System.Text;

namespace avtoplanirovshik_start_exit
{
    public class Static
    {
        public static string user = "Гость";
        public static Font font = new Font("Microsoft Sans Serif", 14);

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\avtoplanirovshik_start-exit.git";
        public static string file_start = path + @"\avtosapusk.txt";
        public static string file_exit = path + @"\exit.txt";

        public static string settingsPath = Path.Combine(path, "settings.json");
    }
    
}

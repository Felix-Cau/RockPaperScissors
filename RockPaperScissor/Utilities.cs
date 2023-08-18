using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Utilities
    {
        private static string FileDirectory = @"C:\development\rockpaperscissors\data\";

        public static void CheckForExistingDirectory()
        {
            var path = $"{FileDirectory}";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void SaveGame(string a)
        {
            var filename = a;
            var path = @$"{FileDirectory}{filename}";
            File.Create(path);
        }

        //public static void LoadSavedGames()
        //{

        //}
    }
}

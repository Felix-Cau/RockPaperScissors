using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Utilities
    {
        private static string directory = @"C:\development\rockpaperscissors\data\";

        public static void CheckForExistingDirectory()
        {
            string path = $"{directory}";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}

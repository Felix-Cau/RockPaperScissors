using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Utilities
    {
        public static string FileDirectory = @"C:\development\rockpaperscissors\data\";
        

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
            var path = Path.Combine(FileDirectory, filename);

            SaveFiles gameResultsInput = new();
            gameResultsInput.userWin = GameResults.UserWin;
            gameResultsInput.tie = GameResults.Tie;
            gameResultsInput.computerWin = GameResults.ComputerWin;
            var jsonGameResultInput = JsonSerializer.Serialize(gameResultsInput);
            File.WriteAllText(path, jsonGameResultInput);
        }

        public static void LoadSaveGame(string a)
        {
            var fileName = a;
            var path = Path.Combine(FileDirectory, fileName);
            var jsonGameResultOutput = File.ReadAllText(path);
            SaveFiles gameResultsOutput = JsonSerializer.Deserialize<SaveFiles>(jsonGameResultOutput);
            GameResults.UserWin = gameResultsOutput.userWin;
            GameResults.Tie = gameResultsOutput.tie;
            GameResults.ComputerWin = gameResultsOutput.computerWin;
        }

        public static void CheckAndDisplaySaveFileNames()
        {
            DirectoryInfo saveFileNames = new DirectoryInfo(FileDirectory);
            Console.WriteLine();
            foreach (var file in saveFileNames.EnumerateFiles())
            {
                Console.WriteLine(file.Name);
                
            }
            Console.WriteLine();
        }

        public static void DeleteSaveGameFile(string a)
        {
            var fileName = a;
            var path = Path.Combine(FileDirectory, fileName);
            File.Delete(path);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class MenuHandler
    {
        public static void MainMenu()
        {
            MessageHandler.Welcome();
            OperationOptions();
            Console.WriteLine($"\n{PrintStatistics()}\n");
        }

        public static void OperationOptions()
        {
            var operationOptions = new List<string>()
            {
                "1. Rock.",
                "2. Paper.",
                "3. Scissors.",
                "4. Reset game and start over.",
                "5. Save game.",
                "6. Load game.",
                "7. Delete Save game file.",
                "8. End this torture, exit program."
            };

            foreach (var option in operationOptions)
            {
                Console.WriteLine(option);
            }
        }

        public static string PrintStatistics()
        {
            var printStatistics = ($"User wins: {GameResults.UserWin}\tComputer wins: {GameResults.ComputerWin}\tTies: {GameResults.Tie}");
            return printStatistics;
        }

 
    }
}

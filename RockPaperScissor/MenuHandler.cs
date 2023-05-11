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
            Console.WriteLine("Welcome to my Rock Paper Scissors game.\nThe rules are as following: Rock beats Scissors, Paper beats Rock and Scissors beat Paper.\nSelect your operation and see if you beat the computer!");
            OperationOptions();
        }

        public static void SubMenu()
        {
            Console.WriteLine("Do you want to try again or do you give up?");
            OperationOptions();
        }

        public static void OperationOptions()
        {
            var operationOptions = new List<string>()
            {
                "1. Rock.",
                "2. Paper.",
                "3. Scissors.",
                "4. End this torture, exit program."
            };

            foreach (var option in operationOptions)
            {
                Console.WriteLine(option);
            }
        }

 
    }
}

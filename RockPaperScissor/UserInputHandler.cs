using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class UserInputHandler
    {
        public static void AskForUserInput()
        {
            Console.WriteLine("Select your action: ");
        }

        public static string AskUserToNameSaveFile()
        {
            var keepAsking = true;
            var fileName = "";

            do
            {
                Console.WriteLine("Save game name: ");
                string? userInput = Console.ReadLine();
                var userSaveFileName = userInput.Trim();
                if (!String.IsNullOrEmpty(userSaveFileName))
                {
                    fileName = $"{userSaveFileName}.txt";
                    keepAsking = false;
                }
                else
                {
                    Console.WriteLine("The save game must have a name.");
                }
            } while (keepAsking == true );
            return fileName;
        }
    }
}
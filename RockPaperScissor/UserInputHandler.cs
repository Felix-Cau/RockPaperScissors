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
                    fileName = $"{userSaveFileName}.json";
                    keepAsking = false;
                }
                else
                {
                    Console.WriteLine("The save game must have a name.");
                }
            } while (keepAsking == true );
            return fileName;
        }

        public static string AskForSaveFileName()
        {
            var keepAsking = true;
            var fileName = "";

            do
            {
                Console.WriteLine("Enter the name of the save file you wish to load:\nIMPORTANT! IT'S CASE SENSITIVE!");
                string? userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput))
                {
                    var path = Path.Combine(Utilities.FileDirectory, userInput);
                    if (File.Exists(path))
                    {
                        fileName = userInput;
                        keepAsking = false;
                    }
                    else
                    {
                        Console.WriteLine(MessageHandler.LoadGameNameError);
                    }
                }
                else
                {
                    Console.WriteLine(MessageHandler.LoadGameNameError);
                }
            } while ( keepAsking == true );
            return fileName;
            
        }


    }
}
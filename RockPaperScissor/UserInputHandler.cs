﻿using System;
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

        public static string AskForFileName()
        {
            var keepAsking = true;
            var fileName = "";

            do
            {
                Console.WriteLine("Enter the name of the file you want to select:\nIMPORTANT! IT'S CASE SENSITIVE!");
                string? userInput = Console.ReadLine();
                var userInputFileName = userInput.Trim();
                if (!String.IsNullOrEmpty(userInputFileName))
                {
                    var path = Path.Combine(Utilities.FileDirectory, userInputFileName);
                    if (File.Exists(path))
                    {
                        fileName = userInputFileName;
                        keepAsking = false;
                    }
                    else
                    {
                        Console.WriteLine(MessageHandler.FileNameError);
                    }
                }
                else
                {
                    Console.WriteLine(MessageHandler.FileNameError);
                }
            } while ( keepAsking == true );
            return fileName;
            
        }


    }
}
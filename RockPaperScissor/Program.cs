﻿using RockPaperScissors;

var resolution = new Entities();
var userEntity = new Entities();
var computerEntity = new Entities();

bool keepGoing = true;

Utilities.CheckForExistingDirectory();

do
{
    MenuHandler.MainMenu();
    UserInputHandler.AskForUserInput();
    string? userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1": //Rock
            Console.WriteLine(MessageHandler.YourChoiceRock);
            userEntity.Entity = "Rock";
            computerEntity.Entity = ComputerInputHandler.ComputerInput();
            MessageHandler.PrintComputerSelection(computerEntity.Entity);
            resolution.Resolution = EventResolutions.CalculateResolution(userEntity.Entity, computerEntity.Entity);
            EventResolutions.PrintAndSaveResult(resolution.Resolution);
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
        case "2": //Paper
            Console.WriteLine(MessageHandler.YourChoicePaper);
            userEntity.Entity = "Paper";
            computerEntity.Entity = ComputerInputHandler.ComputerInput();
            MessageHandler.PrintComputerSelection(computerEntity.Entity);
            resolution.Resolution = EventResolutions.CalculateResolution(userEntity.Entity, computerEntity.Entity);
            EventResolutions.PrintAndSaveResult(resolution.Resolution);
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
        case "3": //Scissors
            Console.WriteLine(MessageHandler.YourChoiceScissors);
            userEntity.Entity = "Scissors";
            computerEntity.Entity = ComputerInputHandler.ComputerInput();
            MessageHandler.PrintComputerSelection(computerEntity.Entity);
            resolution.Resolution = EventResolutions.CalculateResolution(userEntity.Entity, computerEntity.Entity);
            EventResolutions.PrintAndSaveResult(resolution.Resolution);
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
        case "4": //Reset
            Console.WriteLine(MessageHandler.ResetMessage);
            GameResults.ResetGameResult();
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
        case "5": //Save game
            //Add previously saved game view thingie
            var saveFileName = UserInputHandler.AskUserToNameSaveFile();
            Utilities.SaveGame(saveFileName);
            Console.WriteLine(MessageHandler.SaveGameMessage);
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
        case "6": //Load game
            Utilities.CheckAndDisplaySaveFileNames();
            var loadFileName = UserInputHandler.AskForFileName();
            Utilities.LoadSaveGame(loadFileName);
            Console.WriteLine(MessageHandler.LoadGameMessage);
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
        case "7": //Delete Save game file
            Utilities.CheckAndDisplaySaveFileNames();
            var deleteFileName = UserInputHandler.AskForFileName();
            Utilities.DeleteSaveGameFile(deleteFileName);
            Console.WriteLine(MessageHandler.SaveFileDeleted);
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
        case "8":
            keepGoing = false;
            Console.WriteLine(MessageHandler.ExitingProgram);
            Console.ReadKey();
            Console.Clear();
            break;
        default:
            Console.WriteLine(MessageHandler.InvalidInputMessage);
            Console.WriteLine(MessageHandler.PressAnyKey);
            Console.ReadKey();
            Console.Clear();
            break;
    }



} while (keepGoing == true);
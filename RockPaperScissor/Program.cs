﻿using RockPaperScissors;

var resolution = new Entities();
var userEntity = new Entities();
var computerEntity = new Entities();

bool keepGoing = true;

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
        case "4":
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
using RockPaperScissors;

var userWin = 0;
var computerWin = 0;
var tie = 0;
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

            break;
        case "2": //Paper
            break;
        case "3": //Scissors
            break;
        case "4":
            keepGoing = false;
            Console.WriteLine(MessageHandler.ExitingProgram);
            Console.ReadKey();
            break;
        default:
            Console.WriteLine(MessageHandler.InvalidInputMessage);
            break;
    }



} while (keepGoing == true);
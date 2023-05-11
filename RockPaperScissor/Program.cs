using RockPaperScissors;

var userWin = 0;
var computerWin = 0;
var userEntity = new Entities(); //Make it a string?
var computerEntity = new Entities(); //Make it a string?

bool keepGoing = true;

do
{
    MenuHandler.MainMenu();
    UserInputHandler.AskForUserInput();
    string? userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            //Rock
            Console.WriteLine(MessageHandler.YourChoiceRock);
            userEntity.Entity = "Rock";
            var computerSelection = ComputerInputHandler.ComputerInput();
            computerEntity.Entity = ComputerInputHandler.ComputerOutput(computerSelection);

            break;
        case "2":
            //Paper
            break;
        case "3":
            //Scissors
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
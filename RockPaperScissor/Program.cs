using RockPaperScissors;

var userWin = 0;
var computerWin = 0;

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

            break;
        case "2":
            //Paper
            break;
        case "3":
            //Scissors
            break;
        case "4":
            keepGoing = false;
            break;
        default:
            Console.WriteLine(MessageHandler.InvalidInputMessage);
            break;
    }



} while (keepGoing == true);
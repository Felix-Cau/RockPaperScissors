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

            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            keepGoing = false;
            break;
        default:
            break;
    }



} while (keepGoing == true);
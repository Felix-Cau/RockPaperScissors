using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class MessageHandler
    {
        private static string welcomeMessage => "Welcome to my Rock Paper Scissors game.\n\nThe rules are as following:\nRock beats Scissors, Paper beats Rock and Scissors beat Paper.\n\nSelect your operation and see if you can beat the computer!\n";
        public static void Welcome()
        {
            Console.WriteLine(welcomeMessage);
        }
        public static string InvalidInputMessage => "Invalid input, try again.";
        public static string YourChoiceRock => "You chose Rock.";
        public static string YourChoicePaper => "You chose Paper.";
        public static string YourChoiceScissors => "You chose Scissors.";
        public static string ComputerChoiceRock => "The computer chose Rock.";
        public static string ComputerChoicePaper => "The computer chose Paper.";
        public static string ComputerChoiceScissors => "The computer chose Scissors.";
        public static string ExitingProgram => "Exiting program. Press any key to continue.";
        public static string YouWon => "Congratulations, you won this round.";
        public static string YouLose => "Sorry, you lost this round.";
        public static string Tie => "It was a tie...";
        public static string PressAnyKey => "Press any key to continue.";
        public static string ResetMessage => "Resetting the game.";
        public static string SaveGameMessage => "Saved game successfully!";

        public static void PrintComputerSelection(string a)
        {
            if (a == "Rock")
            {
                Console.WriteLine(ComputerChoiceRock);
            }
            else if (a == "Paper")
            {
                Console.WriteLine(ComputerChoicePaper);
            }
            else if (a == "Scissors")
            {
                Console.WriteLine(ComputerChoiceScissors);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class MessageHandler
    {
        public static string InvalidInputMessage => "Invalid input, try again.";
        public static string YourChoiceRock => "You chose Rock.";
        public static string YourChoicePaper => "You chose Paper.";
        public static string YourChoiceScissors => "You chose Scissors.";
        public static string ComputerChoiceRock => "The computer chose Rock.";
        public static string ComputerChoicePaper => "The computer chose Paper.";
        public static string ComputerChoiceScissors => "The computer chose Scissors.";
        public static string ExitingProgram => "Exiting program. Press any key to continue.";

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

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

        public static void PrintComputerSelection(int a)
        {
            if (a == 1)
            {
                Console.WriteLine(ComputerChoiceRock);
            }
            else if (a == 2)
            {
                Console.WriteLine(ComputerChoicePaper);
            }
            else if (a == 3)
            {
                Console.WriteLine(ComputerChoiceScissors);
            }
        }
    }
}

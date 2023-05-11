using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class ComputerInputHandler
    {
        public static string ComputerInput()
        {
            var computerInput = new Random().Next(1, 4);
            var computerSelection = new Entities();
            computerSelection.Entity = ComputerSelection(computerInput);
            return computerSelection.Entity;
        }

        public static string ComputerSelection(int a)
        {
            if (a == 1)
            {
                Console.WriteLine(MessageHandler.ComputerChoiceRock);
                var rock = "Rock";
                return rock;
            }
            else if (a == 2)
            {
                Console.WriteLine(MessageHandler.ComputerChoicePaper);
                var paper = "Paper";
                return paper;
            }
            else
            {
                Console.WriteLine(MessageHandler.ComputerChoiceScissors);
                var scissors = "Scissors";
                return scissors;
            }
        }
    }
}

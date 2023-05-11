using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class ComputerInputHandler
    {
        public static int ComputerInput()
        {
            var computerInput = new Random().Next(1, 4);
            return computerInput;
        }

        public static string ComputerOutput(int a)
        {
            if (a == 1)
            {
                var rock = "Rock";
                return rock;
            }
            else if (a == 2)
            {
                var paper = "Paper";
                return paper;
            }
            else
            {
                var scissors = "Scissors";
                return scissors;
            }
        }
    }
}

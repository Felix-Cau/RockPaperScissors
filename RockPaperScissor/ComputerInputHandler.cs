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
    }
}

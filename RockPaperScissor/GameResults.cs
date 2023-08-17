﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class GameResults
    {
        public static int UserWin { get; set; }
        public static int ComputerWin { get; set; }
        public static int Tie { get; set; }

        public static void ResetGameResult()
        {
            UserWin = 0;
            ComputerWin = 0;
            Tie = 0;
        }
    }
}

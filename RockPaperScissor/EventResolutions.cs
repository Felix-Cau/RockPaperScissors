﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class EventResolutions
    {
        public static string CalculateResolution(string a, string b)
        {
            switch (a)
            {
                case "Rock":
                    if (b == "Rock")
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Tie";
                        return resolution.Resolution;
                    }
                    else if (b == "Paper")
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Loss";
                        return resolution.Resolution;
                    }
                    else
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Win";
                        return resolution.Resolution;
                    }
                case "Paper":
                    if (b == "Rock")
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Win";
                        return resolution.Resolution;
                    }
                    else if (b == "Paper")
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Tie";
                        return resolution.Resolution;
                    }
                    else
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Loss";
                        return resolution.Resolution;
                    }
                case "Scissors":
                    if (b == "Rock")
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Loss";
                        return resolution.Resolution;
                    }
                    else if (b == "Paper")
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Win";
                        return resolution.Resolution;
                    }
                    else
                    {
                        var resolution = new Entities();
                        resolution.Resolution = "Tie";
                        return resolution.Resolution;
                    }
            }
        }
    }
}
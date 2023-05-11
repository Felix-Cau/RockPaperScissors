using System;
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
            var resolution = new Entities();

            if (a == "Rock" && b == "Rock")
            {
                resolution.Resolution = "Tie";
                return resolution.Resolution;
            }
            else if (a == "Rock" && b == "Paper")
            {
                resolution.Resolution = "Loss";
                return resolution.Resolution;
            }
            else if (a == "Rock" && b == "Scissors")
            {
                resolution.Resolution = "Win";
                return resolution.Resolution;
            }
            else if (a == "Paper" && b == "Rock")
            {
                resolution.Resolution = "Win";
                return resolution.Resolution;
            }
            else if (a == "Paper" && b == "Paper")
            {
                resolution.Resolution = "Tie";
                return resolution.Resolution;
            }
            else if (a == "Paper" && b == "Scissors")
            {
                resolution.Resolution = "Loss";
                return resolution.Resolution;
            }
            else if (a == "Scissors" && b == "Rock")
            {
                resolution.Resolution = "Loss";
                return resolution.Resolution;
            }
            else if (a == "Scissors" && b == "Paper")
            {
                resolution.Resolution = "Win";
                return resolution.Resolution;
            }
            else
            {
                resolution.Resolution = "Loss";
                return resolution.Resolution;
            }

            //switch (a)
            //{
            //    case "Rock":
            //        if (b == "Rock")
            //        {
            //            resolution.Resolution = "Tie";
            //            return resolution.Resolution;
            //        }
            //        else if (b == "Paper")
            //        {
            //            resolution.Resolution = "Loss";
            //            return resolution.Resolution;
            //        }
            //        else
            //        {
            //            resolution.Resolution = "Win";
            //            return resolution.Resolution;
            //        }
            //    case "Paper":
            //        if (b == "Rock")
            //        {
            //            resolution.Resolution = "Win";
            //            return resolution.Resolution;
            //        }
            //        else if (b == "Paper")
            //        {
            //            resolution.Resolution = "Tie";
            //            return resolution.Resolution;
            //        }
            //        else
            //        {
            //            resolution.Resolution = "Loss";
            //            return resolution.Resolution;
            //        }
            //    case "Scissors":
            //        if (b == "Rock")
            //        {
            //            resolution.Resolution = "Loss";
            //            return resolution.Resolution;
            //        }
            //        else if (b == "Paper")
            //        {
            //            resolution.Resolution = "Win";
            //            return resolution.Resolution;
            //        }
            //        else
            //        {
            //            resolution.Resolution = "Tie";
            //            return resolution.Resolution;
            //        }
            //}
        }

        public static void PrintAndSaveResult(string a)
        {
            if (a == "Win")
            {
                Console.WriteLine(MessageHandler.YouWon);
                GameResults.UserWin++;
            }
            else if (a == "Loss")
            {
                Console.WriteLine(MessageHandler.YouLose);
                GameResults.ComputerWin++;
            }
            else if (a == "Tie")
            {
                Console.WriteLine(MessageHandler.Tie);
                GameResults.Tie++;
            }
        }
    }
}

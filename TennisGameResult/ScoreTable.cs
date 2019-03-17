using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameResult
{
    public class ScoreTable
    {
        public int playerOneScore { get; set; }
        public int playerTwoScore { get; set; }


        public string score()
        {
            var playerOneSubPlayerTwo = playerOneScore - playerTwoScore;
            float scoreAvg = (playerOneScore + playerTwoScore) / 2f;


            if (scoreAvg == 0)
            {
                return "AllLove";
            }

            else if (scoreAvg >= 3)
            {
                switch (playerOneSubPlayerTwo)
                {
                    case 0:
                        return "Deuce";
                    case 1:
                        return "PlayerOneDecue1";
                    case -1:
                        return "PlayerTwoDecue1";
                    case 2:
                        return "PlayerOneWin!!!";
                    case -2:
                        return "PlayerTwoWin!!!";
                }
            }

            else if (playerOneSubPlayerTwo != 0)
            {
                if (playerOneSubPlayerTwo == 3 || playerOneSubPlayerTwo == -3)
                {
                    if (playerOneSubPlayerTwo > 0)
                    {
                        return "40Love";
                    }
                    else
                    {
                        return "Love40";
                    }
                }
                else
                {
                    if (playerOneSubPlayerTwo > 0)
                    {
                        return (playerOneSubPlayerTwo * 15 + "Love");
                    }
                    else
                    {
                        return ("Love" + playerOneSubPlayerTwo * -15);
                    }
                }
            }


            var result = scoreAvg * 15;
            return result.ToString() + result;
        }

    }
}


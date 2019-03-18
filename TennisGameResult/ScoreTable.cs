using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameResult
{
    public class ScoreTable
    {
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }


        public string Result()
        {
            var playerOneSubPlayerTwo = PlayerOneScore - PlayerTwoScore;
            var scoreAvg = (PlayerOneScore + PlayerTwoScore) / 2f;

            if (scoreAvg == 0)
            {
                return "Love All";
            }

            if (scoreAvg >= 3)
            {
                if (Math.Abs(playerOneSubPlayerTwo) >= 3)
                {
                    return "Out of Rule";
                }
                switch (playerOneSubPlayerTwo)
                {
                    case 0:
                        return "Deuce";
                    case 1:
                        return PlayerOneName + " Deuce One";
                    case -1:
                        return PlayerTwoName + " Deuce One";
                    case 2:
                        return PlayerOneName + " Win!!!";
                    case -2:
                        return PlayerTwoName + " Win!!!";
                }
            }

            if (PlayerOneScore >= 4 || PlayerTwoScore >= 4)
            {
                return playerOneSubPlayerTwo > 0 ? PlayerOneName + " Win!!!" : PlayerTwoName + " Win!!!";
            }
            return TranslateScore(PlayerOneScore) + " " + TranslateScore(PlayerTwoScore);
        }

        private string TranslateScore(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "15";
                case 2:
                    return "30";
                case 3:
                    return "40";
                default:
                    return null;
            }
        }
    }
}


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
            var deuceCondition = 3;
            var winCondition = 4;

            if (scoreAvg == 0)
            {
                return "Love All";
            }

            if (scoreAvg >= deuceCondition || playerOneSubPlayerTwo >= winCondition)
            {
                switch (playerOneSubPlayerTwo)
                {
                    case 0:
                        return "Deuce";
                    case 1:
                        return PlayerOneName + " Deuce One";
                    case -1:
                        return PlayerTwoName + " Deuce One";
                    case 2:
                    case 4:
                        return PlayerOneName + " Win!!!";
                    case -2:
                    case -4:
                        return PlayerTwoName + " Win!!!";
                }
                return "Out of Rule";
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


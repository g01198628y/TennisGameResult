using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameResult
{
    public class ScoreTable
    {
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
                switch (playerOneSubPlayerTwo)
                {
                    case 0:
                        return "Deuce";
                    case 1:
                        return "PlayerOne Deuce1";
                    case -1:
                        return "PlayerTwo Deuce1";
                    case 2:
                        return "PlayerOne Win!!!";
                    case -2:
                        return "PlayerTwo Win!!!";
                }
            }

            if (PlayerOneScore == 4 || PlayerTwoScore == 4)
            {
                return playerOneSubPlayerTwo > 0 ? "PlayerOne Win!!!" : "PlayerTwo Win!!!";
            }
            return TranslateScore(PlayerOneScore) + TranslateScore(PlayerTwoScore);
        }

        public string TranslateScore(int score)
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


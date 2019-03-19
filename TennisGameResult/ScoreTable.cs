using System.Collections.Generic;

namespace TennisGameResult
{
    public class ScoreTable
    {
        private int _winCondition = 4;
        private int _deuceCondition = 3;
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }

        public string Result()
        {
            var playerOneSubPlayerTwo = PlayerOneScore - PlayerTwoScore;
            var scoreAvg = (PlayerOneScore + PlayerTwoScore) / 2;

            if (scoreAvg == 0 && playerOneSubPlayerTwo == 0)
            {
                return "Love All";
            }

            if (scoreAvg >= _deuceCondition || playerOneSubPlayerTwo >= _winCondition)
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
            return TranslateScoreDictionary[PlayerOneScore] + " " + TranslateScoreDictionary[PlayerTwoScore];
        }

        private readonly Dictionary<int, string> TranslateScoreDictionary = new Dictionary<int, string>()
        {
            {0, "Love"}, {1, "15"}, {2, "30"}, {3, "40"}
        };
    }
}
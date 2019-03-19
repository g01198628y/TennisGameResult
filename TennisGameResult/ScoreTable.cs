using System;
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

            if (PlayerOneScore == 0 && PlayerTwoScore == 0)
            {
                return "Love All";
            }

            if (Math.Abs(playerOneSubPlayerTwo) >= _winCondition || (PlayerOneScore >= _deuceCondition && PlayerTwoScore >= _deuceCondition))
            {
                switch (playerOneSubPlayerTwo)
                {
                    case (int)DeuceOrWinCase.TwoPlayerSameScore:
                        return "Deuce";

                    case (int)DeuceOrWinCase.PlayerOneScoreOneMore:
                        return PlayerOneName + " Deuce One";

                    case (int)DeuceOrWinCase.PlayerTwoScoreOneMore:
                        return PlayerTwoName + " Deuce One";

                    case (int)DeuceOrWinCase.PlayerOneScoreTwoMore:
                    case (int)DeuceOrWinCase.PlayerOneScoreIsFourAndPlayerTwoScoreIsZero:
                        return PlayerOneName + " Win!!!";

                    case (int)DeuceOrWinCase.PlayerTwoScoreTwoMore:
                    case (int)DeuceOrWinCase.PlayerOneScoreIsZeroAndPlayerTwoScoreIsFour:
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

        private enum DeuceOrWinCase
        {
            TwoPlayerSameScore = 0,
            PlayerOneScoreOneMore = 1,
            PlayerTwoScoreOneMore = -1,
            PlayerOneScoreTwoMore = 2,
            PlayerTwoScoreTwoMore = -2,
            PlayerOneScoreIsFourAndPlayerTwoScoreIsZero = 4,
            PlayerOneScoreIsZeroAndPlayerTwoScoreIsFour = -4
        }
    }
}
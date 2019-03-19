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

            if (Math.Abs(playerOneSubPlayerTwo) >= _winCondition || PlayerReadyToWin())
            {
                switch (playerOneSubPlayerTwo)
                {
                    case (int)DeuceOrWinCase.TwoPlayerSameScore:
                        return "Deuce";

                    case (int)DeuceOrWinCase.PlayerOneScoreOneMore:
                    case (int)DeuceOrWinCase.PlayerTwoScoreOneMore:
                        return PlayerDeuceResult();

                    case (int)DeuceOrWinCase.PlayerOneScoreTwoMore:
                    case (int)DeuceOrWinCase.PlayerTwoScoreTwoMore:
                    case (int)DeuceOrWinCase.PlayerOneScoreIsFourAndPlayerTwoScoreIsZero:
                    case (int)DeuceOrWinCase.PlayerOneScoreIsZeroAndPlayerTwoScoreIsFour:
                        return PlayerWinResult();
                }
                return "Out of Rule";
            }

            return $"{TranslateScoreDictionary[PlayerOneScore]} {TranslateScoreDictionary[PlayerTwoScore]}";
        }

        private string PlayerWinResult()
        {
            return PlayerOneScore > PlayerTwoScore ? PlayerOneName + " Win!!!" : PlayerTwoName + " Win!!!";
        }

        private string PlayerDeuceResult()
        {
            return PlayerOneScore > PlayerTwoScore ? PlayerOneName + " Deuce One" : PlayerTwoName + " Deuce One";
        }

        private bool PlayerReadyToWin()
        {
            return (PlayerOneScore >= _deuceCondition && PlayerTwoScore >= _deuceCondition);
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
using System;
using System.Collections.Generic;

namespace TennisGameResult
{
    public class ScoreTable
    {
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }
        private const int WinCondition = 4;
        private const int DeuceCondition = 3;

        public string Result()
        {
            var playerOneSubPlayerTwo = PlayerOneScore - PlayerTwoScore;

            if (AllPlayerScoreZero())
            {
                return "Love All";
            }

            if (playerOneSubPlayerTwo != WinCondition && !PlayerReadyToWin())
                return $"{TranslateScoreDictionary[PlayerOneScore]} {TranslateScoreDictionary[PlayerTwoScore]}";

            switch (Math.Abs(playerOneSubPlayerTwo))
            {
                case (int)DeuceOrWinCase.TwoPlayerSameScore:
                    return "Deuce";

                case (int)DeuceOrWinCase.OnePlayerScoreOneMore:
                    return PlayerDeuceResult();

                case (int)DeuceOrWinCase.OnePlayerScoreTwoMore:
                case (int)DeuceOrWinCase.OnePlayerScoreFourMore:
                    return PlayerWinResult();
            }
            return "Out of Rule";
        }

        private bool AllPlayerScoreZero()
        {
            return PlayerOneScore == 0 && PlayerTwoScore == 0;
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
            return (PlayerOneScore >= DeuceCondition && PlayerTwoScore >= DeuceCondition);
        }

        private readonly Dictionary<int, string> TranslateScoreDictionary = new Dictionary<int, string>()
        {
            {0, "Love"}, {1, "15"}, {2, "30"}, {3, "40"}
        };

        private enum DeuceOrWinCase
        {
            TwoPlayerSameScore = 0,
            OnePlayerScoreOneMore = 1,
            OnePlayerScoreTwoMore = 2,
            OnePlayerScoreFourMore = 4,
        }
    }
}
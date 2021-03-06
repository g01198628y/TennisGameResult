﻿using System;
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
            var hightestScore = GetHigherScore();
            if (IsAllPlayerScoreZero())
            {
                return "Love All";
            }

            if (!IsPlayerInDeuceCondition() && IsHighestScoreSmallerThanWinCondition(hightestScore))
                return $"{TranslateScoreDictionary[PlayerOneScore]} {TranslateScoreDictionary[PlayerTwoScore]}";

            if (IsPlayerInDeuceCondition() || hightestScore == WinCondition)
            {
                switch ((DeuceOrWinCase)Math.Abs(playerOneSubPlayerTwo))
                {
                    case DeuceOrWinCase.TwoPlayerSameScore:
                        return "Deuce";

                    case DeuceOrWinCase.OnePlayerScoreOneMore:
                        return PlayerDeuceResult();

                    case DeuceOrWinCase.OnePlayerScoreTwoMore:
                    case DeuceOrWinCase.OnePlayerScoreFourMore:
                        return PlayerWinResult();
                }
            }

            return "Out of Rule";
        }

        private static bool IsHighestScoreSmallerThanWinCondition(int hightestScore)
        {
            return hightestScore < WinCondition;
        }

        private int GetHigherScore()
        {
            return PlayerOneScore > PlayerTwoScore ? PlayerOneScore : PlayerTwoScore;
        }

        private bool IsAllPlayerScoreZero()
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

        private bool IsPlayerInDeuceCondition()
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
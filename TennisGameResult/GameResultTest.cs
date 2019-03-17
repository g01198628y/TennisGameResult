using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameResult
{
    [TestClass]
    public class GameResultTest
    {
        [TestMethod]
        public void GetGameResult_0vs0_Should_Return_LoveAll()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 0;
            scoreTable.PlayerTwoScore = 0;
            var result = scoreTable.Result();
            Assert.AreEqual("Love All", result);
        }

        [TestMethod]
        public void GetGameResult_1vs0_Should_Return_15vsLove()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 1;
            scoreTable.PlayerTwoScore = 0;
            var result = scoreTable.Result();
            Assert.AreEqual("15Love", result);
        }

        [TestMethod]
        public void GetGameResult_2vs0_Should_Return_30vsLove()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 2;
            scoreTable.PlayerTwoScore = 0;
            var result = scoreTable.Result();
            Assert.AreEqual("30Love", result);
        }
        [TestMethod]
        public void GetGameResult_3vs0_Should_Return_40vsLove()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 3;
            scoreTable.PlayerTwoScore = 0;
            var result = scoreTable.Result();
            Assert.AreEqual("40Love", result);
        }
        [TestMethod]
        public void GetGameResult_1vs1_Should_Return_15vs15()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 1;
            scoreTable.PlayerTwoScore = 1;
            var result = scoreTable.Result();
            Assert.AreEqual("1515", result);
        }
        [TestMethod]
        public void GetGameResult_0vs1_Should_Return_0vsLove()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 0;
            scoreTable.PlayerTwoScore = 1;
            var result = scoreTable.Result();
            Assert.AreEqual("Love15", result);
        }
        [TestMethod]
        public void GetGameResult_2vs3_Should_Return_30vs40()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 2;
            scoreTable.PlayerTwoScore = 3;
            var result = scoreTable.Result();
            Assert.AreEqual("3040", result);
        }
        [TestMethod]
        public void GetGameResult_3vs3_Should_Return_Deuce()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 3;
            scoreTable.PlayerTwoScore = 3;
            var result = scoreTable.Result();
            Assert.AreEqual("Deuce", result);
        }
        [TestMethod]
        public void GetGameResult_4vs3_Should_Return_P1Deuce1()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 4;
            scoreTable.PlayerTwoScore = 3;
            var result = scoreTable.Result();
            Assert.AreEqual("PlayerOne Deuce1", result);
        }
        [TestMethod]
        public void GetGameResult_4vs4_Should_Return_Deuce()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 4;
            scoreTable.PlayerTwoScore = 4;
            var result = scoreTable.Result();
            Assert.AreEqual("Deuce", result);
        }
        [TestMethod]
        public void GetGameResult_4vs5_Should_Return_P2Deuce1()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 4;
            scoreTable.PlayerTwoScore = 5;
            var result = scoreTable.Result();
            Assert.AreEqual("PlayerTwo Deuce1", result);
        }
        [TestMethod]
        public void GetGameResult_4vs6_Should_Return_P2Win()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 4;
            scoreTable.PlayerTwoScore = 6;
            var result = scoreTable.Result();
            Assert.AreEqual("PlayerTwo Win!!!", result);
        }

    }
}

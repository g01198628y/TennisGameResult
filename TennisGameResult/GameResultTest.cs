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
            var scores = new ScoreTable();
            scores.PlayerOneScore = 0;
            scores.PlayerTwoScore = 0;
            var result = scores.Result();
            Assert.AreEqual("All Love", result);
        }

        [TestMethod]
        public void GetGameResult_1vs0_Should_Return_15vsLove()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 1;
            scores.PlayerTwoScore = 0;
            var result = scores.Result();
            Assert.AreEqual("15Love", result);
        }

        [TestMethod]
        public void GetGameResult_2vs0_Should_Return_30vsLove()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 2;
            scores.PlayerTwoScore = 0;
            var result = scores.Result();
            Assert.AreEqual("30Love", result);
        }
        [TestMethod]
        public void GetGameResult_3vs0_Should_Return_40vsLove()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 3;
            scores.PlayerTwoScore = 0;
            var result = scores.Result();
            Assert.AreEqual("40Love", result);
        }
        [TestMethod]
        public void GetGameResult_1vs1_Should_Return_15vs15()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 1;
            scores.PlayerTwoScore = 1;
            var result = scores.Result();
            Assert.AreEqual("1515", result);
        }
        [TestMethod]
        public void GetGameResult_0vs1_Should_Return_0vsLove()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 0;
            scores.PlayerTwoScore = 1;
            var result = scores.Result();
            Assert.AreEqual("Love15", result);
        }
        [TestMethod]
        public void GetGameResult_2vs3_Should_Return_30vs40()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 2;
            scores.PlayerTwoScore = 3;
            var result = scores.Result();
            Assert.AreEqual("3040", result);
        }
        [TestMethod]
        public void GetGameResult_3vs3_Should_Return_Deuce()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 3;
            scores.PlayerTwoScore = 3;
            var result = scores.Result();
            Assert.AreEqual("Deuce", result);
        }
        [TestMethod]
        public void GetGameResult_4vs3_Should_Return_P1Deuce1()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 4;
            scores.PlayerTwoScore = 3;
            var result = scores.Result();
            Assert.AreEqual("PlayerOne Deuce1", result);
        }
        [TestMethod]
        public void GetGameResult_4vs4_Should_Return_Deuce()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 4;
            scores.PlayerTwoScore = 4;
            var result = scores.Result();
            Assert.AreEqual("Deuce", result);
        }
        [TestMethod]
        public void GetGameResult_4vs5_Should_Return_P2Deuce1()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 4;
            scores.PlayerTwoScore = 5;
            var result = scores.Result();
            Assert.AreEqual("PlayerTwo Deuce1", result);
        }
        [TestMethod]
        public void GetGameResult_4vs6_Should_Return_P2Win()
        {
            var scores = new ScoreTable();
            scores.PlayerOneScore = 4;
            scores.PlayerTwoScore = 6;
            var result = scores.Result();
            Assert.AreEqual("PlayerTwo Win!!!", result);
        }

    }
}

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
            scores.playerOneScore = 0;
            scores.playerTwoScore = 0;
            var result = scores.score();
            Assert.AreEqual("AllLove",result);
        }

        [TestMethod]
        public void GetGameResult_1vs0_Should_Return_15vsLove()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 1;
            scores.playerTwoScore = 0;
            var result = scores.score();
            Assert.AreEqual("15Love", result);
        }

        [TestMethod]
        public void GetGameResult_2vs0_Should_Return_30vsLove()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 2;
            scores.playerTwoScore = 0;
            var result = scores.score();
            Assert.AreEqual("30Love", result);
        }
        [TestMethod]
        public void GetGameResult_3vs0_Should_Return_40vsLove()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 3;
            scores.playerTwoScore = 0;
            var result = scores.score();
            Assert.AreEqual("40Love", result);
        }
        [TestMethod]
        public void GetGameResult_1vs1_Should_Return_15vs15()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 1;
            scores.playerTwoScore = 1;
            var result = scores.score();
            Assert.AreEqual("1515", result);
        }
        [TestMethod]
        public void GetGameResult_0vs1_Should_Return_0vsLove()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 0;
            scores.playerTwoScore = 1;
            var result = scores.score();
            Assert.AreEqual("Love15", result);
        }
        [TestMethod]
        public void GetGameResult_3vs3_Should_Return_Deuce()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 3;
            scores.playerTwoScore = 3;
            var result = scores.score();
            Assert.AreEqual("Deuce", result);
        }
        [TestMethod]
        public void GetGameResult_4vs3_Should_Return_P1Deuce1()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 4;
            scores.playerTwoScore = 3;
            var result = scores.score();
            Assert.AreEqual("PlayerOneDecue1", result);
        }
        [TestMethod]
        public void GetGameResult_4vs4_Should_Return_Deuce()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 4;
            scores.playerTwoScore = 4;
            var result = scores.score();
            Assert.AreEqual("Deuce", result);
        }
        [TestMethod]
        public void GetGameResult_4vs5_Should_Return_P2Deuce1()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 4;
            scores.playerTwoScore = 5;
            var result = scores.score();
            Assert.AreEqual("PlayerTwoDecue1", result);
        }
        [TestMethod]
        public void GetGameResult_4vs6_Should_Return_P2Win()
        {
            var scores = new ScoreTable();
            scores.playerOneScore = 4;
            scores.playerTwoScore = 6;
            var result = scores.score();
            Assert.AreEqual("PlayerTwoWin!!!", result);
        }

        

    }
}

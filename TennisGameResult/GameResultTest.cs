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
            Assert.AreEqual("15 Love", result);
        }

        [TestMethod]
        public void GetGameResult_2vs0_Should_Return_30vsLove()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 2;
            scoreTable.PlayerTwoScore = 0;
            var result = scoreTable.Result();
            Assert.AreEqual("30 Love", result);
        }

        [TestMethod]
        public void GetGameResult_3vs0_Should_Return_40vsLove()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 3;
            scoreTable.PlayerTwoScore = 0;
            var result = scoreTable.Result();
            Assert.AreEqual("40 Love", result);
        }

        [TestMethod]
        public void GetGameResult_4vs0_Should_Return_P1Win()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 4;
            scoreTable.PlayerTwoScore = 0;
            scoreTable.PlayerOneName = "P1";
            scoreTable.PlayerTwoName = "P2";
            var result = scoreTable.Result();
            Assert.AreEqual("P1 Win!!!", result);
        }

        [TestMethod]
        public void GetGameResult_1vs1_Should_Return_15vs15()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 1;
            scoreTable.PlayerTwoScore = 1;
            var result = scoreTable.Result();
            Assert.AreEqual("15 15", result);
        }

        [TestMethod]
        public void GetGameResult_0vs1_Should_Return_0vsLove()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 0;
            scoreTable.PlayerTwoScore = 1;
            var result = scoreTable.Result();
            Assert.AreEqual("Love 15", result);
        }

        [TestMethod]
        public void GetGameResult_2vs3_Should_Return_30vs40()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 2;
            scoreTable.PlayerTwoScore = 3;
            var result = scoreTable.Result();
            Assert.AreEqual("30 40", result);
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
            scoreTable.PlayerOneName = "P1";
            scoreTable.PlayerTwoName = "P2";
            var result = scoreTable.Result();
            Assert.AreEqual("P1 Deuce One", result);
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
            scoreTable.PlayerOneName = "P1";
            scoreTable.PlayerTwoName = "P2";
            var result = scoreTable.Result();
            Assert.AreEqual("P2 Deuce One", result);
        }

        [TestMethod]
        public void GetGameResult_4vs6_Should_Return_P2Win()
        {
            var scoreTable = new ScoreTable();
            scoreTable.PlayerOneScore = 4;
            scoreTable.PlayerTwoScore = 6;
            scoreTable.PlayerOneName = "P1";
            scoreTable.PlayerTwoName = "P2";
            var result = scoreTable.Result();
            Assert.AreEqual("P2 Win!!!", result);
        }
    }
}
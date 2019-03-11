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
            scores.p1 = 0;
            scores.p2 = 0;
            var result = scores.score();
            Assert.AreEqual("AllLove",result);
        }

        [TestMethod]
        public void GetGameResult_1vs0_Should_Return_15vsLove()
        {
            var scores = new ScoreTable();
            scores.p1 = 1;
            scores.p2 = 0;
            var result = scores.score();
            Assert.AreEqual("15vsLove", result);
        }

        [TestMethod]
        public void GetGameResult_2vs0_Should_Return_30vsLove()
        {
            var scores = new ScoreTable();
            scores.p1 = 2;
            scores.p2 = 0;
            var result = scores.score();
            Assert.AreEqual("30vsLove", result);
        }
        [TestMethod]
        public void GetGameResult_3vs0_Should_Return_40vsLove()
        {
            var scores = new ScoreTable();
            scores.p1 = 3;
            scores.p2 = 0;
            var result = scores.score();
            Assert.AreEqual("40vsLove", result);
        }
        [TestMethod]
        public void GetGameResult_1vs1_Should_Return_15vs15()
        {
            var scores = new ScoreTable();
            scores.p1 = 1;
            scores.p2 = 1;
            var result = scores.score();
            Assert.AreEqual("15vs15", result);
        }
        [TestMethod]
        public void GetGameResult_0vs1_Should_Return_0vsLove()
        {
            var scores = new ScoreTable();
            scores.p1 = 0;
            scores.p2 = 1;
            var result = scores.score();
            Assert.AreEqual("Lovevs15", result);
        }

        

    }
}

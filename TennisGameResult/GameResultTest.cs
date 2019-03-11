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

    }
}

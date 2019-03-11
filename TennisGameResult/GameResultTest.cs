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
    }

    public class ScoreTable
    {
        public int p1 { get; set; }
        public int p2 { get; set; }

        public string score()
        {
            return "AllLove";
        }
    }
}

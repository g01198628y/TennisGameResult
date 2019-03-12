using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameResult
{
    public class ScoreTable
    {
        public int p1 { get; set; }
        public int p2 { get; set; }

        public string score()
        {
            var sub = p1 - p2;
            var totalScoreAvg = (p1 + p2) / 2;

            if (p1 > p2)
            {

                if (p1 - p2 == 1 && totalScoreAvg < 3)
                {
                    return (sub * 15 + "Love");
                }
                else if (p1 - p2 == 2)
                {
                    return (sub * 15 + "Love");
                }

                else if (p1 - p2 == 3)
                {
                    return "40Love";
                }
                else if (p1 - p2 == 1 && totalScoreAvg >= 3)
                {
                    return "P1Deuce1";
                }
            }

            else if (p1 < p2)
            {
                if (p1 - p2 == -1)
                {
                    return "Love15";
                }
            }

            else
            {

                 if (totalScoreAvg >= 3)
                {
                    return "Deuce";
                }

                else if (totalScoreAvg == 1)
                {
                    var result = totalScoreAvg * 15;
                    return result.ToString() + result;
                }
                else if (totalScoreAvg == 0)
                {
                    return "AllLove";
                }
            }

            return null;
        }
    }
}

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
            if (p1 > p2)
            {
                if (p1 - p2 == 1)
                {
                    var result = p1 - p2;

                    return (result * 15 + "Love");
                }
                else if (p1 - p2 == 2)
                {
                    var result = p1 - p2;

                    return (result * 15 + "Love");
                }

                else if (p1 - p2 == 3)
                {
                    return "40Love";
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
                var totalScoreAvg = (p1 + p2) / 2;
                if (totalScoreAvg == 3)
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

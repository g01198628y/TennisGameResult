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
            var p1Subp2 = p1 - p2;
            var p2Subp1 = p2 - p1;
            var totalScoreAvg = (p1 + p2) / 2;

            if (p1 > p2)
            {

                if (p1Subp2 == 1 && totalScoreAvg < 3)
                {
                    return (p1Subp2 * 15 + "Love");
                }
                else if (p1Subp2 == 2)
                {
                    return (p1Subp2 * 15 + "Love");
                }

                else if (p1Subp2 == 3)
                {
                    return "40Love";
                }
                else if (p1Subp2 == 1 && totalScoreAvg >= 3)
                {
                    return "P1Deuce1";
                }
                else
                {
                    return "P1Win";
                }
            }

            else if (p1 < p2)
            {
                if (p2Subp1 == 1 && totalScoreAvg < 3)
                {
                    return "Love"+ p2Subp1*15;
                }
                else if (p2Subp1 == 1 && totalScoreAvg >= 3)
                {
                    return "P2Deuce1";
                }
                else
                {
                    return "P2Win";
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

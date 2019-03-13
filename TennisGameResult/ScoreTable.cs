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
            var totalScoreAvg = (p1 + p2) / 2;


            if (totalScoreAvg >= 3)
            {
                if (p1 == p2)
                {
                    return "Deuce";
                }
                else if (p1Subp2 == 1)
                {
                    return "P1Deuce1";
                }
                else if (p1Subp2 == -1)
                {
                    return "P2Deuce1";
                }
                else if (p1Subp2 == 2)
                {
                    return "P1Win";
                }
                else
                {
                    return "P2Win";
                }
            }

            else if (p1Subp2 > 0)
            {
                if (p1Subp2 == 3)
                {
                    return "40Love";
                }
                return (p1Subp2 * 15 + "Love");

            }

            else if (p1Subp2 < 0)
            {
                if (p1Subp2 == -3)
                {
                    return "Love40";
                }
                return ("Love"+p1Subp2 * -15 );
            }

            else
            {
                if (totalScoreAvg == 0)
                {
                    return "AllLove";
                }

                var result = totalScoreAvg * 15;
                return result.ToString() + result;

            }

            return null;
        }
    }
}

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

                    return (result * 15 + "vs" + "Love");
                }
                else if (p1 - p2 == 2)
                {
                    var result = p1 - p2;

                    return (result * 15 + "vs" + "Love");
                }

                else if (p1 - p2 == 3)
                {
                    return "40vsLove";
                }
            }
            else if (p1 < p2)
            {
                if (p1 - p2 == -1)
                {
                    return "Lovevs15";
                }
            }

            else
            {
                if ((p1 + p2) / 2 == 1)
                {
                    return "15vs15";
                }
                else if ((p1 + p2) / 2 == 0)
                {
                    return "AllLove";
                }
            }

            return null;
        }
    }
}

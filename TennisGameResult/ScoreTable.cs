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
            if (p1 == p2)
            {
                return "AllLove";
            }
            else if (p1 > p2)
            {
                return "15vsLove";
            }

            return null;
        }
    }
}

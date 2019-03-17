using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisGameResult;

namespace TennisGameResultConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Enter The Tennis Game Score.");
                Console.WriteLine("Player One's Score:");
                var playerOneScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Player Two's Score:");
                var playerTwoScore = int.Parse(Console.ReadLine());
                var playersScore = new ScoreTable {PlayerOneScore = playerOneScore, PlayerTwoScore = playerTwoScore};
                var gameResult = playersScore.Result();
                Console.WriteLine(""+gameResult);
                Console.ReadKey();
            }
        }
    }
}

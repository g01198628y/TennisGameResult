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
                Console.WriteLine("Please Enter Player One Name:");
                var playerOneName = Console.ReadLine();
                Console.WriteLine("Please Enter Player Two Name:");
                var playerTwoName = Console.ReadLine();
                Console.WriteLine("Player One's Score:");
                var playerOneScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Player Two's Score:");
                var playerTwoScore = int.Parse(Console.ReadLine());
                var playersScore = new ScoreTable {PlayerOneName = playerOneName,PlayerTwoName = playerTwoName, PlayerOneScore = playerOneScore, PlayerTwoScore = playerTwoScore};
                var gameResult = playersScore.Result();
                Console.WriteLine("GameResult: "+gameResult);
                Console.ReadKey();
            }
        }
    }
}

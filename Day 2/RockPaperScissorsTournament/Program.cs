using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataLines = System.IO.File.ReadLines(@"C:\Users\DavideLorino\source\repos\Advent of Code 2022\Day 1\RockPaperScissorsTournament\TournamentStrategy.txt");
            var strategy = dataLines.Select(x => x.Split(' '));
            ComputeScore.ComputeFinalScore(strategy);
            Console.WriteLine(strategy.Count());
        }
    }
}

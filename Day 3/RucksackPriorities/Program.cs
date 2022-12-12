using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RucksackPriorities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataLines = System.IO.File.ReadLines(@"C:\Users\DavideLorino\source\repos\Advent of Code 2022\Day 1\RucksackPriorities\Day3Input.txt");
            var compartmentalised_rucksack = SplitCompartments.SplitRucksackCompartments(dataLines);
            List<char> matching_rucksack_items = FindMatchingItems.FindMatchingRucksackItems(compartmentalised_rucksack);
            List<(char, int)> priority_table = DefinePriorities.DefineItemPriorities();
            /*
            for (int i = 0; i < compartmentalised_rucksack.Count(); i++)
            {
                Console.Write(compartmentalised_rucksack.ElementAt(i).ElementAt(0));
                Console.Write(" ");
                Console.WriteLine(compartmentalised_rucksack.ElementAt(i).ElementAt(1));
                Console.WriteLine($"Matching item: {matching_rucksack_items[i]}");

            }
            */
            /*
            foreach(IEnumerable<string> compartment in compartmentalised_rucksack)
            {
                Console.Write(compartment.ElementAt(0));
                Console.Write(" ");
                Console.WriteLine(compartment.ElementAt(1));
            }
            */
        }
    }
}

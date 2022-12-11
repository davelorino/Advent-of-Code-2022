using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounting
{
    public class FileReader
    {
        public static string CalorieFileReader()
        {
            string inventory = System.IO.File.ReadAllText(@"C:\Users\DavideLorino\source\repos\Advent of Code 2022\Day 1\CalorieCounting\Day1Input.txt").Trim('\n');
            return inventory;
        }
    }
}

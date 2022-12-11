using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalorieCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inventory = FileReader.CalorieFileReader();
            var sum = inventory.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.None)
                .Select(f => f.Split(new string[] { "\r\n" }, StringSplitOptions.None)
                    .Select(num => int.Parse(num.Trim()))
                    .Sum()).ToList();
            Console.WriteLine(sum.Max());
            Console.WriteLine(sum.OrderByDescending(f => f).Take(3).Sum());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RucksackPriorities
{
    public static class Extensions
    {
        public static IEnumerable<string> Split(this string str, int n)
        {
            if (String.IsNullOrEmpty(str) || n < 1)
            {
                throw new ArgumentException();
            }

            return Enumerable.Range(0, str.Length / n)
                             .Select(i => str.Substring(i * n, n));
        }
    }

    public class SplitCompartments
    {
        public static IEnumerable<IEnumerable<String>> SplitRucksackCompartments(IEnumerable<string> rucksack)
        {
            var compartmentalised_rucksack = rucksack.Select(r => r.Split(r.Length / 2));
            return compartmentalised_rucksack; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This creates the a-z and A-Z arrays with corresponding prioritiy rankings
// as determined by the Advent of Code instructions 
// 1-26 for a-z and 27-53 for A-Z
namespace RucksackPriorities
{
    public class DefinePriorities
    {
        public static List<(char, int)> DefineItemPriorities() 
        {
            List<(char, int)> item_priorities = new List<(char, int)>();
            char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            char[] AZ = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
            var aZ = az.Concat(AZ);
            int[] priorities = new int[az.Length + AZ.Length];
            for (int i = 0; i < 52; i++)
            {
                priorities[i] = i + 1;
                item_priorities.Add( (aZ.ElementAt(i), priorities[i]) );
            }
            return item_priorities;
        }
    }
}

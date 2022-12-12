using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RucksackPriorities
{
    internal class FindMatchingItems
    {
        public static List<char> FindMatchingRucksackItems(IEnumerable<IEnumerable<String>> compartmentalised_rucksack)
        {
            List<char> list_of_matching_chars = new List<char>();
            for(int i = 0; i < compartmentalised_rucksack.Count(); i++) 
            {
                
                for(int j = 0; j < compartmentalised_rucksack.ElementAt(i).ElementAt(0).Length; j++)
                {
                    int list_size = list_of_matching_chars.Count;
                    for (int k = 0; k < compartmentalised_rucksack.ElementAt(i).ElementAt(1).Length; k++)
                    {
                        if (compartmentalised_rucksack.ElementAt(i).ElementAt(0)[j]
                            .Equals(compartmentalised_rucksack.ElementAt(i).ElementAt(1)[k]))
                        {
                            list_of_matching_chars.Add(compartmentalised_rucksack.ElementAt(i).ElementAt(0)[j]);
                            break;
                        }
                        
                    }
                    int new_list_size = list_of_matching_chars.Count;
                    if(new_list_size > list_size)
                    {
                        break;
                    }
                    
                }
            }
            return list_of_matching_chars;
        }
    }
}

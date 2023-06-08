using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class DuplicateCounter
    {
        private readonly int[] array;
        private readonly Dictionary<int, int> countDictionary;

        public DuplicateCounter(int[] array)
        {
            this.array = array;
            countDictionary = new Dictionary<int, int>();
        }

        public int CountDuplicates()
        {
            foreach (int element in array)
            {
                if (countDictionary.ContainsKey(element))
                {
                    countDictionary[element]++;
                }
                else
                {
                    countDictionary[element] = 1;
                }
            }

            int totalDuplicates = 0;
            foreach (var pair in countDictionary)
            {
                if (pair.Value > 1)
                {
                    totalDuplicates += pair.Value - 1;
                }
            }

            return totalDuplicates;
        }
    }
}

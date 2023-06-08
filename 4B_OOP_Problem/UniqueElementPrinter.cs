using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class UniqueElementPrinter
    {
        private int[] ary;

        public UniqueElementPrinter(int[] array)
        {
            this.ary = array;
        }

        public void PrintUniqueElements()
        {
            Dictionary<int, int> countDictionary = new Dictionary<int, int>();

            foreach (int element in ary)
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

            Console.WriteLine("Unique elements in the array:");

            foreach (var pair in countDictionary)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}

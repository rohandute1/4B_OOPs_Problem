using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class ElementFrequencyCounter
    {
        private int[] aray;
        private Dictionary<int, int> frequencyDictionary;

        public ElementFrequencyCounter(int[] array)
        {
            this.aray = array;
            frequencyDictionary = new Dictionary<int, int>();
        }

        public void CountElementFrequency()
        {
            foreach (int element in aray)
            {
                if (frequencyDictionary.ContainsKey(element))
                {
                    frequencyDictionary[element]++;
                }
                else
                {
                    frequencyDictionary[element] = 1;
                }
            }
        }

        public void PrintElementFrequency()
        {
            Console.WriteLine("Element Frequency:");

            foreach (var pair in frequencyDictionary)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }
        }
    }
}

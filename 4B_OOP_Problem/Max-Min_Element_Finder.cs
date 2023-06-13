using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class Max_Min_Element_Finder
    {
        private int[] ar;
        private int maximum;
        private int minimum;

        public Max_Min_Element_Finder(int[] ar)
        {
            this.ar = ar;
            maximum = int.MinValue;
            minimum = int.MaxValue;
        }

        public void FindMinMax()
        {
            foreach (int element in ar)
            {
                if (element > maximum)
                {
                    maximum = element;
                }

                if (element < minimum)
                {
                    minimum = element;
                }
            }
        }

        public int GetMaximum()
        {
            return maximum;
        }

        public int GetMinimum()
        {
            return minimum;
        }
    }
}

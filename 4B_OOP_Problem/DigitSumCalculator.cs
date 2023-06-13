using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class DigitSumCalculator
    {
        private int num;

        public DigitSumCalculator(int number)
        {
            this.num = number;
        }

        public int CalculateDigitSum()
        {
            int sum = 0;
            int n = num;

            while (n != 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }

            return sum;
        }
    }
}

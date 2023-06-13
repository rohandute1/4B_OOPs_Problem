using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class PatternPrinter
    {
        private int rows;

        public PatternPrinter(int rows)
        {
            this.rows = rows;
        }

        public void PrintPattern()
        {
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

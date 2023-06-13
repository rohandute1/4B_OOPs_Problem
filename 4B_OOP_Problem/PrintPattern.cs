using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class PrintPattern
    {
        private int row;
        private int column;

        public PrintPattern(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public void PatternPrint()
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    if (i == 1 || i == row || j == 1 || j == column)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

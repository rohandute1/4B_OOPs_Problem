using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class MatrixRowSumCalculator
    {
        private int[,] matrix;
        private int rows;
        private int columns;

        public MatrixRowSumCalculator(int[,] matrix)
        {
            this.matrix = matrix;
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
        }

        public int[] CalculateRowSums()
        {
            int[] rowSums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;

                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];
                }

                rowSums[i] = sum;
            }

            return rowSums;
        }
    }
}

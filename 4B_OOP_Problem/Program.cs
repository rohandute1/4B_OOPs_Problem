using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_OOP_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOP's Practice problems");

            int[] array = { 1, 2, 3, 4, 4, 5, 6, 7, 7, 7, 8, 9, 9, 9 };

            DuplicateCounter counter = new DuplicateCounter(array);
            int totalDuplicates = counter.CountDuplicates();

            Console.WriteLine("Total number of duplicate elements: " + totalDuplicates);

            Console.ReadLine();
        }
    }
}

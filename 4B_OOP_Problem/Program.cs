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
            Console.WriteLine("Please select any one option from following.");
            Console.WriteLine(" 1.Duplicate Numbers\n 2.Unique Element Printer\n 3.Count Frequency of Elements\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int[] array = { 1, 2, 3, 4, 4, 5, 6, 7, 7, 7, 8, 9, 9, 9 };
                    DuplicateCounter counter = new DuplicateCounter(array);
                    int totalDuplicates = counter.CountDuplicates();
                    Console.WriteLine("Total number of duplicate elements: " + totalDuplicates);
                    break;

                case 2:
                    int[] ary = { 1, 2, 3, 4, 4, 5, 6, 7, 7, 7, 8, 9, 9, 9 };
                    UniqueElementPrinter printer = new UniqueElementPrinter(ary);
                    printer.PrintUniqueElements();
                    break;
                case 3:
                    int[] aray = { 1, 2, 3, 4, 4, 5, 6, 7, 7, 7, 8, 9, 9, 9 };
                    ElementFrequencyCounter count = new ElementFrequencyCounter(aray);
                    count.CountElementFrequency();
                    count.PrintElementFrequency();
                    break;

            }
            Console.ReadLine();
        }
    }
}

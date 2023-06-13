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
            Console.WriteLine(" 1.Duplicate Numbers\n 2.Unique Element Printer\n 3.Count Frequency of Elements\n 4.ArrayMinMaxFinder\n 5.Pattern Printer\n 6.Print Square Pattern\n 7.Word Reverser");
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

                case 4:
                    int[] ar = { 7, 2, 9, 1, 5, 4, 6, 3, 8 };
                    Max_Min_Element_Finder finder = new Max_Min_Element_Finder(ar);
                    finder.FindMinMax();
                    int maximum = finder.GetMaximum();
                    int minimum = finder.GetMinimum();
                    Console.WriteLine("Maximum element: " + maximum);
                    Console.WriteLine("Minimum element: " + minimum);
                    break;

                case 5:
                    int rows = 8;
                    PatternPrinter print = new PatternPrinter(rows);
                    print.PrintPattern();
                    break;

                case 6:
                    int row = 7;
                    int column = 7;
                    PrintPattern pattern = new PrintPattern(row, column);
                    pattern.PatternPrint();
                    break;

                case 7:
                    Console.WriteLine("Enter a string:");
                    string input = Console.ReadLine();
                    StringWordReverser reverser = new StringWordReverser(input);
                    string reversedString = reverser.ReverseWords();
                    Console.WriteLine("Original string: " + input);
                    Console.WriteLine("Reversed string: " + reversedString);
                    break;

            }
            Console.ReadLine();
        }
    }
}

﻿using System;
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
            Console.WriteLine(" 1.Duplicate Numbers\n 2.Unique Element Printer\n 3.Count Frequency of Elements\n 4.ArrayMinMaxFinder\n 5.Pattern Printer\n 6.Print Square Pattern\n 7.Word Reverser\n 8.Calculate digit sum\n 9.Calculate Matrix Row Sum");
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

                case 8:
                    Console.WriteLine("Enter a number:");
                    int num = int.Parse(Console.ReadLine());
                    DigitSumCalculator calculator = new DigitSumCalculator(num);
                    int digitSum = calculator.CalculateDigitSum();
                    Console.WriteLine("Sum of digits: " + digitSum);
                    break;

                case 9:
                    int[,] matrix = {
                                    { 1, 2, 3 },
                                    { 4, 5, 6 },
                                    { 7, 8, 9 }
                              };

                    MatrixRowSumCalculator cal = new MatrixRowSumCalculator(matrix);
                    int[] rowSums = cal.CalculateRowSums();

                    Console.WriteLine("Matrix:");

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Sum of each row:");

                    for (int i = 0; i < rowSums.Length; i++)
                    {
                        Console.WriteLine("Row " + (i + 1) + ": " + rowSums[i]);
                    }
                    break;

            }
            Console.ReadLine();
        }
    }
}

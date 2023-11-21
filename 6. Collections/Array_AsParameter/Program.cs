using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace Array_AsParameter
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] grades = new int[] {25, 3, 12, 15, 6, 5, 2, 18 };

            double result = GetAverage(grades);

            Console.WriteLine($"The average result is {result}.");

        }

        public static double GetAverage(int[] gradesArray)
        {
            double average;
            int sum = 0;

            for (int i = 0; i < gradesArray.Length; i++)
            {
                sum += gradesArray[i];
            }

            average = sum / gradesArray.Length;
            return average;
        }
    }
}
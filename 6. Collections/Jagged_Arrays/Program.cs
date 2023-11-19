using System;

namespace Jagged_Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 5, 10, 15, 20, 25, 30 }
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Element {i}");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
        }
    }
}
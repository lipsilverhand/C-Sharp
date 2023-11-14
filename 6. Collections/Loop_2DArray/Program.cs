using System;

namespace Loop_2DArray
{
    class Program
    {   
        public static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            foreach (int num in matrix)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("--------------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
            }
        }
    }
}
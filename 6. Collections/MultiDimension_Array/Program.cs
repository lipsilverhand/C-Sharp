using System;

namespace MultiDimension_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[,] maxtrix;

            int[,,] ThreeD;


            // 2D array
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {6,7,8},
            };

            Console.WriteLine($"Center value is {array2D[1,1]}"); // [row, index]
        }
    }
}
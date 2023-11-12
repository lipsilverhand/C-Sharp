using System;

namespace challenge_2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Run();
        }

        public static void GetEven(int[] Array)
        {
            foreach (int i in Array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even number: {i}");
                }
            }
        }

        public static void GetOdd(int[] Array)
        {
            foreach (int i in Array)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Odd number: {i}");
                }
            }
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            GetEven(array);
            Console.WriteLine("-----------------------------");
            GetOdd(array);
        }
    }
}
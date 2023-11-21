using System;
using System.Collections.Generic;

namespace challenge_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Even set elements: ");
            foreach (int num in EvenSet(list))
            {
                Console.Write(num);
            }
        }

        public static List<int> EvenSet(List<int> input)
        {
            List<int> set1 = new List<int>();

            foreach (int num in input)
            {
                if (num % 2 == 0)
                {
                    set1.Add(num);
                }
            }

            return set1;
        }
    }
}

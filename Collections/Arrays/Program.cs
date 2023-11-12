using System;

namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            //first way
            int[] FirstWay = new int[5];
            FirstWay[0] = 54;
            FirstWay[1] = 7;
            FirstWay[2] = 45;
            FirstWay[3] = 69;
            FirstWay[4] = 10;

            Console.WriteLine("Enter value of index 0: ");
            string input = Console.ReadLine();
            FirstWay[0] = int.Parse(input);

            Console.WriteLine($"Grades index 0 is {FirstWay[0]}");
            Console.ReadKey();

            // Second way
            int[] SecondWay = {20, 5, 10, 8, 7};

            // Third Way
            int[] ThirdWay = new int[] {20, 5, 10, 8, 7};
            Console.WriteLine(ThirdWay);
        }
    }
}
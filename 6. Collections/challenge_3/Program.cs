using System;

namespace challenge_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[][] FriendArrays = new string[][]
            {
                new string[] {"Kevin","Stacy"},
                new string[] {"Bob","Tom","Kathy"},
                new string[] {"John","Alan","Tim","Will","Stephanie"}
            };

            for (int i = 0; i < FriendArrays.Length; i++)
            {
                Console.WriteLine($"Family {i + 1}, introducing: ");
                for (int j = 0; j < FriendArrays[i].Length; j++)
                {
                    Console.WriteLine(FriendArrays[i][j]);
                }
            }
        }
    }
}
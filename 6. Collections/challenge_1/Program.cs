using System;

namespace challenge_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] friends = new string[] {"A","B","C","D","E"};

            foreach (string friend in friends)
            {
                Console.WriteLine($"Greeting {friend}");
            }
        }
    }
}
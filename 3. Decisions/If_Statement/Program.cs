using System;

namespace If_Statement {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter the number of time");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day > 4 && day <= 11) {
                Console.WriteLine("Good morning!");
            } else if (day > 11 && day <= 16) {
                Console.WriteLine("Good afternoon!");
            } else if (day > 16 && day <= 22) {
                Console.WriteLine("Good evening");
            } else {
                Console.WriteLine("Good Night!");
            }
        }
    }
}
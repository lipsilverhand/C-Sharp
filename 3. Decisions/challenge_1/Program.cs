using System;

namespace challenge_1 {
    class Program {
        public static void Main(string[] args) {
            Check(27);
        }

        public static void Check(int number) {
            if (number % 2 == 0) {
                Console.WriteLine("Even number");
            } else {
                Console.WriteLine("Odd number");
            }
        }
    }
}
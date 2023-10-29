using System;

namespace challenge_2 {
    class Program {
        public static void Main(string[] args) {
            NestedCheck(3);
        }
        public static void NestedCheck( int number ) {
            if (number % 3 == 0) {
                Console.WriteLine("Divisible by 3.");
            } else if (number % 7 == 0) {
                Console.WriteLine("Divisible by 7.");
            } else {
                if (number % 2 == 0) {
                    Console.WriteLine("Even number.");
                } else {
                    Console.WriteLine("Odd number.");
                }
            }
        }
    }
}
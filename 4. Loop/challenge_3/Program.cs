using System;

namespace challenge_3 {
    class Program {
        public static void Main(string[] args) {
            string input = "0";
            int entry = 0;
            int currentNumber = 0;
            int total = 0;

            while (input != "-1") {
                Console.WriteLine($"Entry no.{entry}");
                Console.WriteLine($"Current number: {currentNumber}");

                Console.WriteLine("Please enter -1 to calculate average.");

                input = Console.ReadLine();
 
                if (input.Equals("-1")) {
                    Console.WriteLine("-----------------Average Calculator-------------------");
                    double average =  (double)total / (double)entry;
                    Console.WriteLine($"Average now is: {average}");
                }

                if (int.TryParse(input, out currentNumber) & currentNumber > 0 & currentNumber < 21) {
                    total += currentNumber;
                } else {
                    if (!(input.Equals("-1"))) {
                        Console.WriteLine("Please enter value between 1 and 20.");
                        continue;
                    }

                }
                entry++;
            }
        }
    }
}
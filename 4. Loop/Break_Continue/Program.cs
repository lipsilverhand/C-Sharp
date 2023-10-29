using System;

namespace Break_Continue {
    class Program {
        public static void Main(string[] args) {
            for(int x = 0 ; x < 10 ; x++) {
                if (x % 2 == 0) {
                    Console.WriteLine("Next is odd number:");
                    continue;
                }
                Console.WriteLine(x);
            }
        }
    }
}
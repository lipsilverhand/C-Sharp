using System;

namespace challenge_2 {
    class Program {
        public static void Main(string[] args) {
            int i = 0;

            while (true) {
                if (i % 3 == 0) {
                    i++;
                    continue;
                }

                if (i == 10) {
                    break;
                }

                if (i == 11) {
                    break;
                }
                Console.WriteLine(i++);
            }
            
        }
    }
}
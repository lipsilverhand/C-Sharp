using System;

namespace challenge_1 {
    class Program {
        public static void Main(string[] args) {
            Run();
        }

        public static void ForLoop() {
            int i;
            for(i = -3 ; i < -4 ; i++) {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop() {
            int i = 3;

            while (i > -4) {
                Console.WriteLine(i--);
            }
        }

        public static void Run() {
            ForLoop();
            WhileLoop();
        }
    }
}
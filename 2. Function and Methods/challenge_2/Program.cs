using System;

namespace challenge_2 {
    class Program {
        public static void Main(string[] args) {
            Run();
        }

        public static string LowUpper(string s) {
            return s.ToLower() + s.ToUpper();
        }

        public static void Count(string s) {
            Console.WriteLine($"The amount of characters is {s.Length}!");
        }
        public static void Run() {
            string s = "HeY THeRe FRIend!";

            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }
    }
}
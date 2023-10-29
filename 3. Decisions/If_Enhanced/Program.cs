using System;

namespace If_Enhanced {
    class Program {
        public static void Main(string[] args) {
            int temperature = -6;
            string StateOfMatter;

            StateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine($"State of matter now is {StateOfMatter}.");
        }
    }
}
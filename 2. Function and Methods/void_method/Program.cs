using System;

namespace void_method {
    class Program {
        public static void Main(string[] args) {
            Write();
            Hey("I can fly.");
        }

        public static void Write() {
            Console.WriteLine("I am super cat.");
        }

        public static void Hey(string x) {
            Console.WriteLine(x);
        }   
    }
}
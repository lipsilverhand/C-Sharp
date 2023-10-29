using System;

namespace return_method {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine(Add(15,31));
            Console.WriteLine(Minus(10,4));
            Console.WriteLine(Multiply(8,2));
            Console.WriteLine(Divine(60,2));
        }

        public static int Add(int num1, int num2) {
            return num1 + num2;
        }

        public static int Minus(int num1, int num2) {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2) {
            return num1 * num2;
        }

         public static int Divine(int num1, int num2) {
            return num1 / num2;
        }
    }
}
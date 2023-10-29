using System;

namespace user_input {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine($"Total is: {Cal()}");
        }

        public static int Cal() {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            return result;
        }
    }
}
using System;

namespace user_input {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter your name: ");
            string input_name = Console.ReadLine();
            Console.WriteLine($"Welcome {input_name}!");

            Console.WriteLine("Enter your age: ");
            int input_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"My age is {input_age}");


            Console.WriteLine("Enter a string: ");
            int ascii_value = Console.Read();
            Console.WriteLine($"...and your ascii is {ascii_value}");


            
        }
    }
}
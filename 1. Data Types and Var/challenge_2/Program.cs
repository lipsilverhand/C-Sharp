using System;

namespace challenge_2 {
    class Program {
        public static void Main(string[] args) {
            // Input a string
            Console.WriteLine("Enter a string: ");
            string s1 = Console.ReadLine();

            // Input a character
            Console.WriteLine("Enter the character to search: ");
            string cha = Console.ReadLine();

            // Search index of that chracter in the input string
            Console.WriteLine(s1.IndexOf(cha));

            // Input first name
            Console.WriteLine("Enter you first name: ");
            string first = Console.ReadLine(); 

            // Input last name
            Console.WriteLine("Enter you last name: ");
            string last = Console.ReadLine(); 
            
            // Print full name
            Console.WriteLine("My full name is {0} {1}", first,last);
        }
    }
}
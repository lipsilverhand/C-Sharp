using System;

namespace switch_statement {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter you number: ");
            string input = Console.ReadLine();
            int x = int.Parse(input);

            switch (x) {
                case 1:
                    Console.WriteLine("Sunday: Go to church.");
                    break;
                case 2:
                    Console.WriteLine("Monday: Learn C#.");
                    break;
                case 3:
                    Console.WriteLine("Tuesday: Go to CML class.");
                    break;
                case 4:
                    Console.WriteLine("Wednesday: Hangout in Seattle");
                    break;
                case 5:
                    Console.WriteLine("Thursday: Go to school.");
                    break;
                case 6:
                    Console.WriteLine("Friday: Help family in Tacoma.");
                    break;
                case 7:
                    Console.WriteLine("Saturday: Hangout in Bellevue");
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    break;
            }
        }
    }
}
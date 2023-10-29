using System;

namespace Nested_If {
    class Program {
        public static void Main(string[] args) {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";

            Console.WriteLine("Enter your username: ");
            userName = Console.ReadLine();

            if (isRegistered) {
                if (userName != "") {
                    Console.WriteLine($"Hi there, {userName}");
                    if (userName.Equals("admin")) {
                        Console.WriteLine("Hi there, admin");
                    }
                }
            }
        }
    }
}
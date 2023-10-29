using System;

namespace challenge_3 {
    class Program {
        public static void Main (string[] args) {
            string username = "lipsilverhand";
            string password = "Kieu123";

            bool registed = true;

            if (registed) {
                Console.WriteLine("Enter your username: ");
                string input_username = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                string input_password = Console.ReadLine();

                if (input_username == username && input_password == password) {
                    Console.WriteLine($"Welcome back {username}, you've logged in!");
                } else if (input_username.Equals("admin") && input_password.Equals("password")) {
                    Console.WriteLine("You have logged in as admin.");
                } else {
                    Console.WriteLine("Sorry, user invalid, Please try again!");
                }
                
            }  
        }
    }
}
using System;

namespace challenge_1 {
    class Program {
        public static void Main(string[] args) {
            string friend1 = "Lip";
            string friend2 = "Phuoc";
            string friend3 = "Philip";
            GreetFriend(friend1, friend2, friend3);
        }

        public static void GreetFriend(string fname1, string fname2, string fname3) {
            Console.WriteLine($"Hi {fname1}, my friend!");
            Console.WriteLine($"Hi {fname2}, my friend!");
            Console.WriteLine($"Hi {fname3}, my friend!");
            
        }
    }
}
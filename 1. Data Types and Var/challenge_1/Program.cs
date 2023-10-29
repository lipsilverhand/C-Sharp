using System;

namespace challenge_1 {
    class Program {
        public static void Main(string[] args) {
           string file;
           Console.WriteLine("Please enter your string and press enter: ");
           file = Console.ReadLine(); // dotnet.us

           Console.WriteLine(file.ToUpper());
           Console.WriteLine(file.ToLower());
           Console.WriteLine(file.Trim());
           Console.WriteLine(file.Substring(0, 6));
            
        }
    }
}
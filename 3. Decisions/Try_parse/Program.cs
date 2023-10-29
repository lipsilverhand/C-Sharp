using System;

namespace Try_parse {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter temperature: ");
            string a = Console.ReadLine();
            int i;

            bool success = int.TryParse(a, out i);

            if (success) {
                Console.WriteLine("Value parsed successfully in i");
            } else {
                Console.WriteLine("Fail!");
            }

        }
    }
}
using System;

namespace While_Loop {
    class Program {
        public static void Main(string[] args) {
            int i = 0;
            string x = "";

            while (x.Equals("")) {
                Console.WriteLine("Please press enter to increase amount by one");
                x = Console.ReadLine();

                i++;
                Console.WriteLine($"Current people count is {i}");
            }

            Console.WriteLine("{i} people are inside the bus. Press enter to close the program");
        }
    }
}
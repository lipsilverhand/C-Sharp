using System;

namespace challenge_5 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Input temperature: ");
            string value = Console.ReadLine();

            string message = string.Empty;
            int temperature = 0;

            bool valid = int.TryParse(value, out temperature);

            if (valid) {
                message = 
                temperature <= 15 ? "It's too cold here." :
                temperature >= 16 && temperature <=28 ? "It is ok." :
                temperature > 28 ? "It's not cold here.": "";
                Console.WriteLine(message);
            } else {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
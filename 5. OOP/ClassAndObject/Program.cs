using System;

namespace ClassAndObject
{
    class Program
    {
        public static void Main(string[] args) {
            Car audi = new Car();

            audi.Drive();

            Console.WriteLine("Press enter to stop the car.");
            string input = Console.ReadLine();

            if (input == "")
            {
                audi.Stop();
            } else
            {
                Console.WriteLine("Car still drive indefenely");
            }
        }
    }
}
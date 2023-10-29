using System;

namespace ClassAndObject
{
    class Program
    {
        public static void Main(string[] args) {
            Car audi = new Car("Audi R8", 550, "black");
            audi.Details();
            audi.Drive();

            Car bmw = new Car("BMW M5", 340, "white");
            bmw.Details();

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
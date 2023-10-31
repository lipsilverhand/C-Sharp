using System;

namespace ClassAndObject
{
    class Program
    {
        public static void Main(string[] args) {
            Car template = new Car();
            template.SetName("");
            Console.WriteLine($"{template.GetName()} has been created and has {template.GetHp()} hp");

            Car audi = new Car("Audi R8", 550, "black");
            audi.Details();
            audi.Drive();

            Car bmw = new Car("BMW M5", 340, "red");
            bmw.Details();

            Console.WriteLine("Press enter to stop the car.");
            string input = Console.ReadLine();

            if (input == "")
            {
                audi.Stop();
            } else
            {
                Console.WriteLine("Car still drive indefinitely");
            }
        }
    }
}
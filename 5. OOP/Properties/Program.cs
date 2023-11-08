using System;

namespace Properties
{
    class Program
    {
        public static void Main(string[] args)
        {
            House single = new House();
            single.Name = "Test";
            single.Build();

            single.Price = 400000;
            Console.WriteLine($"The price is ${single.Price}.");
            Console.ReadKey();
        }
    }
}
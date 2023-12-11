using System;

namespace Virtual_Override
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cat Leo = new Cat("Leo", 2);
            Console.WriteLine($"Hi, it's {Leo.Name}, {Leo.Age} years old.");
            Leo.Eat();
            Leo.MakeSound();
            Leo.Play();
        }
    }
}
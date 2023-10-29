using System;

namespace Data_types {
    class Program {
        public static void Main(String[] args) {
            string name = "Phuoc Huynh";
            double height = 6.2;
            float pi = 3.1415f;
            bool x = true;
            char symbol = '$';

            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"My height is {height} ft.");
            Console.WriteLine($"Pi = {pi}.");
            Console.WriteLine($"I am {x}.");
            Console.WriteLine($"Money has {symbol} symbol.");
        }
    }
}


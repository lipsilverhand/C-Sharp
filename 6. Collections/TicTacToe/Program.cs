using System;

namespace TicTocToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Table();
        }


        public static void Table()
        {
            Console.WriteLine($"| {1} | | {2} | | {3} | ");
            Console.WriteLine("-----------------");
            Console.WriteLine($"| {4} | | {5} | | {6} | ");
            Console.WriteLine("-----------------");
            Console.WriteLine($"| {7} | | {8} | | {9} | ");

        }
    }
}
using Challenge_2;
using System;

namespace challenge_2
{
    class Program
    {
        public static void Main(string[] args) {
            Book novel = new Book();
            novel.Title = "";
            Console.WriteLine(novel.Title);

            novel.Pages = -2;
            Console.WriteLine(novel.Pages);

            Console.ReadKey();

        }
    }
}
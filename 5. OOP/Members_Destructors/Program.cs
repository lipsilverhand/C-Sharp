using System;
using System.Linq.Expressions;

namespace Members_Destructors
{
    class Program
    {
        public static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(false);
            

            Console.ReadKey();
        }
    }
}
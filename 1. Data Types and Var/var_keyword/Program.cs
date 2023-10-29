using System;

namespace var_keyword {
    class Program {
        public static void Main(string[] args) {
            var name = "lip";
            Console.WriteLine(name);

            var num1 = 10;
            var num2 = 90;
            var num3 = num1 + num2;
            Console.WriteLine(num3);

            var x = 5;
            x = 9;
            Console.WriteLine(x);
        }
    }
}
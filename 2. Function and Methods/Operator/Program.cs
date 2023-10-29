using System;

namespace Operator {
    class Program {
        public static void Main(string[] args) {
            int num1 = 1;
            int num2 = 5;
            int num;
            int result;

            // unary operator
            num = -num1;
            Console.WriteLine($"num is {num}");

            //boolean
            bool isSunny = true;
            Console.WriteLine($"Is it sunny now? {!isSunny}");

            //increment operator
            int i = 0;
            i++;
            Console.WriteLine($"num is {i}");
            Console.WriteLine($"num is {++i}");
            Console.WriteLine($"num is {++i}");
            Console.WriteLine($"num is {++i}");

            //decrement operator
            i = 5;
            i--;
            Console.WriteLine($"num is {i}");
            Console.WriteLine($"num is {--i}");
            Console.WriteLine($"num is {--i}");
            Console.WriteLine($"num is {--i}");

            result = num1 + num2;
            Console.WriteLine($"Result is {result}");

            result = num1 - num2;
            Console.WriteLine($"Result is {result}");

            result = num1 * num2;
            Console.WriteLine($"Result is {result}");

            result = num1 / num2;
            Console.WriteLine($"Result is {result}");

            //relational
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine($"Result is {isLower}");
        }
    }
}
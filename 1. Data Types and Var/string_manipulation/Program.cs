using System;

namespace string_manipulation {
    class Program {
        public static void Main(string[] args) {
            string name = "Phuoc Huynh";
            int age = 24;
            string job = "software engineer";

            // 1. String concatenation
            Console.WriteLine("My name is " + name  + ", I am " + age + " years old, my job is " + job + ".");

            // 2. String index
            Console.WriteLine("My name is {0}, I am {1} years old, my job is {2}.", name, age, job);

            // 3. String interpolation
            Console.WriteLine($"My name is {name}, I am {age} years old, my job is {job}.");

            //4. String Verbatim 
            Console.WriteLine(@"fwehiwfeiweknkwef.
            kewdidnwieni,
            owednowen.whuedbiw");
        }
    }
}
using System;

namespace conversion {
    class Program {
        public static void Main(string[] args) {

            // explicit conversion 
            double x = 3.5;
            int y;
            y = (int)x;
            Console.WriteLine(y);

            //implicit conversion
            float float_n = 5.15f;
            double double_n = float_n;
            Console.WriteLine(double_n);

            // typeConversion
            string myString = y.ToString();
            Console.WriteLine(myString); //"3"
        }
    }
}
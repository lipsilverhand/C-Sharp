using System;

namespace conversion2 {
    class Program {
        public static void Main(string[] args) {
        string first = "14";
        string second = "6";

        int x = Int32.Parse(first);
        int y = Int32.Parse(second);

        int result = x + y;
        Console.WriteLine(result);
    }
    }
}
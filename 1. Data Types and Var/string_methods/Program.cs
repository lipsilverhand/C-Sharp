using System;

namespace string_methods {
    class Program {
        public static void Main(string[] args ) {
            string f_name = "Phuoc";
            string l_name = "Huynh";
            string full_name = string.Concat("", f_name, l_name, "");

            Console.WriteLine(f_name.Substring(3));
            Console.WriteLine(f_name.ToLower());
            Console.WriteLine(f_name.ToUpper());
            Console.WriteLine(f_name.IndexOf('u'));
        }
    }
}
using System;

namespace Do_While_Loop {
    class Program {
        public static void Main(string[] args) {
           int LengthOfText = 0;
           string WholeText = "";


           do {
            Console.WriteLine("Input the name: ");
            string name = Console.ReadLine();
            int CurrentLength = name.Length;
            LengthOfText += CurrentLength;
            WholeText += name;

           } while (LengthOfText < 20);
           Console.WriteLine(WholeText);
        }
    }
}
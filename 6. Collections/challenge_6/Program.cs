using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace challenge_6
{
    class Program
    {   
        public static void Main(string[] args)
        {
            Count[] setList = {
            new Count(1,"one"),
            new Count(2,"two"),
            new Count(3,"three"),
            new Count(4,"four"),
            new Count(5, "five")
        };

            Dictionary<int, Count> numberDict = new Dictionary<int, Count>();
            foreach (Count x in setList)
            {
                numberDict.Add(x.NUMBER, x);
            }

            int[] key = {1,2,3,4,5};

            foreach (int i in key) 
            {
                if (numberDict.ContainsKey(i))
                {
                    Console.WriteLine($"Return {numberDict[i].NUMBER}, \"{numberDict[i].WORD}\"");
                } else
                {
                    Console.WriteLine("Nope...");
                }
            }
        }
        

    }
}
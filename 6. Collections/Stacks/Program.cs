using System;
using System.Collections;

namespace Stacks
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Console.WriteLine($"The current stack is: {stack.Peek()}");
            stack.Push(2);
            Console.WriteLine($"The current stack is: {stack.Peek()}");
            stack.Push(3);
            Console.WriteLine($"The current stack is: {stack.Peek()}");
            stack.Push(4);
            Console.WriteLine($"The current stack is: {stack.Peek()}");


            //Revmove and and count
            while(stack.Count > 0) 
            {
                Console.WriteLine($"Top stack {stack.Pop()} was removed");
                Console.WriteLine($"Current stack is {stack.Count}");
            }


            int[] numbers = new int[] {5,1,3,4,8,6,7};
            Stack<int> myStack = new Stack<int>();
            Console.WriteLine("The number in the array are: ");
            foreach(int number in numbers) 
            {
                Console.WriteLine(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("Number in reverse: ");
            while(myStack.Count > 0)
            {
                int number = myStack.Pop();
                Console.WriteLine(number + "");
            }
        }
    }
}
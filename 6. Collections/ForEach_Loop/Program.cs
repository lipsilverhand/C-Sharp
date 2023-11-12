using System;

namespace ForEach_Loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }
            
            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine($"Index {j} = { nums[j]}");
            }

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine($"Index {counter} = {k}"); 
                counter++;
            }
        }
    }
}
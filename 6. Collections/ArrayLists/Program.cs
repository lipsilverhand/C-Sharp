using System;
using System.Collections;

namespace ArrayListC
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("Bello");
            myArrayList.Add(2.4);
            double sum = 0;

            foreach (object i in myArrayList)
            {
                if(i is int)
                {
                    sum += Convert.ToDouble(i);
                } else if (i is double) {
                    sum += (double)i;
                } else if (i is string)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine(sum);
            }
        }
    }
}
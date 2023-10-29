using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Car
    {
        public Car() {
            Console.WriteLine("Car was created!");
        }

        public void Drive()
        {
            Console.WriteLine("Car starts driving.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stops driving.");
        }
    }
}

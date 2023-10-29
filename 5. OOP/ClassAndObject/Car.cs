using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;
        public Car(string name, int hp, string color) {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine($"{name} was created!");
        }

        public void Drive()
        {
            Console.WriteLine($"{_name} starts driving.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stops driving.");
        }

        public void Details()
        {
            Console.WriteLine($"The car named {_name}, has {_color} color and {_hp} hp.");
        }
    }
}

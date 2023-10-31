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

        public int GetHp()
        {
            return _hp * _hp;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (name == "")
            {
                _name = "Defaut Name";
            } else
            {
                _name = name;
            }

        }

        //Default Constructor
        public Car()
        {
            _name = "name";
            _hp = 4;
            _color = "color";
        }

        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = "red";

        }

        // Constructor
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

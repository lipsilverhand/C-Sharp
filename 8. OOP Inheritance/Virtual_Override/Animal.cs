using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age, bool ishungry) 
        {
            this.Name = name;
            this.Age = age;
            this.IsHungry = ishungry;
        }

        public virtual void MakeSound ()
        {

        }

        public virtual void Eat()
        {
            if (IsHungry)
            {

            }

            else
            {

            }
        }
    }
}

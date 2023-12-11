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

        public Animal(string name, int age) 
        {
            this.Name = name;
            this.Age = age;

            IsHungry = true;
        }

        public virtual void MakeSound ()
        {

        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
            }

            else
            {
                Console.WriteLine($"{Name} is already full, need more time!");
            }
        }

        public virtual void Play ()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }
}

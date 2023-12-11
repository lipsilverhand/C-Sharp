using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override
{
    internal class Cat:Animal
    {

        public bool IsHappy { get; set; }
        public Cat(string name, int age):base(name, age)
        {
            IsHappy = false;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meooooow");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            } else
            {
                Console.WriteLine($"{Name} is not interested in playing now.");
            }
        }

    }
}

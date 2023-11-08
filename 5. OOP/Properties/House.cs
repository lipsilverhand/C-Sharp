using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class House
    {   
        private string _name;
        private int _price;

        //Constructor
        public House() {
            _name = "A";
            _price = 0;
        }

        public int Price { 
            get { return _price; } 
            set { _price = value; }
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public void Build()
        {
            Console.WriteLine($"{_name} has been deployed.");
        }


    }
}

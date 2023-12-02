using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Employee
    {
        public string ROLE { get; set; }
        public string NAME { get; set; }
        public int AGE { get; set; }
        public float RATE { get; set; }

        public float SALARY
        {
            get
            {
                return RATE * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate) 
        {
            this.ROLE = role;
            this.NAME = name;
            this.AGE = age;
            this.RATE = rate;
        }
    }
}

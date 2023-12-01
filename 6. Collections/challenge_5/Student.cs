using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_5
{
    internal class Student
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int AGE { get; set; }

        //Constructor
        public Student(int id, string name, int age)
        {
            this.ID = id;
            this.NAME = name;
            this.AGE = age;
        }
    }
}

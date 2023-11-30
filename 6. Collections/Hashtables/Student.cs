using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    internal class Student
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            this.ID = id;
            this.NAME = name;
            this.GPA = gpa;
        }
    }
}

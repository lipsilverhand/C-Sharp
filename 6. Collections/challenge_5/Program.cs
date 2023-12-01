using System;
using System.Collections;

namespace challenge_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            Student[] studentList = new Student[6];

            studentList[0] = new Student(1, "Lip", 24);
            studentList[1] = new Student(2, "Pisua", 18);
            studentList[2] = new Student(3, "Alpha", 30);
            studentList[3] = new Student(4, "Beta", 12);
            studentList[4] = new Student(1, "Lip", 24);
            studentList[5] = new Student(6, "Pisua", 24);


            foreach (Student s in studentList) 
            {
                if (!table.Contains(s.ID))
                {
                    table.Add(s.ID, s);
                    Console.WriteLine($"Student with ID {s.ID} was added!");
                } else
                {
                    Console.WriteLine($"Sorry, a student with a same ID already existed {s.ID}.");
                }

            }

        }
    }
}
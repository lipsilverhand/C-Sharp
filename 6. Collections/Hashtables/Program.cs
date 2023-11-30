using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            Student user1 = new Student(1, "Lip", 9);
            Student user2 = new Student(2, "Pisua", 10);
            Student user3 = new Student(3, "Alpha", 7);
            Student user4 = new Student(4, "Beta", 8);

            table.Add(user1.ID, user1);
            table.Add(user2.ID, user2); 
            table.Add(user3.ID, user3);
            table.Add(user4.ID, user4);

            Student storeduser1 = (Student)table[user1.ID];

            //Way 1
            foreach(DictionaryEntry entry in table)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID:{temp.ID}");
                Console.WriteLine($"Student Name:{temp.NAME}");
                Console.WriteLine($"Student GPA:{temp.GPA}");
            }

            //Way 2
            foreach(Student value in table.Values)
            {
                Console.WriteLine($"Student ID:{value.ID}");
                Console.WriteLine($"Student Name:{value.NAME}");
                Console.WriteLine($"Student GPA:{value.GPA}");
            }
        }
    }
}
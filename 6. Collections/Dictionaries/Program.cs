using System;
using System.Collections;

namespace Dictionaries
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("President", "Pisua", 25, 200),
                new Employee("CEO", "Lip", 24, 150),
                new Employee("Manager", "Alpha", 30, 100),
                new Employee("HR", "Beta", 32, 65),
                new Employee("Secretary", "Citha", 28, 50),
                new Employee("Intern", "Dendi", 20, 25),
            };

            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach (Employee e in employees) 
            {
                employeeDictionary.Add(e.ROLE, e);
            }

            //Update key in disctionary
            string KeyToUpdate = "HR";
            if (employeeDictionary.ContainsKey(KeyToUpdate)) {
                employeeDictionary[KeyToUpdate] = new Employee("HR","Effa",22,60);
                Console.WriteLine($"{KeyToUpdate} key updated!");
            } else
            {
                Console.WriteLine("Key to update not found!");
            }

            //way1
            Console.WriteLine("Way 1");
            Employee x = employeeDictionary["CEO"];
            Console.WriteLine($"Employee name {x.NAME}, role {x.ROLE}, age {x.AGE}, has annual salary: ${x.SALARY}");

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Way 2");

            //way2
            Employee result = null;
            if (employeeDictionary.TryGetValue("President", out result))
            {
                Console.WriteLine("Value retrieved!");
                Console.WriteLine($"Employee name: {result.NAME}");
                Console.WriteLine($"Employee role: {result.ROLE}");
                Console.WriteLine($"Employee age: {result.AGE}");
                Console.WriteLine($"Employee salary: ${result.SALARY}");

            } else
            {
                Console.WriteLine("Failed to retrieve data.");
            }

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members_Destructors
{
    internal class Members
    {
        private string _memberName;
        private string _jobTitle;
        private int _salary = 20000;

        public int age;
        public Members() {
            age = 24;
            _memberName = "Lip";
            _salary = 80000;
            _jobTitle = "Developer";
            Console.WriteLine("Object created!");
        }

        public string jobTitle {  
            get { return _jobTitle; } 
            set { _jobTitle = value; } 
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            } else
            {
                Console.WriteLine($"My name is {_memberName}, my job title is {_jobTitle}, and my age is {age}");
            }
        }

        private void SharingPrivateInfo ()
        {
            Console.WriteLine($"My salary is {_salary}");
        }
    }
}

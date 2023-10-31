using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1 {
    internal class phone
    {
        private string _company;
        private string _operatingSystem;
        private string _releaseDate; 
        public phone(string company, string operatingSystem, string releaseDate) {
            _company = company;
            _operatingSystem = operatingSystem;
            _releaseDate = releaseDate;
        }

        public void introduce()
        {
            Console.WriteLine($"It is a product from {_company}, {_operatingSystem}, release on {_releaseDate}");
        }
        
    }
}

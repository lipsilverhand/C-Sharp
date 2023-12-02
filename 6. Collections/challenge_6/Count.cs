using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_6
{
    internal class Count
    {
        public int NUMBER {  get; set; }
        public string WORD { get; set; }


        // Constructor
        public Count(int number, string word) 
        {
            this.NUMBER = number;
            this.WORD = word;
        }
    }
}

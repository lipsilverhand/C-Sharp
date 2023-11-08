using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Book
    {
        private string _title;
        private int _pages;

        public Book() {

        }

        public string Title { 
            get { return _title; }
            set
            {
                if (value.Equals(""))
                {
                    _title = "Unknown";
                }
                else
                {
                    _title = value;
                }
            }
        }

        public int Pages {
            get { return _pages; }
            set { 
                if (value < 1)
                {
                    _pages = 1;
                } else
                {
                    _pages = value;
                }
            }
        }
    }
}

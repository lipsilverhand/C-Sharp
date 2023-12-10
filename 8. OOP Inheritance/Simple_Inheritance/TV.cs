using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance
{
    internal class TV : ElectricalDevices
    {

        //constructor
        public TV(bool ison, string brand) : base(ison, brand)
        {

        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching the TV.");
            }
            else
            {
                Console.WriteLine("TV is off, you need to turn on first.");
            }
        }
    }
}
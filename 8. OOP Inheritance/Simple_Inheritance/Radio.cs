using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance
{
    internal class Radio : ElectricalDevices
    {

        public Radio(bool ison, string brand) : base(ison, brand)
        {

        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio.");
            }
            else
            {
                Console.WriteLine("Radio is off, you need to turn on first!");
            }
        }
    }
}
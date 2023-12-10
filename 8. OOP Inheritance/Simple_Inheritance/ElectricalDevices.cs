using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance
{
    internal class ElectricalDevices
    {
        public bool IsOn { get; set; }
        public string BRAND { get; set; }

        //constructor
        public ElectricalDevices(bool ison, string brand)
        {
            this.IsOn = ison;
            this.BRAND = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
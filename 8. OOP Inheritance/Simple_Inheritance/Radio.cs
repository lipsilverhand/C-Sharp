using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance
{
    internal class Radio
    {
        public bool IsOn {  get; set; }
        public string BRAND { get; set; }
        public Radio(bool ison, string brand) 
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
            IsOn &= false;
        }

        public void ListenRadio() 
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio");
            } else
            {
                Console.WriteLine("Radio is off!");
            }
        }
    }
}

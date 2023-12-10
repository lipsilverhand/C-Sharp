using System;

namespace Simple_Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            TV myTV = new TV(false, "Sony");
            myTV.SwitchOn();
            myTV.WatchTV();

            Radio myRadio = new Radio(false, "Toshiba");
            myRadio.SwitchOn();
            myRadio.ListenRadio();
        }
    }
}
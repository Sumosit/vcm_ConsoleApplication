using System;
using System.Collections.Generic;
using System.Text;

namespace vcm
{
    class Account
    {
        public string name { get; set; }
        public int pin { get; set; }
        public double money { get; set; }

        public Account (string name, int pin, double money)
        {
            this.name = name;
            this.pin = pin;
            this.money = money;
        }
    }
}

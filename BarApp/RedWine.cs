using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace BarApp
{
    class RedWine : Wine
    {
        //we inherit the type of red or white and the quantity from the parent class wine
        //and we get the variety from from the array, in the drink type combo box

        string varietyOfRedWine;

        public RedWine(string t, double q, string v) : base(t, q)
        {
            this.varietyOfRedWine = v;
        }

        //override to string method
        public override string ToString()
        {
            return base.quantity + " x " + base.typeRedOrWhite + " " + this.varietyOfRedWine + " @ €" + base.priceGlass.ToString("0.00");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace BarApp
{
    class Lager : Pint
    {
        string varietyOfLager;

        //we inherit the quantity from the Pint class, and the percentage and variety are specific to the order
        public Lager(int q, string t) : base(q)
        {
            this.varietyOfLager = t;
        }

        //an override ToString method to display the order in the order listbox
        public override string ToString()
        {
            return base.quantity + " x " + this.varietyOfLager + " @ €" + base.price;
        }
    }
}

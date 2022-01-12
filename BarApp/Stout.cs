using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace BarApp
{
    class Stout : Pint
    {
        string varietyOfStout;

        //quantity is inherited from the pint class, alcohol percentage and variety are specific to the Stout
        public Stout(int q, string t) : base(q)
        {
            this.varietyOfStout = t;
        }

        //an override ToString method to display the order in the order listbox
        public override string ToString()
        {
            return base.quantity + " x " + this.varietyOfStout + " @ €" + base.price;
        }
    }
}

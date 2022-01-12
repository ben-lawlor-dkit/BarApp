using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace BarApp
{
    class Wine
    {
        //red or white & quantity will apply to a specific order of wine
        //price applies to all wine
        public string typeRedOrWhite;
        public double quantity;
        public double priceGlass = 7.5;        

        public Wine(string t, double q)
        {
            this.typeRedOrWhite = t;
            this.quantity = q;
        }

        public override string ToString()
        {
            return quantity + " x " + "House " + typeRedOrWhite + " @ €" + priceGlass.ToString("0.00");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace BarApp
{
    class WhiteWine : Wine
    {
        string varietyOfWhiteWine;

        public WhiteWine(string t, double q, string v) : base(t, q)
        {
            this.varietyOfWhiteWine = v;
        }
        public override string ToString()
        {
            return base.quantity + " x " + base.typeRedOrWhite + " " + this.varietyOfWhiteWine + " @ €" + base.priceGlass.ToString("0.00");
        }
    }
}

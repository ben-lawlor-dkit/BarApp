using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace BarApp
{
    class Pint
    {
        //the quantity is varied, the price of a pint is fixed
        public int quantity;
        public double price = 5;

        public Pint(int q)
        {
            this.quantity = q;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarApp
{
    public partial class Cashback : Form
    {
        const string tryAgain = "Insufficient Funds. Try Again?";
        const string insufficientFunds = "Insufficient Funds";

        double cashback;

        public Cashback()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //we check to see if the user types in a double
            Double.TryParse(cashbackTextBox.Text, out cashback);

            if (cashbackTextBox.Text == "")
            {
                CashbackReceived.cashback = 0;
                this.Close();
            }

            //if the yser does not have sufficient funds in the bank they can try again or cancel the cashback
            else if (cashback > BarApp.myCard - BarApp.priceOfRound)
            {
                var result = MessageBox.Show(tryAgain, insufficientFunds, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }

            //if they successfully withdraw cashback
            else
            {
                CashbackReceived.cashback = cashback;
                BarApp.myCard -= CashbackReceived.cashback;
                BarApp.myCash += CashbackReceived.cashback;
                this.Close();
            }            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            CashbackReceived.cashback = 0;
            this.Close();
        }
    }
}

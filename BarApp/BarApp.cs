/*Ben Lawlor 2020
DkIT Higher Diploma in Science in Computing*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BarApp
{

    public partial class BarApp : Form
    {
        string[] drinkType = { "Wine", "Pint", "Cocktail" };
        string[] redWineType = { "Cabarnet Sauvignon", "Shiraz", "Merlot", "Malbec", "House Red" };
        string[] whiteWineType = { "Sauvignon Blanc", "Pinot Grigio", "Chardonnay", "Riesling", "House White" };
        string[] lagerType = { "Heineken", "Coors", "Carlsberg", "Erdinger", "Fischers" };
        string[] stoutType = { "Guinness", "Murphy's", "Beamish" };
        string[] cocktailType = { "Espresso Martini", "Old Fashioned", "Margarita", "Mojito", "Whiskey Sour", "Dark 'N' Stormy" };

        protected List<double> prices = new List<double>();

        const string bartenderCashMessage = "Bartender: 'I'm afraid you ain't got the funds my friend. Would you like to try your card?'";
        const string notEnoughCash = "Not Enough Cash";
        const string bartenderCardMessage = "Bartender: 'I'm afraid you ain't got the funds my friend. See if you can get the cash for the round.'";
        const string cardDeclined = "Card Declined";
        const string bartenderYoureOut = "You can't afford that round you scurge. Out!";
        const string thrownOut = "Thrown Out";

        string redOrWhite;
        string selectedDrink;
        string quantityInput;

        int quantity;

        public static double myCash { get; set; }
        public static double myCard { get; set; }
        public static double priceOfRound;

        double priceOfDrink;        
        double cocktailPrice = 12.5;
        double tipInput;
        double tipTotal;
        double total;

        bool cardNotCash = false;
        bool roundPaid = false;

        public BarApp()
        {
            InitializeComponent();

            drinkTypeComboBox.Items.AddRange(drinkType);

            //we have radio buttons that are only visible when they are relevant to the selected drink
            winePanel.Visible = false;
            pintPanel.Visible = false;
            tipMethodPanel.Visible = false;
            drinkComboBox.Visible = false;

            //We have visibly available funds in the cash and card textboxes
            myCash = 50;
            myCard = 1000;

            myCashTextBox.Text = myCash.ToString("0.00");
            myCardTextBox.Text = myCard.ToString("0.00");

            //setting radio buttons checked as default
            cashRadioButton.Checked = true;
            tipPercentRadioButton.Checked = true;
        }

        private void drinkTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when we choose our drink type, the drinks combo box appears
            drinkComboBox.Visible = true;

            //We make the relevant radio buttons and drink types visible when 
            //the associated item is selected from the combo box
            //and when the specific radio button is checked

            if (drinkTypeComboBox.SelectedIndex == 0) //Wine
            {
                winePanel.Visible = true;
                pintPanel.Visible = false;
                drinkComboBox.Items.Clear();
                redWineRadioButton.Checked = true;
                drinkComboBox.Items.AddRange(redWineType);
                drinkComboBox.SelectedIndex = 2;
            }

            else if (drinkTypeComboBox.SelectedIndex == 1) //Pints
            {
                winePanel.Visible = false;
                pintPanel.Visible = true;                
                drinkComboBox.Items.Clear();
                stoutRadioButton.Checked = true;
                drinkComboBox.Items.AddRange(stoutType);
                drinkComboBox.SelectedIndex = 0;
            }

            else if (drinkTypeComboBox.SelectedIndex == 2) //Cocktails
            {
                winePanel.Visible = false;
                pintPanel.Visible = false;
                drinkComboBox.Items.Clear();
                drinkComboBox.Items.AddRange(cocktailType);
                drinkComboBox.SelectedIndex = 0;
            }
        }

        private void redWineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //filling the drink combo box with red wine types
            if (redWineRadioButton.Checked == true)
            {
                redOrWhite = "Red";
                drinkComboBox.Items.Clear();
                drinkComboBox.Items.AddRange(redWineType);
                drinkComboBox.SelectedIndex = 0;
            }
        }

        private void whiteWineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //filling the drink combo box with white wine types
            if (whiteWineRadioButton.Checked == true)
            {
                redOrWhite = "White";
                drinkComboBox.Items.Clear();
                drinkComboBox.Items.AddRange(whiteWineType);
                drinkComboBox.SelectedIndex = 0;
            }
        }

        private void lagerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //filling the combo box with selected pint types
            if (lagerRadioButton.Checked == true)
            {
                drinkComboBox.Items.Clear();
                drinkComboBox.Items.AddRange(lagerType);
                drinkComboBox.SelectedIndex = 0;
            }
        }

        private void stoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (stoutRadioButton.Checked == true)
            {
                drinkComboBox.Items.Clear();
                drinkComboBox.Items.AddRange(stoutType);
                drinkComboBox.SelectedIndex = 0;
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(quantityNumericUpDown.Value);           
            selectedDrink = Convert.ToString(drinkComboBox.SelectedItem);

            //If a drink type is already on the bill and we want to order more,
            //then we adjust the list item to reflect the change in quantity
            //instead of adding a whole new list item. 
            bool drinkTypeAlreadyOnBill = false;
            int j = orderListBox.Items.Count;

            for (int i = 0; i < j; i++)
            {
                string listItem = orderListBox.Items[i].ToString();
                if (listItem.Contains(selectedDrink))
                {
                    drinkTypeAlreadyOnBill = true;
                    string oldQuantity = listItem.Substring(0, Math.Max(listItem.IndexOf(' '), 0));
                    int newQuantity = Convert.ToInt32(oldQuantity) + quantity;
                    string updatedListItem = newQuantity.ToString() + listItem.Substring(listItem.IndexOf(' '));
                    orderListBox.Items.RemoveAt(i);
                    orderListBox.Items.Insert(i, updatedListItem);
                }
            }

            //if the customer chooses House Wine we use the class Wine
            //and create a new instance of Wine
            //we calculate the price of the drink and we store that price in a list
            //so that later we may remove items from our bill if we want
            if (selectedDrink.Contains("House"))
            {
                Wine orderedWine = new Wine(redOrWhite, quantity);
                priceOfDrink = quantity * orderedWine.priceGlass;
                prices.Add(priceOfDrink);
                priceOfRound += priceOfDrink;
                orderListBox.Items.Add(orderedWine.ToString());
                subtotalTextBox.Clear();
                subtotalTextBox.Text = priceOfRound.ToString("0.00");
                totalTextBox.Text = priceOfRound.ToString("0.00");
            }

            //now we use the class Red Wine which is a child class of Wine
            //if the selected drink is in the red wine array, we can create 
            //an instance of Red Wine with our paramaters.
            //Red Wine inherits from the parent class Wine.
            //We then add that instance to the order and we add up the total price of the order.
            else if (redWineType.Contains(selectedDrink))
            {
                RedWine orderedRedWine = new RedWine(redOrWhite, quantity, selectedDrink);
                priceOfDrink = quantity * orderedRedWine.priceGlass;
                prices.Add(priceOfDrink);
                priceOfRound += priceOfDrink;
                orderListBox.Items.Add(orderedRedWine.ToString());
                subtotalTextBox.Clear();
                subtotalTextBox.Text = priceOfRound.ToString("0.00");
                totalTextBox.Text = priceOfRound.ToString("0.00");
            }

            //the same action here
            else if (whiteWineType.Contains(selectedDrink))
            {
                WhiteWine orderedWhiteWine = new WhiteWine(redOrWhite, quantity, selectedDrink);
                priceOfDrink = quantity * orderedWhiteWine.priceGlass;
                prices.Add(priceOfDrink);
                priceOfRound += priceOfDrink;
                orderListBox.Items.Add(orderedWhiteWine.ToString());
                subtotalTextBox.Text = priceOfRound.ToString("0.00");
                totalTextBox.Text = priceOfRound.ToString("0.00");
            }

            //and so on
            else if (stoutType.Contains(selectedDrink))
            {
                Stout orderedStout = new Stout(quantity, selectedDrink);
                priceOfDrink = quantity * orderedStout.price;
                prices.Add(priceOfDrink);
                priceOfRound += priceOfDrink;
                orderListBox.Items.Add(orderedStout.ToString());
                subtotalTextBox.Text = priceOfRound.ToString("0.00");
                totalTextBox.Text = priceOfRound.ToString("0.00");
            }

            else if (lagerType.Contains(selectedDrink))
            {
                Lager orderedLager = new Lager(quantity, selectedDrink);
                priceOfDrink = quantity * orderedLager.price;
                prices.Add(priceOfDrink);
                priceOfRound += priceOfDrink;
                orderListBox.Items.Add(orderedLager.ToString());
                subtotalTextBox.Text = priceOfRound.ToString("0.00");
                totalTextBox.Text = priceOfRound.ToString("0.00");
            }

            else if (cocktailType.Contains(selectedDrink))
            {
                priceOfDrink = quantity * cocktailPrice;
                prices.Add(priceOfDrink);
                priceOfRound += priceOfDrink;
                orderListBox.Items.Add(quantity.ToString() + " x " + selectedDrink.ToString() + " @ €" + cocktailPrice.ToString("0.00"));
                subtotalTextBox.Text = priceOfRound.ToString("0.00");
                totalTextBox.Text = priceOfRound.ToString("0.00");
            }

            //bool isDouble = double.TryParse(tipTextBox.Text, out tipInput);

            ////if the tip value or perecentage is decided
            ////after an initial drink order is placed
            ////then the order keeps the original tip value in mind

            //if (isDouble == true)
            //{
            //    if (tipPercentRadioButton.Checked)
            //    {
            //        tipTotal = (priceOfRound / 100) * tipInput;
            //    }
            //    else if (tipEuroRadioButton.Checked)
            //    {
            //        tipTotal = tipInput;
            //    }
            //    total = priceOfRound + tipTotal;
            //    totalTextBox.Text = total.ToString("0.00");
            //}
            //else if (tipTextBox.Text == "")
            //{
            //    tipTotal = 0;
            //    total = priceOfRound;
            //    totalTextBox.Text = total.ToString("0.00");
            //}

            if (drinkTypeAlreadyOnBill)
            {
                orderListBox.Items.RemoveAt(j);
                drinkTypeAlreadyOnBill = false;
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int j = orderListBox.Items.Count;

            for (int i = 0; i < j; i++)
            {
                if (orderListBox.SelectedItem == orderListBox.Items[i])
                {
                    //We get the price of a single drink of the selected drink type
                    //And we update the listbox item quantity.
                    //Or, if the listbox item quantity is "1", we remove the listbox item entirely.
                    //Then later we subtract the price of that drink from the round price.
                    string listItem = orderListBox.Items[i].ToString();
                    string oldQuantity = listItem.Substring(0, Math.Max(listItem.IndexOf(' '), 0));
                    double drinkPriceEach = Convert.ToDouble(listItem.Substring(listItem.IndexOf('€')+1));
                    if (oldQuantity == "1")
                    {
                        orderListBox.Items.RemoveAt(i);
                    }
                    else
                    {
                        int newQuantity = Convert.ToInt32(oldQuantity) - 1;
                        string updatedListItem = newQuantity.ToString() + listItem.Substring(listItem.IndexOf(' '));
                        orderListBox.Items.RemoveAt(i);
                        orderListBox.Items.Insert(i, updatedListItem);
                    }
                    priceOfRound -= drinkPriceEach;
                    tipCheckBox.Checked = false;
                    subtotalTextBox.Text = priceOfRound.ToString("0.00");
                    totalTextBox.Text = priceOfRound.ToString("0.00");
                }
            }

            ////This is an old version where the order listbox was updated by calling the index of List<double> prices
            ////this button finds the selected item in the order listbox
            ////and removes it and its cost from the bill
            //for (int i = 0; i < prices.Count; i++)
            //{
            //    if (orderListBox.SelectedItem == orderListBox.Items[i])
            //    {
            //        orderListBox.Items.RemoveAt(i);
            //        priceOfRound -= prices[i];
            //        prices.RemoveAt(i);
            //        tipCheckBox.Checked = false;
            //        subtotalTextBox.Text = priceOfRound.ToString("0.00");
            //        totalTextBox.Text = priceOfRound.ToString("0.00");
            //    }
            //}
        }

        private void tipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //making the tipping options visible
            if (tipCheckBox.Checked)
            {
                tipMethodPanel.Visible = true;
                tipNumericUpDown.Visible = true;   
            }

            //making them invisible and removing the tip data
            else
            {
                tipMethodPanel.Visible = false;
                tipTotal = 0;
                total = priceOfRound;
                totalTextBox.Text = total.ToString("0.00");
                tipNumericUpDown.Visible = false;

            }
        }

        private void tipTextBox_TextChanged(object sender, EventArgs e)
        {
            ////dynamically reading and displaying the tip as the user types
            //bool isDouble = double.TryParse(tipTextBox.Text, out tipInput);
            //if (isDouble == true)
            //{
            //    if (tipPercentRadioButton.Checked)
            //    {
            //        tipTotal = (priceOfRound / 100) * tipInput;                    
            //    }
            //    else if (tipEuroRadioButton.Checked)
            //    {
            //        tipTotal = tipInput;
            //    }
            //    total = priceOfRound + tipTotal;
            //    totalTextBox.Text = total.ToString("0.00");
            //}
            //else if (tipTextBox.Text == "")
            //{
            //    tipTotal = 0;
            //    total = priceOfRound;
            //    totalTextBox.Text = total.ToString("0.00");
            //}
        }

        private void tipPercentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if the radio button option is changed to percent, the tip updates
            try
            {
                tipTotal = (priceOfRound / 100) * tipInput;
                total = priceOfRound + tipTotal;
                totalTextBox.Text = total.ToString("0.00");
            }
            catch
            {
            }
        }

        private void tipEuroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if the radio button option is changed to euro, the tip updates
            try
            {
                tipTotal = Convert.ToDouble(tipNumericUpDown.Value);
                total = priceOfRound + tipTotal;
                totalTextBox.Text = total.ToString("0.00");
            }
            catch
            {                
            }        
        }

        private void completeOrderButton_Click(object sender, EventArgs e)
        {
            if (tipCheckBox.Checked == false)
            {
                total = priceOfRound;
            }

            //if we choose to pay in cash
            if (cashRadioButton.Checked)
            {

                //and then if we can't afford it in cash
                if (priceOfRound + tipTotal > myCash)
                {
                    var result = MessageBox.Show(bartenderCashMessage, notEnoughCash, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    //the barman offers us the option to pay by card. We use the bool cardNotCash to deal
                    //with this situation
                    if(result == DialogResult.Yes)
                    {
                        cardNotCash = true;
                    }

                    // If we decline to use the card, the round is reset as if it was paid 
                    if (result == DialogResult.No)
                    {
                        roundPaid = true;
                    }
                }

                //if we successfully place the order with our cash
                else
                {
                    myCash -= total;
                    myCashTextBox.Text = myCash.ToString("0.00");
                    roundPaid = true;
                }
            }


            //if we're paying by card
            if (cardRadioButton.Checked || cardNotCash == true)
            {
                //if we can't afford it
                if (priceOfRound + tipTotal > myCard)
                {
                    //if we're out of money in both cash and card
                    if (cardNotCash == true)
                    {
                        MessageBox.Show(bartenderYoureOut, thrownOut, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                    }

                    //if we cant afford the round on the card
                    else
                    {
                        if (cardNotCash == true)
                        {
                            MessageBox.Show(bartenderYoureOut, thrownOut, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }
                        MessageBox.Show(bartenderCardMessage, cardDeclined, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cashRadioButton.Checked = true;                        
                    }
                }

                //if we successfully pay by card, the barman offers us cashback
                else
                {
                    Cashback cashbackForm = new Cashback();
                    cashbackForm.ShowDialog();
                    myCard -= total;
                    myCardTextBox.Clear();
                    myCardTextBox.Text = myCard.ToString("0.00");
                    myCashTextBox.Text = myCash.ToString("0.00");
                    roundPaid = true;
                }                
            }


            //if we successfully pay for the round we reset all of our form for the next drinks order
            //except our cash and card balance of course. but wouldn't that be nice?
            if (roundPaid == true)
            {
                drinkTypeComboBox.Text = "";
                drinkComboBox.Text = "";
                drinkComboBox.Items.Clear();
                tipNumericUpDown.Value = 0;
                lagerRadioButton.Checked = false;
                stoutRadioButton.Checked = false;
                whiteWineRadioButton.Checked = false;
                redWineRadioButton.Checked = false;
                drinkComboBox.Visible = false;
                winePanel.Visible = false;
                pintPanel.Visible = false;
                cardNotCash = false;
                orderListBox.Items.Clear();
                subtotalTextBox.Clear();
                totalTextBox.Clear();
                prices.Clear();
                priceOfRound = 0;
                tipInput = 0;
                tipTotal = 0;
                tipCheckBox.Checked = false;
                total = 0;
                roundPaid = false;
            }
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            //if the user cancels the order, we reset the form and all its variables
            drinkTypeComboBox.Text = "";
            drinkComboBox.Text = "";
            drinkComboBox.Items.Clear();
            lagerRadioButton.Checked = false;
            stoutRadioButton.Checked = false;
            whiteWineRadioButton.Checked = false;
            redWineRadioButton.Checked = false;
            drinkComboBox.Visible = false;
            winePanel.Visible = false;
            pintPanel.Visible = false;
            cardNotCash = false;
            tipNumericUpDown.Value = 0;
            orderListBox.Items.Clear();
            subtotalTextBox.Clear();
            totalTextBox.Clear();
            prices.Clear();
            priceOfRound = 0;
            tipInput = 0;
            tipTotal = 0;
            tipNumericUpDown.Visible = false;
            tipCheckBox.Checked = false;
            total = 0;
            roundPaid = false;
        }

        //Allowing us to move the form with click and drag
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

            private void exitButton_Click(object sender, EventArgs e)
        {
            //close the app
            MessageBox.Show("Thanks for stopping by! Take Care.");
            Application.Exit();
        }

        private void tipNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tipInput = Convert.ToDouble(tipNumericUpDown.Value);
            //dynamically reading and displaying the tip as the user types
                if (tipPercentRadioButton.Checked)
                {
                    tipTotal = (priceOfRound / 100) * tipInput;
                }
                else if (tipEuroRadioButton.Checked)
                {
                    tipTotal = tipInput;
                }
                total = priceOfRound + tipTotal;
                totalTextBox.Text = total.ToString("0.00");            
        }
    }
}

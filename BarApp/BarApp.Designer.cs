namespace BarApp
{
    partial class BarApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarApp));
            this.drinkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.redWineRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteWineRadioButton = new System.Windows.Forms.RadioButton();
            this.drinkComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.completeOrderButton = new System.Windows.Forms.Button();
            this.myCashTextBox = new System.Windows.Forms.TextBox();
            this.myCashLabel = new System.Windows.Forms.Label();
            this.stoutRadioButton = new System.Windows.Forms.RadioButton();
            this.lagerRadioButton = new System.Windows.Forms.RadioButton();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.myCardLabel = new System.Windows.Forms.Label();
            this.myCardTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.ourNamesLabel = new System.Windows.Forms.Label();
            this.beginOrderLabel = new System.Windows.Forms.Label();
            this.tipCheckBox = new System.Windows.Forms.CheckBox();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.tipMethodPanel = new System.Windows.Forms.Panel();
            this.tipEuroRadioButton = new System.Windows.Forms.RadioButton();
            this.tipPercentRadioButton = new System.Windows.Forms.RadioButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.paymentMethodPanel = new System.Windows.Forms.Panel();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.winePanel = new System.Windows.Forms.Panel();
            this.pintPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tipMethodPanel.SuspendLayout();
            this.paymentMethodPanel.SuspendLayout();
            this.winePanel.SuspendLayout();
            this.pintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // drinkTypeComboBox
            // 
            this.drinkTypeComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drinkTypeComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.drinkTypeComboBox.FormattingEnabled = true;
            this.drinkTypeComboBox.Location = new System.Drawing.Point(324, 106);
            this.drinkTypeComboBox.Name = "drinkTypeComboBox";
            this.drinkTypeComboBox.Size = new System.Drawing.Size(182, 33);
            this.drinkTypeComboBox.TabIndex = 0;
            this.drinkTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.drinkTypeComboBox_SelectedIndexChanged);
            // 
            // redWineRadioButton
            // 
            this.redWineRadioButton.AutoSize = true;
            this.redWineRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.redWineRadioButton.Location = new System.Drawing.Point(0, 0);
            this.redWineRadioButton.Name = "redWineRadioButton";
            this.redWineRadioButton.Size = new System.Drawing.Size(112, 29);
            this.redWineRadioButton.TabIndex = 1;
            this.redWineRadioButton.TabStop = true;
            this.redWineRadioButton.Text = "Red Wine";
            this.redWineRadioButton.UseVisualStyleBackColor = false;
            this.redWineRadioButton.CheckedChanged += new System.EventHandler(this.redWineRadioButton_CheckedChanged);
            // 
            // whiteWineRadioButton
            // 
            this.whiteWineRadioButton.AutoSize = true;
            this.whiteWineRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.whiteWineRadioButton.Location = new System.Drawing.Point(114, 0);
            this.whiteWineRadioButton.Name = "whiteWineRadioButton";
            this.whiteWineRadioButton.Size = new System.Drawing.Size(128, 29);
            this.whiteWineRadioButton.TabIndex = 2;
            this.whiteWineRadioButton.TabStop = true;
            this.whiteWineRadioButton.Text = "White Wine";
            this.whiteWineRadioButton.UseVisualStyleBackColor = false;
            this.whiteWineRadioButton.CheckedChanged += new System.EventHandler(this.whiteWineRadioButton_CheckedChanged);
            // 
            // drinkComboBox
            // 
            this.drinkComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drinkComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.drinkComboBox.FormattingEnabled = true;
            this.drinkComboBox.Location = new System.Drawing.Point(324, 206);
            this.drinkComboBox.Name = "drinkComboBox";
            this.drinkComboBox.Size = new System.Drawing.Size(182, 33);
            this.drinkComboBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.SystemColors.Info;
            this.quantityLabel.Location = new System.Drawing.Point(324, 262);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(84, 25);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity:";
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToOrderButton.Location = new System.Drawing.Point(324, 308);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(182, 34);
            this.addToOrderButton.TabIndex = 6;
            this.addToOrderButton.Text = "Add To Order";
            this.addToOrderButton.UseVisualStyleBackColor = false;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.orderListBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 25;
            this.orderListBox.Location = new System.Drawing.Point(772, 106);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(348, 179);
            this.orderListBox.TabIndex = 7;
            // 
            // completeOrderButton
            // 
            this.completeOrderButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.completeOrderButton.Location = new System.Drawing.Point(769, 501);
            this.completeOrderButton.Name = "completeOrderButton";
            this.completeOrderButton.Size = new System.Drawing.Size(193, 34);
            this.completeOrderButton.TabIndex = 8;
            this.completeOrderButton.Text = "Complete Order";
            this.completeOrderButton.UseVisualStyleBackColor = false;
            this.completeOrderButton.Click += new System.EventHandler(this.completeOrderButton_Click);
            // 
            // myCashTextBox
            // 
            this.myCashTextBox.Location = new System.Drawing.Point(436, 555);
            this.myCashTextBox.Name = "myCashTextBox";
            this.myCashTextBox.ReadOnly = true;
            this.myCashTextBox.Size = new System.Drawing.Size(70, 31);
            this.myCashTextBox.TabIndex = 9;
            // 
            // myCashLabel
            // 
            this.myCashLabel.AutoSize = true;
            this.myCashLabel.BackColor = System.Drawing.SystemColors.Info;
            this.myCashLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myCashLabel.Location = new System.Drawing.Point(324, 555);
            this.myCashLabel.Name = "myCashLabel";
            this.myCashLabel.Size = new System.Drawing.Size(106, 28);
            this.myCashLabel.TabIndex = 10;
            this.myCashLabel.Text = "My Cash: €";
            // 
            // stoutRadioButton
            // 
            this.stoutRadioButton.AutoSize = true;
            this.stoutRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.stoutRadioButton.Location = new System.Drawing.Point(5, 0);
            this.stoutRadioButton.Name = "stoutRadioButton";
            this.stoutRadioButton.Size = new System.Drawing.Size(79, 29);
            this.stoutRadioButton.TabIndex = 11;
            this.stoutRadioButton.TabStop = true;
            this.stoutRadioButton.Text = "Stout";
            this.stoutRadioButton.UseVisualStyleBackColor = false;
            this.stoutRadioButton.CheckedChanged += new System.EventHandler(this.stoutRadioButton_CheckedChanged);
            // 
            // lagerRadioButton
            // 
            this.lagerRadioButton.AutoSize = true;
            this.lagerRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.lagerRadioButton.Location = new System.Drawing.Point(102, 0);
            this.lagerRadioButton.Name = "lagerRadioButton";
            this.lagerRadioButton.Size = new System.Drawing.Size(80, 29);
            this.lagerRadioButton.TabIndex = 12;
            this.lagerRadioButton.TabStop = true;
            this.lagerRadioButton.Text = "Lager";
            this.lagerRadioButton.UseVisualStyleBackColor = false;
            this.lagerRadioButton.CheckedChanged += new System.EventHandler(this.lagerRadioButton_CheckedChanged);
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtotalTextBox.Location = new System.Drawing.Point(873, 310);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(96, 26);
            this.subtotalTextBox.TabIndex = 13;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.SystemColors.Info;
            this.subtotalLabel.Location = new System.Drawing.Point(769, 311);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(98, 25);
            this.subtotalLabel.TabIndex = 14;
            this.subtotalLabel.Text = "Subtotal: €";
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(12, 1);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(75, 29);
            this.cashRadioButton.TabIndex = 15;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(104, 1);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(74, 29);
            this.cardRadioButton.TabIndex = 16;
            this.cardRadioButton.TabStop = true;
            this.cardRadioButton.Text = "Card";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            // 
            // myCardLabel
            // 
            this.myCardLabel.AutoSize = true;
            this.myCardLabel.BackColor = System.Drawing.SystemColors.Info;
            this.myCardLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myCardLabel.Location = new System.Drawing.Point(324, 592);
            this.myCardLabel.Name = "myCardLabel";
            this.myCardLabel.Size = new System.Drawing.Size(106, 28);
            this.myCardLabel.TabIndex = 17;
            this.myCardLabel.Text = "My Card: €";
            // 
            // myCardTextBox
            // 
            this.myCardTextBox.Location = new System.Drawing.Point(436, 592);
            this.myCardTextBox.Name = "myCardTextBox";
            this.myCardTextBox.ReadOnly = true;
            this.myCardTextBox.Size = new System.Drawing.Size(70, 31);
            this.myCardTextBox.TabIndex = 18;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Location = new System.Drawing.Point(968, 650);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 34);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Hit The Road";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ourNamesLabel
            // 
            this.ourNamesLabel.AutoSize = true;
            this.ourNamesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ourNamesLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ourNamesLabel.Location = new System.Drawing.Point(969, 687);
            this.ourNamesLabel.MinimumSize = new System.Drawing.Size(150, 21);
            this.ourNamesLabel.Name = "ourNamesLabel";
            this.ourNamesLabel.Size = new System.Drawing.Size(150, 21);
            this.ourNamesLabel.TabIndex = 21;
            this.ourNamesLabel.Text = "Ben Lawlor 2020\r\n";
            this.ourNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginOrderLabel
            // 
            this.beginOrderLabel.AutoSize = true;
            this.beginOrderLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.beginOrderLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.beginOrderLabel.Location = new System.Drawing.Point(130, 109);
            this.beginOrderLabel.Name = "beginOrderLabel";
            this.beginOrderLabel.Size = new System.Drawing.Size(188, 25);
            this.beginOrderLabel.TabIndex = 22;
            this.beginOrderLabel.Text = "Begin your order here:";
            // 
            // tipCheckBox
            // 
            this.tipCheckBox.AutoSize = true;
            this.tipCheckBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.tipCheckBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tipCheckBox.Location = new System.Drawing.Point(769, 346);
            this.tipCheckBox.Name = "tipCheckBox";
            this.tipCheckBox.Size = new System.Drawing.Size(143, 29);
            this.tipCheckBox.TabIndex = 23;
            this.tipCheckBox.Text = "Include a tip?";
            this.tipCheckBox.UseVisualStyleBackColor = false;
            this.tipCheckBox.CheckedChanged += new System.EventHandler(this.tipCheckBox_CheckedChanged);
            // 
            // tipTextBox
            // 
            this.tipTextBox.Location = new System.Drawing.Point(769, 385);
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(61, 31);
            this.tipTextBox.TabIndex = 24;
            this.tipTextBox.TextChanged += new System.EventHandler(this.tipTextBox_TextChanged);
            // 
            // tipMethodPanel
            // 
            this.tipMethodPanel.Controls.Add(this.tipEuroRadioButton);
            this.tipMethodPanel.Controls.Add(this.tipPercentRadioButton);
            this.tipMethodPanel.Location = new System.Drawing.Point(853, 385);
            this.tipMethodPanel.Name = "tipMethodPanel";
            this.tipMethodPanel.Size = new System.Drawing.Size(109, 31);
            this.tipMethodPanel.TabIndex = 25;
            // 
            // tipEuroRadioButton
            // 
            this.tipEuroRadioButton.AutoSize = true;
            this.tipEuroRadioButton.Location = new System.Drawing.Point(58, 2);
            this.tipEuroRadioButton.Name = "tipEuroRadioButton";
            this.tipEuroRadioButton.Size = new System.Drawing.Size(47, 29);
            this.tipEuroRadioButton.TabIndex = 21;
            this.tipEuroRadioButton.TabStop = true;
            this.tipEuroRadioButton.Text = "€";
            this.tipEuroRadioButton.UseVisualStyleBackColor = true;
            this.tipEuroRadioButton.CheckedChanged += new System.EventHandler(this.tipEuroRadioButton_CheckedChanged);
            // 
            // tipPercentRadioButton
            // 
            this.tipPercentRadioButton.AutoSize = true;
            this.tipPercentRadioButton.Location = new System.Drawing.Point(7, 2);
            this.tipPercentRadioButton.Name = "tipPercentRadioButton";
            this.tipPercentRadioButton.Size = new System.Drawing.Size(52, 29);
            this.tipPercentRadioButton.TabIndex = 20;
            this.tipPercentRadioButton.TabStop = true;
            this.tipPercentRadioButton.Text = "%";
            this.tipPercentRadioButton.UseVisualStyleBackColor = true;
            this.tipPercentRadioButton.CheckedChanged += new System.EventHandler(this.tipPercentRadioButton_CheckedChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.Info;
            this.totalLabel.Location = new System.Drawing.Point(769, 426);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(68, 25);
            this.totalLabel.TabIndex = 26;
            this.totalLabel.Text = "Total: €";
            // 
            // paymentMethodPanel
            // 
            this.paymentMethodPanel.Controls.Add(this.cashRadioButton);
            this.paymentMethodPanel.Controls.Add(this.cardRadioButton);
            this.paymentMethodPanel.Location = new System.Drawing.Point(769, 461);
            this.paymentMethodPanel.Name = "paymentMethodPanel";
            this.paymentMethodPanel.Size = new System.Drawing.Size(193, 30);
            this.paymentMethodPanel.TabIndex = 27;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(873, 423);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(89, 31);
            this.totalTextBox.TabIndex = 13;
            // 
            // winePanel
            // 
            this.winePanel.Controls.Add(this.whiteWineRadioButton);
            this.winePanel.Controls.Add(this.redWineRadioButton);
            this.winePanel.Location = new System.Drawing.Point(264, 159);
            this.winePanel.Name = "winePanel";
            this.winePanel.Size = new System.Drawing.Size(242, 29);
            this.winePanel.TabIndex = 28;
            // 
            // pintPanel
            // 
            this.pintPanel.Controls.Add(this.stoutRadioButton);
            this.pintPanel.Controls.Add(this.lagerRadioButton);
            this.pintPanel.Location = new System.Drawing.Point(324, 159);
            this.pintPanel.Name = "pintPanel";
            this.pintPanel.Size = new System.Drawing.Size(182, 27);
            this.pintPanel.TabIndex = 29;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(975, 310);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(144, 26);
            this.removeButton.TabIndex = 30;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(768, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Your order:";
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelOrderButton.Location = new System.Drawing.Point(975, 348);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(144, 26);
            this.cancelOrderButton.TabIndex = 31;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(426, 260);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(80, 31);
            this.quantityNumericUpDown.TabIndex = 32;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BarApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 715);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.pintPanel);
            this.Controls.Add(this.winePanel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.paymentMethodPanel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.tipMethodPanel);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.tipCheckBox);
            this.Controls.Add(this.beginOrderLabel);
            this.Controls.Add(this.ourNamesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.myCardTextBox);
            this.Controls.Add(this.myCardLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.myCashLabel);
            this.Controls.Add(this.myCashTextBox);
            this.Controls.Add(this.completeOrderButton);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.drinkComboBox);
            this.Controls.Add(this.drinkTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarApp";
            this.tipMethodPanel.ResumeLayout(false);
            this.tipMethodPanel.PerformLayout();
            this.paymentMethodPanel.ResumeLayout(false);
            this.paymentMethodPanel.PerformLayout();
            this.winePanel.ResumeLayout(false);
            this.winePanel.PerformLayout();
            this.pintPanel.ResumeLayout(false);
            this.pintPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drinkTypeComboBox;
        private System.Windows.Forms.RadioButton redWineRadioButton;
        private System.Windows.Forms.RadioButton whiteWineRadioButton;
        private System.Windows.Forms.ComboBox drinkComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button completeOrderButton;
        private System.Windows.Forms.TextBox myCashTextBox;
        private System.Windows.Forms.Label myCashLabel;
        private System.Windows.Forms.RadioButton stoutRadioButton;
        private System.Windows.Forms.RadioButton lagerRadioButton;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.Label myCardLabel;
        private System.Windows.Forms.TextBox myCardTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label ourNamesLabel;
        private System.Windows.Forms.Label beginOrderLabel;
        private System.Windows.Forms.CheckBox tipCheckBox;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.Panel tipMethodPanel;
        private System.Windows.Forms.RadioButton tipEuroRadioButton;
        private System.Windows.Forms.RadioButton tipPercentRadioButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel paymentMethodPanel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Panel winePanel;
        private System.Windows.Forms.Panel pintPanel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
    }
}


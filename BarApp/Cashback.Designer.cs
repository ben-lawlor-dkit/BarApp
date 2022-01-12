namespace BarApp
{
    partial class Cashback
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.cashbackTextBox = new System.Windows.Forms.TextBox();
            this.cashbackLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(364, 96);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(72, 34);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(442, 96);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 34);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cashbackTextBox
            // 
            this.cashbackTextBox.Location = new System.Drawing.Point(184, 59);
            this.cashbackTextBox.Name = "cashbackTextBox";
            this.cashbackTextBox.Size = new System.Drawing.Size(150, 31);
            this.cashbackTextBox.TabIndex = 1;
            // 
            // cashbackLabel
            // 
            this.cashbackLabel.AutoSize = true;
            this.cashbackLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashbackLabel.Location = new System.Drawing.Point(15, 9);
            this.cashbackLabel.Name = "cashbackLabel";
            this.cashbackLabel.Size = new System.Drawing.Size(493, 38);
            this.cashbackLabel.TabIndex = 2;
            this.cashbackLabel.Text = "\"How much cashback would you like?\"";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Enabled = false;
            this.euroLabel.Location = new System.Drawing.Point(156, 62);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(22, 25);
            this.euroLabel.TabIndex = 3;
            this.euroLabel.Text = "€";
            // 
            // Cashback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 137);
            this.Controls.Add(this.euroLabel);
            this.Controls.Add(this.cashbackLabel);
            this.Controls.Add(this.cashbackTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.okButton);
            this.Name = "Cashback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cashback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox cashbackTextBox;
        private System.Windows.Forms.Label cashbackLabel;
        private System.Windows.Forms.Label euroLabel;
    }
}
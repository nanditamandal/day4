namespace coffe_shop
{
    partial class Coffeeshop

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
            this.displayrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.quantitylabel5 = new System.Windows.Forms.Label();
            this.orderlabel4 = new System.Windows.Forms.Label();
            this.addresslabel3 = new System.Windows.Forms.Label();
            this.contactnolabel2 = new System.Windows.Forms.Label();
            this.customernamelabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayrichTextBox1
            // 
            this.displayrichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayrichTextBox1.Location = new System.Drawing.Point(493, 50);
            this.displayrichTextBox1.Name = "displayrichTextBox1";
            this.displayrichTextBox1.ReadOnly = true;
            this.displayrichTextBox1.Size = new System.Drawing.Size(200, 332);
            this.displayrichTextBox1.TabIndex = 0;
            this.displayrichTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.orderComboBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.contactTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.quantitylabel5);
            this.groupBox1.Controls.Add(this.orderlabel4);
            this.groupBox1.Controls.Add(this.addresslabel3);
            this.groupBox1.Controls.Add(this.contactnolabel2);
            this.groupBox1.Controls.Add(this.customernamelabel1);
            this.groupBox1.Location = new System.Drawing.Point(64, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(183, 282);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(291, 282);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Regular-80"});
            this.orderComboBox.Location = new System.Drawing.Point(183, 188);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(183, 21);
            this.orderComboBox.TabIndex = 9;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(183, 226);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(183, 20);
            this.quantityTextBox.TabIndex = 8;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytextBox4_KeyPress);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(183, 138);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(183, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(183, 93);
            this.contactTextBox.MaxLength = 11;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(183, 20);
            this.contactTextBox.TabIndex = 6;
            this.contactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttextBox2_KeyPress);
            this.contactTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.contactTextBox_KeyUp);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(183, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(183, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // quantitylabel5
            // 
            this.quantitylabel5.AutoSize = true;
            this.quantitylabel5.Location = new System.Drawing.Point(39, 233);
            this.quantitylabel5.Name = "quantitylabel5";
            this.quantitylabel5.Size = new System.Drawing.Size(46, 13);
            this.quantitylabel5.TabIndex = 4;
            this.quantitylabel5.Text = "Quantity";
            // 
            // orderlabel4
            // 
            this.orderlabel4.AutoSize = true;
            this.orderlabel4.Location = new System.Drawing.Point(39, 188);
            this.orderlabel4.Name = "orderlabel4";
            this.orderlabel4.Size = new System.Drawing.Size(33, 13);
            this.orderlabel4.TabIndex = 3;
            this.orderlabel4.Text = "Order";
            // 
            // addresslabel3
            // 
            this.addresslabel3.AutoSize = true;
            this.addresslabel3.Location = new System.Drawing.Point(39, 141);
            this.addresslabel3.Name = "addresslabel3";
            this.addresslabel3.Size = new System.Drawing.Size(45, 13);
            this.addresslabel3.TabIndex = 2;
            this.addresslabel3.Text = "Address";
            // 
            // contactnolabel2
            // 
            this.contactnolabel2.AutoSize = true;
            this.contactnolabel2.Location = new System.Drawing.Point(39, 93);
            this.contactnolabel2.Name = "contactnolabel2";
            this.contactnolabel2.Size = new System.Drawing.Size(61, 13);
            this.contactnolabel2.TabIndex = 1;
            this.contactnolabel2.Text = "Contact No";
            // 
            // customernamelabel1
            // 
            this.customernamelabel1.AutoSize = true;
            this.customernamelabel1.Location = new System.Drawing.Point(39, 54);
            this.customernamelabel1.Name = "customernamelabel1";
            this.customernamelabel1.Size = new System.Drawing.Size(82, 13);
            this.customernamelabel1.TabIndex = 0;
            this.customernamelabel1.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::coffe_shop.Properties.Resources.star;
            this.label1.Location = new System.Drawing.Point(449, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Coffeeshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayrichTextBox1);
            this.Name = "Coffeeshop";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayrichTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label quantitylabel5;
        private System.Windows.Forms.Label orderlabel4;
        private System.Windows.Forms.Label addresslabel3;
        private System.Windows.Forms.Label contactnolabel2;
        private System.Windows.Forms.Label customernamelabel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_shop
{
    public partial class Coffeeshop : Form
    {
        List<string> customerName = new List<string> { };
        List<string> address = new List<string> { };
        List<string> mobile = new List<string> { };
        List<string> order = new List<string> { };
        List<string> quantity = new List<string> { };
        List<string> totalprice = new List<string> { }; 
        
        List<string> add = new List<string> { };


        int index = 0;
        int q, price;
        string value;


        public Coffeeshop()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<add.Count; i++)
            {
                value += "name\t" + customerName[i] + Environment.NewLine +
                   "address\t" + address[i] + Environment.NewLine +
                   "contact number\t" + mobile[i] + Environment.NewLine +
                  "order\t" + order[i] + Environment.NewLine +
                  "quantity\t" + quantity[i] + Environment.NewLine+
                   "total price\t" + totalprice[i];



            }
            displayrichTextBox1.Text = value;
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Display();

           
        

            if (nameTextBox.Text == "")
                

            {
                MessageBox.Show("please fill up name detail..");

            }
            else if(addressTextBox.Text == ""  )
                {
                MessageBox.Show("please fill up address detail..");
            }
            else if (contactTextBox.Text == "" )
                {
                MessageBox.Show("please fill up contact..");
            }
            else if (orderComboBox.Text == "")
            {
                MessageBox.Show("please fill up order..");
            }
            else if (quantityTextBox.Text == "")
            {
                MessageBox.Show("please fill upquantity ..");
            }

            else
            {

                customerName.Add(nameTextBox.Text);
                address.Add(addressTextBox.Text);
                mobile.Add(contactTextBox.Text);
                order.Add(orderComboBox.Text);
                quantity.Add(quantityTextBox.Text);

                q = int.Parse(quantity[index]);



                if (order[index] == "Black-120")
                {
                    price = 120;
                    totalprice.Add(Convert.ToString(price * q));
                }
                else if (order[index] == "Cold-100")
                {
                    price = 100;
                    totalprice.Add(Convert.ToString(price * q));
                }
                else if (order[index] == "Hot-90")
                {
                    price = 90;
                    totalprice.Add(Convert.ToString(price * q));
                }
                else if (order[index] == "Regular-80")
                {
                    price = 80;
                    totalprice.Add(Convert.ToString(price * q));
                }

                value += "name\t" + customerName[index] + Environment.NewLine +
                       "address\t" + address[index] + Environment.NewLine +
                       "contact number\t" + mobile[index] + Environment.NewLine +
                      "order\t" + order[index] + Environment.NewLine +
                      "quantity\t" + quantity[index] + Environment.NewLine +
                       "total price\t" + totalprice[index] + Environment.NewLine;

                displayrichTextBox1.Text = value;
                add.Add(value);
                index++;
            }
            Empty();

        }
        private void Display()
        {
              
            displayrichTextBox1.Clear();
            displayrichTextBox1.Text = "";
        }
        private void Empty()
        {
            nameTextBox.Text = ""; addressTextBox.Text = ""; contactTextBox.Text = "";
            orderComboBox.Text = ""; quantityTextBox.Text = "";
        }
        
        private void contacttextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contactTextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void quantitytextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}








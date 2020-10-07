using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ICT526_A2_GRP2
{
    public partial class InventoryUp : Form
    {
        List<Inventory> ic = new List<Inventory>();
        public void listpop()
        {
            using (StreamReader SR = new StreamReader(@".\InventoryList.txt")) //reads the file
            {
                while (!SR.EndOfStream)
                {

                    string line = SR.ReadLine();
                    string[] s = line.Split(new string[] { ", " }, StringSplitOptions.None); //splits the strings by comma and a space
                    string name = s[0];
                    string itemcode = s[1];

                    string quantity = s[2];
                    string color = s[3];
                    string price = s[4];
                    string discount = s[5];

                    Inventory inv = new Inventory
                    {
                        Name = name,
                        ItemCode = itemcode,
                        Quantity = quantity,
                        Color = color,
                        Price = price,
                        Discount = discount




                    };
                    Inventory codes = new Inventory
                    {

                        ItemCode = itemcode
                    };

                    ic.Add(codes);


                    cmbIMcode1.Items.Add(inv); //with the help of public override string ItemCode the combobox will show the itemcode 


                    cmbIMcode1.AutoCompleteSource = AutoCompleteSource.CustomSource; //creates an auto complete for the combo box
                    cmbIMcode1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;    //this limits the mistake of writing a wrong item code 
                    cmbIMcode1.AutoCompleteCustomSource.Add(inv.ItemCode);           //if the itemcode does not exist, the the program will not show anything 

                }
                cmbIMcode1.Items.RemoveAt(0);
                cmbIMcode1.AutoCompleteCustomSource.RemoveAt(0);

            }
        }

        public InventoryUp()
        {
            InitializeComponent();
        }

        private void InventoryUp_Load(object sender, EventArgs e)
        {
            listpop();

        }

        private void btnIMupdate2_Click(object sender, EventArgs e)
        {

            {
                string commaspacecheck = ", ";
                int quantityparse;
                double priceparse;
                double discountparse;

                if (cmbIMcode1.SelectedIndex == -1) //checks if the current index is at -1, if it is an error message shows, the program also has multiple safety measures in place
                {                                  //regarding inputing an item without an item code
                    MessageBox.Show("Please enter a correct code");
                }
                else
                {

                    if (Convert.ToString(txtIMName2.Text).Contains(commaspacecheck))
                    {
                        MessageBox.Show("Please check the syntax of the Item name.");
                    }
                    else if (Convert.ToString(txtIMclr2.Text).Contains(commaspacecheck))
                    {
                        MessageBox.Show("Please check the syntax of the Color of the product");
                    }
                    else if (!int.TryParse(txtIMQty2.Text, out quantityparse))
                    {
                        MessageBox.Show("Please check if quantity is a numeric value without decimal points.");
                    }
                    else if (!double.TryParse(txtIMprc2.Text, out priceparse))
                    {
                        MessageBox.Show("Please check if Price set is a numeric value");
                    }
                    else if (!double.TryParse(txtIMdisc2.Text, out discountparse) || discountparse > 100)
                    {
                        MessageBox.Show("Please check if Discount set is a numeric value");
                    }
                    else
                    {
                        string olddetail = Convert.ToString(lblIMname2.Text) + ", " + Convert.ToString(lblIMcode2.Text) + ", " + Convert.ToString(lblIMqty2.Text)
                            + ", " + Convert.ToString(lblIMcol2.Text) + ", " + Convert.ToString(lblIMprc2.Text) + ", " + Convert.ToString(lblIMdisc2.Text);

                        string newdetail = Convert.ToString(txtIMName2.Text) + ", " + Convert.ToString(lblIMcode2.Text) + ", " + Convert.ToString(txtIMQty2.Text)
                            + ", " + Convert.ToString(txtIMclr2.Text) + ", " + Convert.ToString(txtIMprc2.Text) + ", " + Convert.ToString(txtIMdisc2.Text);

                        StreamReader sr = new StreamReader(@".\InventoryList.txt");

                        string itemdetail = sr.ReadToEnd();
                        sr.Close();
                        itemdetail = Regex.Replace(itemdetail, olddetail, newdetail); //regex updates the text file, the best part about it; if it doesn't find the old item 
                                                                                      //to be updated, it does not commit the updtate preventing hassles regarding fixing the text file. 
                        StreamWriter sw = new StreamWriter(@".\InventoryList.txt");
                        sw.Write(itemdetail);
                        sw.Close();

                        string updatemessage = "Item " + Convert.ToString(lblIMcode2.Text) + " has been updated";

                        MessageBox.Show(updatemessage);

                        //AdminFunc admin = new AdminFunc();
                        //admin.Close();

                        InventoryUp up = new InventoryUp();
                        this.Hide();
                        up.Show();








                    }

                }
            }
        }

        private void btnIMreturn2_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryMan frm1 = new InventoryMan();
            frm1.ShowDialog();
        }

        private void cmbIMcode1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventory selecteditem = (Inventory)cmbIMcode1.SelectedItem;
            lblIMname2.Text = selecteditem.Name;
            lblIMqty2.Text = selecteditem.Quantity;
            lblIMcol2.Text = selecteditem.Color;
            lblIMprc2.Text = selecteditem.Price;
            lblIMdisc2.Text = selecteditem.Discount;
            lblIMcode2.Text = selecteditem.ItemCode;

            txtIMName2.Text = selecteditem.Name;
            txtIMQty2.Text = selecteditem.Quantity;
            txtIMclr2.Text = selecteditem.Color;
            txtIMdisc2.Text = selecteditem.Discount;
            txtIMprc2.Text = selecteditem.Price;
        }
    }
}

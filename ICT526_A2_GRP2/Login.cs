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

namespace The_Comfort_Zone
{
    public partial class FormLogin : Form
    {
        List<string> user = new List<string>();
        List<string> password = new List<string>();
        List<string> title = new List<string>();
        public FormLogin()
        {
            InitializeComponent();

            const string path = @".\employeedetail.txt";
            string[] lineOfContents = File.ReadAllLines(path);
            foreach (string line in lineOfContents)
            {
                string[] itemn = line.Split('|');


                user.Add(itemn[0]);
                password.Add(itemn[1]);
                title.Add(itemn[2]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Contains(txtuser.Text) && password.Contains(txtpass.Text)) 
                
            {
                if (password[Array.IndexOf(user.ToArray(), txtuser.Text)] == txtpass.Text)
                {
                    this.Hide();

                    if (title[Array.IndexOf(user.ToArray(), txtuser.Text)] == "admin")
                    {
                        AdminFunc af = new AdminFunc();
                        af.ShowDialog();
                    }

                    else if (title[Array.IndexOf(user.ToArray(), txtuser.Text)] == "sales staff")
                    {
                        Salesstaffmain salesmain = new Salesstaffmain();
                        salesmain.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("You don't have access.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                   
                    

                    
                }
            

            }
            else
            {
                MessageBox.Show("The Username and Password is incorrect.");
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}

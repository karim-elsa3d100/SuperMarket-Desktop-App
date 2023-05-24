using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string SellerName = "";
        // SQLiteConnection Con = new SQLiteConnection(@"Data Source=F:\c# projects\SuperMarket\bin\Debug\SuperMarket.Db"); 
         SQLiteConnection Con = new SQLiteConnection(@"Data Source=bin\Debug\SuperMarket.Db"); 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" ||  PasswordTb.Text == "")
            {
                MessageBox.Show("Enter the UserName And Password");
            }
            else
            {
                if (SelectRole.SelectedIndex > -1)
                {
                    if (SelectRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (UserNameTb.Text == "Admin" || PasswordTb.Text == "Admin")
                        {
                            ProductForm Prod = new ProductForm();
                            this.Hide();
                            Prod.Show();
                        }
                        else { MessageBox.Show("Enter the correct username and password for Admin"); }
                    }
                    else if (SelectRole.SelectedItem.ToString() == "SELLER")
                    {
                        Con.Open();
                        SQLiteCommand cmd= new SQLiteCommand("SELECT count(*) FROM SellerTbl WHERE SellerName='"+UserNameTb.Text+"' and SellerPass='"+PasswordTb.Text+"'", Con);
                        int Check=Convert.ToInt32(cmd.ExecuteScalar());
                        if (Check == 0)
                        {
                            MessageBox.Show("Enter Valid User name and Password");
                        }
                        else
                        {
                            SellerName=UserNameTb.Text;
                            SellingForm selling = new SellingForm();
                            Con.Close();
                            selling.Show();
                            this.Hide();
                        }
                        Con.Close();
                    }         
                }
                else
                { MessageBox.Show("Select role");}
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

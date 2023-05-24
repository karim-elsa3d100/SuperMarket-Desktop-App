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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        //SQLiteConnection Con=new SQLiteConnection(@"Data Source=F:\c# projects\SuperMarket\bin\Debug\SuperMarket.Db");
        SQLiteConnection Con = new SQLiteConnection(@"Data Source=bin\Debug\SuperMarket.Db");
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void populate()
        {
            try
            {
                Con.Open();
                string Query = "select *from SellerTbl";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(Query, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                SellersDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void SellersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellerIdTb.Text = SellersDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellerNameTb.Text = SellersDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellerAgeTb.Text = SellersDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhoneTb.Text = SellersDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellerPassTb.Text = SellersDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerIdTb.Text == "" || SellerNameTb.Text == "" || SellerPassTb.Text == "" || SellerPhoneTb.Text == "" || SellerAgeTb.Text == "")
                {
                    MessageBox.Show("Enter Complete information to add Seller");
                }
                else
                {
                    Con.Open();
                    SQLiteCommand cmd1=new SQLiteCommand("SELECT count(*) FROM SellerTbl WHERE SellerId="+SellerIdTb.Text+"", Con);
                    int check = Convert.ToInt32(cmd1.ExecuteScalar());
                    if(check == 0) 
                    {
                        string Query = "insert into SellerTbl values (" + SellerIdTb.Text + " , '" + SellerNameTb.Text + "' , " + SellerAgeTb.Text + ", '" + SellerPhoneTb.Text + "' , '" + SellerPassTb.Text + "')";
                        SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller added successfuly");
                    }
                    else
                    {
                        MessageBox.Show("Enter unique id");
                    }
                   
                    Con.Close();
                    populate();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerIdTb.Text == "" )
                {
                    MessageBox.Show("Select Seller you want to delet or Enter his id");
                }
                else
                {
                    Con.Open();
                    string Query = "delete from SellerTbl where SellerId= "+SellerIdTb.Text+"";
                    SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted successfuly");
                    Con.Close();
                    populate();
                    SellerIdTb.Text = ""; SellerNameTb.Text = "";SellerPassTb.Text = ""; SellerPhoneTb.Text = "";SellerAgeTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerIdTb.Text == "" || SellerNameTb.Text=="" || SellerPassTb.Text=="" || SellerPhoneTb.Text=="" || SellerAgeTb.Text=="")
                {
                    MessageBox.Show("Comlete the information to Edit Seller");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName='" + SellerNameTb.Text + "' , SellerAge=" + SellerAgeTb.Text + " , SellerPhone= '" + SellerPhoneTb.Text + "' , SellerPass='" + SellerPassTb.Text + "' where SellerId=" + SellerIdTb.Text + ""; 
                    SQLiteCommand cmd=new SQLiteCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Edited Successfuly");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception Ex)
            { 
                MessageBox.Show(Ex.Message);    
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            ProductForm prd =new ProductForm();
            this.Hide();
            prd.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            CategoyForm categoyForm =new CategoyForm();
            this.Hide();
            categoyForm.Show(); 
        }
        private void gunaButton7_Click(object sender, EventArgs e)
        {
            SellingForm sf =new SellingForm();    
            this.Hide();
            sf.Show();  
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm =new LoginForm();
            this.Hide();
            loginForm.Show();   
            
        }
    }
}

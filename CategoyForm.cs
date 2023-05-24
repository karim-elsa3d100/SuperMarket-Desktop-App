using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class CategoyForm : Form
    {
        public CategoyForm()
        {
            InitializeComponent();
        }

        //  SQLiteConnection Con = new SQLiteConnection(@"Data Source=F:\c# projects\SuperMarket\bin\Debug\SuperMarket.Db");
        SQLiteConnection Con = new SQLiteConnection(@"Data Source=bin\Debug\SuperMarket.Db");
        private void gunaButton1_Click(object sender, EventArgs e)
        {   
            try
            {        
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Enter Complete information to add Category");
                }
                else
                {
                    Con.Open();
                    SQLiteCommand cmd1 = new SQLiteCommand("SELECT count(*) FROM CategoryTbl WHERE CatId = "+ CatIdTb.Text+"" , Con);
                    int Check=Convert.ToInt32(cmd1.ExecuteScalar());
                    if (Check == 0)
                    {
                        string Query = "insert into CategoryTbl values (" + CatIdTb.Text + " , '" + CatNameTb.Text + "' , '" + CatDescTb.Text + "')";
                        SQLiteCommand cmd2 = new SQLiteCommand(Query, Con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Category added successfuly");
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text= CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();

        }
        private void populate()
        {
            try 
            {
                Con.Open();
                string Query = "select *from CategoryTbl";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(Query,Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CatDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CategoyForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text=="" || CatDescTb.Text=="")
                {
                    MessageBox.Show("Complete information of Category to Edit it");
                }
                else
                {
                    Con.Open();
                    string Query = "update CategoryTbl set CatName='"+CatNameTb.Text+"'  , CatDesc = '"+CatDescTb.Text+"' where CatId=" + CatIdTb.Text + "";
                    SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Edited Successfuly");
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
                if (CatIdTb.Text == "")
                {
                    MessageBox.Show("Select the Category to Delete or Enter the id of the Category needed to delet");
                }
                else
                {
                    Con.Open();
                    string Query = "delete from CategoryTbl where CatId=" + CatIdTb.Text + "";
                    SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted Successfuly");
                    Con.Close();
                    populate();

                    CatIdTb.Text = ""; CatNameTb.Text = ""; CatDescTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            SellerForm selleform = new SellerForm();
            this.Hide();
            selleform.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            ProductForm productform = new ProductForm();
            this.Hide();
            productform.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            this.Hide();    
            sellingForm.Show(); 
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();  
            this.Hide();    
            loginForm.Show();   
        }
    }
}

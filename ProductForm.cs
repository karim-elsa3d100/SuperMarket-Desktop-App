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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        // SQLiteConnection Con = new SQLiteConnection(@"Data Source=F:\c# projects\SuperMarket\bin\Debug\SuperMarket.Db");
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
                string Query = "select *from ProductTbl";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(Query, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
                Con.Close();
                var ds = new DataSet();
                sda.Fill(ds);
                ProdDGV.DataSource = ds.Tables[0];
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillCategorComboBox()
        {
            try
            {
                Con.Open();
                string Query = "select CatName from CategoryTbl";
                SQLiteCommand cmd = new SQLiteCommand(Query , Con);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable(); 
                dt.Columns.Add("CatName" , typeof(string));
                dt.Load(rdr);
                CatCb2.ValueMember=CatCb1.ValueMember = "CatName";
                CatCb2.DataSource=CatCb1.DataSource = dt;
                Con.Close();
            }
            catch (Exception Ex)
            { 
                MessageBox.Show(Ex.Message);    
            }
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillCategorComboBox();
            populate();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            CategoyForm Cat=new CategoyForm();
            this.Hide();
            Cat.Show(); 
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            // add button
            if (ProdIdTb.Text == "" || ProdNameTb.Text == "" || ProdPriceTb.Text == "" || ProdQtyTb.Text == "")
            {
                MessageBox.Show("Complete information to ADD product");
            }
            else
            {
                try
                {
                    Con.Open();
                    SQLiteCommand cmd1 = new SQLiteCommand("SELECT count(*) FROM ProductTbl WHERE  ProdId=" + ProdIdTb.Text + " " , Con);
                    int check=Convert.ToInt32(cmd1.ExecuteScalar());
                    if (check == 0)
                    {
                        string Query = "insert into ProductTbl values (" + ProdIdTb.Text + " , '" + ProdNameTb.Text + "' , " + ProdQtyTb.Text + " , " + ProdPriceTb.Text + " , '" + CatCb1.SelectedValue.ToString() + "')";
                        SQLiteCommand cmd2 = new SQLiteCommand(Query, Con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Product added successfuly");                      
                    }
                    else
                    {
                        MessageBox.Show("Enter Unique id");
                    }
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {                                   
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQtyTb.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPriceTb.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb1.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            this.Hide();
            sf.Show();  
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            // Delete button
           
            if(ProdIdTb.Text=="")
            {
                    MessageBox.Show("Select Product to delete it or enter the product id");
            }
            else
            {
                 try
                 {
                    Con.Open();
                    string Query = "delete from ProductTbl where ProdId=" + ProdIdTb.Text + "";
                    SQLiteCommand cmd = new SQLiteCommand(Query,Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Product deleted Successfuly");
                    populate();

                    ProdIdTb.Text = ""; ProdNameTb.Text = ""; ProdQtyTb.Text = ""; ProdPriceTb.Text = "";
                 }
                 catch (Exception Ex)
                 {
                        MessageBox.Show(Ex.Message);
                 }
            }
      
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            // edit button
            if (ProdIdTb.Text == "" || ProdNameTb.Text=="" || ProdQtyTb.Text=="" || ProdPriceTb.Text=="")
            {
                MessageBox.Show("Complete the information Product to Edit it");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update ProductTbl set ProdName='"+ProdNameTb.Text+"' , ProdQty="+ProdQtyTb.Text+" , ProdPrice="+ProdPriceTb.Text+" , ProdCat='"+CatCb1.SelectedValue.ToString()+"'   where ProdId=" + ProdIdTb.Text + "";
                    SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Product edited Successfuly");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CatCb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatCb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatCb2_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

            Con.Open();
            String Query = "SELECT * FROM ProductTbl WHERE ProdCat='" + CatCb2.SelectedValue.ToString() + "' ";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(Query, Con);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show(); 
        }
    }
}

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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        int items_in_order = 0, totalAmountOfOrder = 0;
        ///SQLiteConnection Con =new SQLiteConnection (@"Data Source=F:\c# projects\SuperMarket\bin\Debug\SuperMarket.Db");
        SQLiteConnection Con = new SQLiteConnection(@"Data Source=bin\Debug\SuperMarket.Db");
        private void FillCategorComboBox()
        {
            try
            {
                Con.Open();
                string Query = "select CatName from CategoryTbl";
                SQLiteCommand cmd = new SQLiteCommand(Query, Con);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                dt.Load(rdr);
                CatCb1.ValueMember = "CatName";
                CatCb1.DataSource = dt;
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void populate()
        {
            try
            {
                Con.Open();
                string Query = "select ProdName, ProdQty, ProdPrice from ProductTbl";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(Query, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProdDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void populate_prev_orders()
        {
            try
            {
                Con.Open();
                string Query = "select BillID, SellerName, Date, Total from BillTbl";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(Query, Con);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                SellingBillsDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            DateLbl_paint();
            FillCategorComboBox();
            populate_prev_orders();
            SellingSellerNameTb.Text = LoginForm.SellerName;
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            SellingNameTb.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellingPriceTb.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DateLbl_paint()
        {
            DateLbl.Text=DateTime.Today.Day.ToString() +"/"+ DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            //(Add button) 
            if (SellingSellerNameTb.Text == "" || SellingBillIdTb.Text == "")
            {
                MessageBox.Show("Enter Seller Name and Bill id to add this bill");
            }
            else
            {
                try
                {
                    Con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT count(*) From BillTbl WHERE BillId=" + SellingBillIdTb.Text + "", Con);
                    int Check = Convert.ToInt32(cmd.ExecuteScalar());
                    if (Check == 0)
                    {
                        string Query = "insert into BillTbl values (" + SellingBillIdTb.Text + " , '" + SellingSellerNameTb.Text + "' , '" + DateLbl.Text + "' , " + AmountLbl.Text + " )";
                        SQLiteCommand cmd2 = new SQLiteCommand(Query, Con);
                        cmd2 = new SQLiteCommand(Query, Con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Order added successfuly");                     
                        items_in_order = 0;
                        totalAmountOfOrder = 0;
                        AmountLbl.Text = "Rs";
                        OrderDGV.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Enter unique id");
                    }
                    Con.Close();
                    populate_prev_orders();
                   // SellingNameTb.Text = "";  SellingBillIdTb.Text = ""; SellingPriceTb.Text = "";SellingQtyTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }
            }
        }

        private void SellingPrintBt_Click(object sender, EventArgs e)
        {
            //Print Button
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("*******  YOUR SUPER MARKET ********", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(130));
            e.Graphics.DrawString("Bill id :  " + SellingBillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString("Seller Name :  " + SellingBillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(130, 200));
            e.Graphics.DrawString("Date of Bill :  " + SellingBillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(130, 250));
            e.Graphics.DrawString("Total Amount of Bill in LE :  " + SellingBillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(130, 300));
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            //Search button
            Con.Open();
            String Query = "SELECT ProdName , ProdQty , ProdPrice FROM ProductTbl WHERE ProdCat='" + CatCb1.SelectedValue.ToString() + "' ";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(Query, Con);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CatCb1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog(); 
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {      
            //(Add to bill) button
            if(SellingNameTb.Text=="" || SellingPriceTb.Text=="" || SellingQtyTb.Text=="" )
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(OrderDGV);
                newrow.Cells[0].Value = ++items_in_order;
                newrow.Cells[1].Value = SellingNameTb.Text;
                newrow.Cells[2].Value = SellingPriceTb.Text;
                newrow.Cells[3].Value = SellingQtyTb.Text;
                newrow.Cells[4].Value = Convert.ToInt32(SellingPriceTb.Text) * Convert.ToInt32(SellingQtyTb.Text);
                totalAmountOfOrder += Convert.ToInt32(SellingPriceTb.Text) * Convert.ToInt32(SellingQtyTb.Text);
                OrderDGV.Rows.Add(newrow);
                AmountLbl.Text = Convert.ToString(totalAmountOfOrder);

                SellingPriceTb.Text = "";SellingNameTb.Text = ""; SellingQtyTb.Text = "";
            }          
        }
    }
}

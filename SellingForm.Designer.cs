namespace SuperMarket
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.button4 = new System.Windows.Forms.Button();
            this.ProdDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.SellingPrintBt = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SellingBillIdTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SellingPriceTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SellingQtyTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SellingNameTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.label7 = new System.Windows.Forms.Label();
            this.CatCb1 = new Guna.UI.WinForms.GunaComboBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.SellingSellerNameTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.SellerNameLbl = new System.Windows.Forms.Label();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.SellingBillsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.OrderDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingBillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(1437, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 45);
            this.button4.TabIndex = 30;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ProdDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.ProdDGV.EnableHeadersVisualStyles = false;
            this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.Location = new System.Drawing.Point(16, 419);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersVisible = false;
            this.ProdDGV.RowHeadersWidth = 51;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(466, 434);
            this.ProdDGV.TabIndex = 26;
            this.ProdDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ProdDGV.ThemeStyle.ReadOnly = false;
            this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDGV.ThemeStyle.RowsStyle.Height = 30;
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.White;
            this.gunaButton3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton3.BorderSize = 3;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(1339, 811);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 15;
            this.gunaButton3.Size = new System.Drawing.Size(127, 42);
            this.gunaButton3.TabIndex = 25;
            this.gunaButton3.Text = "Logout";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // SellingPrintBt
            // 
            this.SellingPrintBt.AnimationHoverSpeed = 0.07F;
            this.SellingPrintBt.AnimationSpeed = 0.03F;
            this.SellingPrintBt.BackColor = System.Drawing.Color.Transparent;
            this.SellingPrintBt.BaseColor = System.Drawing.Color.White;
            this.SellingPrintBt.BorderColor = System.Drawing.Color.White;
            this.SellingPrintBt.BorderSize = 2;
            this.SellingPrintBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SellingPrintBt.FocusedColor = System.Drawing.Color.Empty;
            this.SellingPrintBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPrintBt.ForeColor = System.Drawing.Color.DarkOrange;
            this.SellingPrintBt.Image = null;
            this.SellingPrintBt.ImageSize = new System.Drawing.Size(20, 20);
            this.SellingPrintBt.Location = new System.Drawing.Point(926, 811);
            this.SellingPrintBt.Name = "SellingPrintBt";
            this.SellingPrintBt.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.SellingPrintBt.OnHoverBorderColor = System.Drawing.Color.White;
            this.SellingPrintBt.OnHoverForeColor = System.Drawing.Color.White;
            this.SellingPrintBt.OnHoverImage = null;
            this.SellingPrintBt.OnPressedColor = System.Drawing.Color.Black;
            this.SellingPrintBt.Radius = 10;
            this.SellingPrintBt.Size = new System.Drawing.Size(110, 42);
            this.SellingPrintBt.TabIndex = 24;
            this.SellingPrintBt.Text = "PRINT";
            this.SellingPrintBt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SellingPrintBt.Click += new System.EventHandler(this.SellingPrintBt_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(545, 811);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(110, 42);
            this.gunaButton1.TabIndex = 23;
            this.gunaButton1.Text = "ADD";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(650, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELLING";
            // 
            // SellingBillIdTb
            // 
            this.SellingBillIdTb.BackColor = System.Drawing.Color.DarkOrange;
            this.SellingBillIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingBillIdTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.SellingBillIdTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingBillIdTb.ForeColor = System.Drawing.Color.White;
            this.SellingBillIdTb.LineColor = System.Drawing.Color.White;
            this.SellingBillIdTb.Location = new System.Drawing.Point(140, 59);
            this.SellingBillIdTb.Name = "SellingBillIdTb";
            this.SellingBillIdTb.PasswordChar = '\0';
            this.SellingBillIdTb.SelectedText = "";
            this.SellingBillIdTb.Size = new System.Drawing.Size(264, 42);
            this.SellingBillIdTb.TabIndex = 38;
            this.SellingBillIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SellingBillIdTb.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Bill Id";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SellingPriceTb
            // 
            this.SellingPriceTb.BackColor = System.Drawing.Color.DarkOrange;
            this.SellingPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingPriceTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.SellingPriceTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPriceTb.ForeColor = System.Drawing.Color.White;
            this.SellingPriceTb.LineColor = System.Drawing.Color.White;
            this.SellingPriceTb.Location = new System.Drawing.Point(149, 196);
            this.SellingPriceTb.Name = "SellingPriceTb";
            this.SellingPriceTb.PasswordChar = '\0';
            this.SellingPriceTb.SelectedText = "";
            this.SellingPriceTb.Size = new System.Drawing.Size(264, 42);
            this.SellingPriceTb.TabIndex = 36;
            this.SellingPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Price";
            // 
            // SellingQtyTb
            // 
            this.SellingQtyTb.BackColor = System.Drawing.Color.DarkOrange;
            this.SellingQtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingQtyTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.SellingQtyTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingQtyTb.ForeColor = System.Drawing.Color.White;
            this.SellingQtyTb.LineColor = System.Drawing.Color.White;
            this.SellingQtyTb.Location = new System.Drawing.Point(149, 248);
            this.SellingQtyTb.Name = "SellingQtyTb";
            this.SellingQtyTb.PasswordChar = '\0';
            this.SellingQtyTb.SelectedText = "";
            this.SellingQtyTb.Size = new System.Drawing.Size(264, 42);
            this.SellingQtyTb.TabIndex = 34;
            this.SellingQtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Quantity";
            // 
            // SellingNameTb
            // 
            this.SellingNameTb.BackColor = System.Drawing.Color.DarkOrange;
            this.SellingNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingNameTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.SellingNameTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingNameTb.ForeColor = System.Drawing.Color.White;
            this.SellingNameTb.LineColor = System.Drawing.Color.White;
            this.SellingNameTb.Location = new System.Drawing.Point(149, 141);
            this.SellingNameTb.Name = "SellingNameTb";
            this.SellingNameTb.PasswordChar = '\0';
            this.SellingNameTb.SelectedText = "";
            this.SellingNameTb.Size = new System.Drawing.Size(264, 42);
            this.SellingNameTb.TabIndex = 32;
            this.SellingNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "ProdName";
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.White;
            this.gunaButton4.BorderColor = System.Drawing.Color.White;
            this.gunaButton4.BorderSize = 2;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(292, 384);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 10;
            this.gunaButton4.Size = new System.Drawing.Size(116, 29);
            this.gunaButton4.TabIndex = 41;
            this.gunaButton4.Text = "SEARCH";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Select Category";
            // 
            // CatCb1
            // 
            this.CatCb1.BackColor = System.Drawing.Color.Transparent;
            this.CatCb1.BaseColor = System.Drawing.Color.White;
            this.CatCb1.BorderColor = System.Drawing.Color.DarkOrange;
            this.CatCb1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CatCb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatCb1.FocusedColor = System.Drawing.Color.Empty;
            this.CatCb1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CatCb1.FormattingEnabled = true;
            this.CatCb1.Items.AddRange(new object[] {
            "None"});
            this.CatCb1.Location = new System.Drawing.Point(16, 384);
            this.CatCb1.Name = "CatCb1";
            this.CatCb1.OnHoverItemBaseColor = System.Drawing.Color.DodgerBlue;
            this.CatCb1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CatCb1.Radius = 10;
            this.CatCb1.Size = new System.Drawing.Size(236, 29);
            this.CatCb1.TabIndex = 39;
            this.CatCb1.SelectionChangeCommitted += new System.EventHandler(this.CatCb1_SelectionChangeCommitted);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(1094, 19);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(262, 35);
            this.DateLbl.TabIndex = 42;
            this.DateLbl.Text = "Day/Month/Year";
            this.DateLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // SellingSellerNameTb
            // 
            this.SellingSellerNameTb.BackColor = System.Drawing.Color.DarkOrange;
            this.SellingSellerNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingSellerNameTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.SellingSellerNameTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingSellerNameTb.ForeColor = System.Drawing.Color.White;
            this.SellingSellerNameTb.LineColor = System.Drawing.Color.White;
            this.SellingSellerNameTb.Location = new System.Drawing.Point(140, 8);
            this.SellingSellerNameTb.Name = "SellingSellerNameTb";
            this.SellingSellerNameTb.PasswordChar = '\0';
            this.SellingSellerNameTb.SelectedText = "";
            this.SellingSellerNameTb.Size = new System.Drawing.Size(264, 42);
            this.SellingSellerNameTb.TabIndex = 44;
            this.SellingSellerNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SellerNameLbl
            // 
            this.SellerNameLbl.AutoSize = true;
            this.SellerNameLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameLbl.ForeColor = System.Drawing.Color.White;
            this.SellerNameLbl.Location = new System.Drawing.Point(7, 25);
            this.SellerNameLbl.Name = "SellerNameLbl";
            this.SellerNameLbl.Size = new System.Drawing.Size(74, 29);
            this.SellerNameLbl.TabIndex = 43;
            this.SellerNameLbl.Text = "Seller";
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton5.BorderColor = System.Drawing.Color.White;
            this.gunaButton5.BorderSize = 2;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(137, 315);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 10;
            this.gunaButton5.Size = new System.Drawing.Size(181, 42);
            this.gunaButton5.TabIndex = 45;
            this.gunaButton5.Text = "Add to Bill";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // SellingBillsDGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.SellingBillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.SellingBillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellingBillsDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellingBillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellingBillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellingBillsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellingBillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.SellingBillsDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellingBillsDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.SellingBillsDGV.EnableHeadersVisualStyles = false;
            this.SellingBillsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellingBillsDGV.Location = new System.Drawing.Point(545, 477);
            this.SellingBillsDGV.Name = "SellingBillsDGV";
            this.SellingBillsDGV.RowHeadersVisible = false;
            this.SellingBillsDGV.RowHeadersWidth = 51;
            this.SellingBillsDGV.RowTemplate.Height = 30;
            this.SellingBillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellingBillsDGV.Size = new System.Drawing.Size(921, 328);
            this.SellingBillsDGV.TabIndex = 46;
            this.SellingBillsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.SellingBillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellingBillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellingBillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellingBillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellingBillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellingBillsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellingBillsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellingBillsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.SellingBillsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellingBillsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingBillsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellingBillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellingBillsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.SellingBillsDGV.ThemeStyle.ReadOnly = false;
            this.SellingBillsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellingBillsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellingBillsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SellingBillsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellingBillsDGV.ThemeStyle.RowsStyle.Height = 30;
            this.SellingBillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellingBillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // OrderDGV
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.OrderDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.OrderDGV.ColumnHeadersHeight = 30;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.OrderDGV.EnableHeadersVisualStyles = false;
            this.OrderDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.Location = new System.Drawing.Point(545, 114);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersVisible = false;
            this.OrderDGV.RowHeadersWidth = 51;
            this.OrderDGV.RowTemplate.Height = 30;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(921, 279);
            this.OrderDGV.TabIndex = 47;
            this.OrderDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.OrderDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.OrderDGV.ThemeStyle.ReadOnly = false;
            this.OrderDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderDGV.ThemeStyle.RowsStyle.Height = 30;
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // PName
            // 
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(887, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 38);
            this.label2.TabIndex = 48;
            this.label2.Text = "SELLS LIST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1246, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 38);
            this.label3.TabIndex = 49;
            this.label3.Text = "Amount:";
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLbl.ForeColor = System.Drawing.Color.White;
            this.AmountLbl.Location = new System.Drawing.Point(1403, 396);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(47, 38);
            this.AmountLbl.TabIndex = 50;
            this.AmountLbl.Text = "Rs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(887, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 38);
            this.label4.TabIndex = 51;
            this.label4.Text = "Items of Order";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1495, 857);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderDGV);
            this.Controls.Add(this.SellingBillsDGV);
            this.Controls.Add(this.gunaButton5);
            this.Controls.Add(this.SellingSellerNameTb);
            this.Controls.Add(this.SellerNameLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CatCb1);
            this.Controls.Add(this.SellingBillIdTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SellingPriceTb);
            this.Controls.Add(this.ProdDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.SellingQtyTb);
            this.Controls.Add(this.SellingPrintBt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.SellingNameTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingBillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaDataGridView ProdDGV;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton SellingPrintBt;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox SellingBillIdTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLineTextBox SellingPriceTb;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaLineTextBox SellingQtyTb;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaLineTextBox SellingNameTb;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox CatCb1;
        private System.Windows.Forms.Label DateLbl;
        private Guna.UI.WinForms.GunaLineTextBox SellingSellerNameTb;
        private System.Windows.Forms.Label SellerNameLbl;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaDataGridView SellingBillsDGV;
        private Guna.UI.WinForms.GunaDataGridView OrderDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
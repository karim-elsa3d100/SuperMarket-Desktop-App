namespace SuperMarket
{
    partial class CategoyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CatDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.CatIdTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CatDescTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CatNameTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton7 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.button4 = new System.Windows.Forms.Button();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.gunaButton3);
            this.panel1.Controls.Add(this.gunaButton2);
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.CatIdTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CatDescTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CatNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(188, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 696);
            this.panel1.TabIndex = 2;
            // 
            // CatDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatDGV.BackgroundColor = System.Drawing.Color.White;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CatDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CatDGV.EnableHeadersVisualStyles = false;
            this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.Location = new System.Drawing.Point(401, 116);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersVisible = false;
            this.CatDGV.RowHeadersWidth = 51;
            this.CatDGV.RowTemplate.Height = 24;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(897, 465);
            this.CatDGV.TabIndex = 26;
            this.CatDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.CatDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.CatDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CatDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CatDGV.ThemeStyle.ReadOnly = false;
            this.CatDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CatDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CatDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.White;
            this.gunaButton3.BorderColor = System.Drawing.Color.White;
            this.gunaButton3.BorderSize = 2;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(255, 402);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 10;
            this.gunaButton3.Size = new System.Drawing.Size(101, 42);
            this.gunaButton3.TabIndex = 25;
            this.gunaButton3.Text = "EDIT";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.White;
            this.gunaButton2.BorderColor = System.Drawing.Color.White;
            this.gunaButton2.BorderSize = 2;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(134, 402);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(92, 42);
            this.gunaButton2.TabIndex = 24;
            this.gunaButton2.Text = "DELETE";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
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
            this.gunaButton1.Location = new System.Drawing.Point(10, 402);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(92, 42);
            this.gunaButton1.TabIndex = 23;
            this.gunaButton1.Text = "ADD";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // CatIdTb
            // 
            this.CatIdTb.BackColor = System.Drawing.Color.DarkOrange;
            this.CatIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIdTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.CatIdTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTb.ForeColor = System.Drawing.Color.White;
            this.CatIdTb.LineColor = System.Drawing.Color.White;
            this.CatIdTb.Location = new System.Drawing.Point(165, 123);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.PasswordChar = '\0';
            this.CatIdTb.SelectedText = "";
            this.CatIdTb.Size = new System.Drawing.Size(222, 42);
            this.CatIdTb.TabIndex = 16;
            this.CatIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // CatDescTb
            // 
            this.CatDescTb.BackColor = System.Drawing.Color.DarkOrange;
            this.CatDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatDescTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.CatDescTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTb.ForeColor = System.Drawing.Color.White;
            this.CatDescTb.LineColor = System.Drawing.Color.White;
            this.CatDescTb.Location = new System.Drawing.Point(165, 259);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.PasswordChar = '\0';
            this.CatDescTb.SelectedText = "";
            this.CatDescTb.Size = new System.Drawing.Size(222, 42);
            this.CatDescTb.TabIndex = 12;
            this.CatDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            // 
            // CatNameTb
            // 
            this.CatNameTb.BackColor = System.Drawing.Color.DarkOrange;
            this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTb.FocusedLineColor = System.Drawing.Color.WhiteSmoke;
            this.CatNameTb.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.ForeColor = System.Drawing.Color.White;
            this.CatNameTb.LineColor = System.Drawing.Color.White;
            this.CatNameTb.Location = new System.Drawing.Point(165, 189);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.PasswordChar = '\0';
            this.CatNameTb.SelectedText = "";
            this.CatNameTb.Size = new System.Drawing.Size(222, 42);
            this.CatNameTb.TabIndex = 10;
            this.CatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(498, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "MANAGE CATEGORIES";
            // 
            // gunaButton7
            // 
            this.gunaButton7.AnimationHoverSpeed = 0.07F;
            this.gunaButton7.AnimationSpeed = 0.03F;
            this.gunaButton7.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton7.BaseColor = System.Drawing.Color.White;
            this.gunaButton7.BorderColor = System.Drawing.Color.White;
            this.gunaButton7.BorderSize = 2;
            this.gunaButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton7.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton7.Image = null;
            this.gunaButton7.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton7.Location = new System.Drawing.Point(29, 359);
            this.gunaButton7.Name = "gunaButton7";
            this.gunaButton7.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton7.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton7.OnHoverImage = null;
            this.gunaButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton7.Radius = 10;
            this.gunaButton7.Size = new System.Drawing.Size(140, 42);
            this.gunaButton7.TabIndex = 35;
            this.gunaButton7.Text = "Selling";
            this.gunaButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton7.Click += new System.EventHandler(this.gunaButton7_Click);
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.White;
            this.gunaButton6.BorderColor = System.Drawing.Color.White;
            this.gunaButton6.BorderSize = 2;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton6.Image = null;
            this.gunaButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton6.Location = new System.Drawing.Point(29, 276);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 10;
            this.gunaButton6.Size = new System.Drawing.Size(140, 42);
            this.gunaButton6.TabIndex = 34;
            this.gunaButton6.Text = "Product";
            this.gunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton6.Click += new System.EventHandler(this.gunaButton6_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.White;
            this.gunaButton5.BorderColor = System.Drawing.Color.White;
            this.gunaButton5.BorderSize = 2;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(29, 196);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 10;
            this.gunaButton5.Size = new System.Drawing.Size(134, 42);
            this.gunaButton5.TabIndex = 33;
            this.gunaButton5.Text = "Seller";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(1441, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 45);
            this.button4.TabIndex = 36;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.White;
            this.gunaButton4.BorderColor = System.Drawing.Color.DarkOrange;
            this.gunaButton4.BorderSize = 3;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(29, 703);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 15;
            this.gunaButton4.Size = new System.Drawing.Size(108, 42);
            this.gunaButton4.TabIndex = 37;
            this.gunaButton4.Text = "Logout";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // CategoyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1502, 760);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gunaButton7);
            this.Controls.Add(this.gunaButton6);
            this.Controls.Add(this.gunaButton5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoyForm";
            this.Load += new System.EventHandler(this.CategoyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView CatDGV;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLineTextBox CatIdTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox CatDescTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox CatNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton7;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaButton gunaButton4;
    }
}
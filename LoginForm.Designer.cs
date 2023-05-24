namespace SuperMarket
{
    partial class LoginForm
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
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.UserNameTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.SelectRole = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.White;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.DarkOrange;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(-273, -36);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(559, 559);
            this.gunaCircleButton1.TabIndex = 1;
            // 
            // UserNameTb
            // 
            this.UserNameTb.BackColor = System.Drawing.Color.White;
            this.UserNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTb.FocusedLineColor = System.Drawing.Color.DodgerBlue;
            this.UserNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UserNameTb.LineColor = System.Drawing.Color.DarkOrange;
            this.UserNameTb.Location = new System.Drawing.Point(503, 217);
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.PasswordChar = '\0';
            this.UserNameTb.SelectedText = "";
            this.UserNameTb.Size = new System.Drawing.Size(222, 42);
            this.UserNameTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(436, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(358, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "Super Market";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(318, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(330, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.BackColor = System.Drawing.Color.White;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.FocusedLineColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTb.LineColor = System.Drawing.Color.DarkOrange;
            this.PasswordTb.Location = new System.Drawing.Point(504, 281);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '●';
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.Size = new System.Drawing.Size(222, 42);
            this.PasswordTb.TabIndex = 8;
            this.PasswordTb.UseSystemPasswordChar = true;
            // 
            // SelectRole
            // 
            this.SelectRole.BackColor = System.Drawing.Color.Transparent;
            this.SelectRole.BaseColor = System.Drawing.Color.White;
            this.SelectRole.BorderColor = System.Drawing.Color.DarkOrange;
            this.SelectRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectRole.FocusedColor = System.Drawing.Color.Empty;
            this.SelectRole.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRole.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectRole.FormattingEnabled = true;
            this.SelectRole.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.SelectRole.Location = new System.Drawing.Point(368, 159);
            this.SelectRole.Name = "SelectRole";
            this.SelectRole.OnHoverItemBaseColor = System.Drawing.Color.DodgerBlue;
            this.SelectRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.SelectRole.Radius = 10;
            this.SelectRole.Size = new System.Drawing.Size(249, 37);
            this.SelectRole.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(431, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select Role";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.DarkOrange;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(389, 375);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(182, 48);
            this.gunaButton1.TabIndex = 11;
            this.gunaButton1.Text = "LOGIN";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(429, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Clear";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "SUPER MARKET";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkOrange;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 39);
            this.label8.TabIndex = 14;
            this.label8.Text = "WELCOME TO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkOrange;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 39);
            this.label9.TabIndex = 15;
            this.label9.Text = "APPLICATION";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(723, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 45);
            this.button4.TabIndex = 16;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 479);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectRole);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameTb);
            this.Controls.Add(this.gunaCircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaLineTextBox UserNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox PasswordTb;
        private Guna.UI.WinForms.GunaComboBox SelectRole;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
    }
}


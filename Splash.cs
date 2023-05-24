using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            ProgressBar.Value = startpoint;
            if(ProgressBar.Value==100)
            {
                ProgressBar.Value = 0;
                timer1.Stop();  
                LoginForm form= new LoginForm();
                form.Show();
                this.Hide(); 
            }

        }
    }
}

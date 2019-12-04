using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ballfurious
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }
        int abuot1 = 1;
        int help1 = 1;
       public help(int a,int b)
       {
           this.help1 = a;
           this.abuot1 = b;
       }
        private void help_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            label1.Text = "help = " + help1 + "about = "+abuot1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start f1 = new start();
            f1.Show();
        }
    }
}

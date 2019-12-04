using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace ballfurious
{
    public partial class Form8 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        int s;
        public Form8(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Hide();
            Form1 f1 = new Form1(s);
            f1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f1 = new Form2(s);
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f1 = new Form3(s);
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 f1 = new Form4(s);
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            game f1 = new game(s);
            f1.Show();

        }


    }
}

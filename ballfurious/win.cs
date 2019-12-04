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
    public partial class win : Form
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
        public win(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        int i = 0;
        private void win_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 25)
            {
                timer1.Stop();
                this.Hide();
                Form8 f1 = new Form8(s);
                f1.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class lose : Form
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
        public lose(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        int i = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void lose_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            i++;
            if (i == 25)
            {
                this.Hide();
                lose f3 = new lose(s);
                f3.Close();
                player.Stop();
                timer1.Stop();
                this.Hide();
                Form8 f1 = new Form8(s);
                f1.Show();

            }
        }
    }
}

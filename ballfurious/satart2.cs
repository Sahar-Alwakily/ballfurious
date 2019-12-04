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
    public partial class satart2 : Form
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
        int _s;
        public satart2(int so)
        {
            this._s = so;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f = new Form10(_s);
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            game f = new game(_s);
            f.Show();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void satart2_Load(object sender, EventArgs e)
        {
           
            if (_s == 1)
            {

                player.SoundLocation = "music\\4.wav";
                player.Play();

            }
            else
                player.Stop();
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start f = new start();
            f.Show();
        }
    }
}

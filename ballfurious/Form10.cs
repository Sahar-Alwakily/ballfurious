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
    public partial class Form10 : Form
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
        public Form10(int _s)
        {
            this.s = _s;
            InitializeComponent();

        }
        Image img = Image.FromFile("200.gif");
        private void Form10_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                System.Media.SoundPlayer play = new System.Media.SoundPlayer();
                play.SoundLocation = "music\\5.wav";
                play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.Hide();
            english f = new english(s);
            f.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            this.Hide();
            english2 f = new english2(1);
            f.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            this.Hide();
            maht f = new maht(s);
            f.Show();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            this.Hide();
            million f = new million(s);
            f.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5(s);
            f.Show();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            this.Hide();
            hangman f = new hangman(s);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            satart2 f1 = new satart2(s);
            f1.Show();
        }

    }
}

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
    public partial class game : Form
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
        Image img = Image.FromFile("200.gif");
        public game(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
   
        int[] arr = new int[7] {0,0,0,0,0,0,0} ;
        int a;
        private void game_Load(object sender, EventArgs e)
        {
            if(s==1)
            {
            System.Media.SoundPlayer play = new System.Media.SoundPlayer();
            play.SoundLocation = "music\\4.wav";
             play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameXO f1 = new gameXO(s);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            satart2 f1 = new satart2(s);
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            peacesnacke f1 = new peacesnacke(s);
            f1.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Hide();
            mazegame f1 = new mazegame(s);
            f1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            pacman f1 = new pacman(s);
            f1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f1 = new Form8(s);
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f1 = new Form7(s);
            f1.Show();
        }

    }
}

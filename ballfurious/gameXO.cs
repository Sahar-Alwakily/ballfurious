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
    public partial class gameXO : Form
    {
        enum gametybe { X, O };
        gametybe CURRENT_GT = gametybe.X;
        int played_games = 0;
        int cX = 0;
        int cO = 0;
        Button[,] btnS = new Button[3, 3];
        int s;
        public gameXO(int _s)
        {
            this.s = _s;
            InitializeComponent();
            btnS[0, 0] = btn00; btnS[0, 1] = btn01; btnS[0, 2] = btn02;
            btnS[1, 0] = btn10; btnS[1, 1] = btn11; btnS[1, 2] = btn12;
            btnS[2, 0] = btn20; btnS[2, 1] = btn21; btnS[2, 2] = btn22;

            foreach (Button btn in btnS) btn.Click += new EventHandler(btn_click);// تحكم في كل بوتن مرة وحده وكل مره تدخل في داله btn_click
        }
        void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "") return;
            played_games++;
            btn.Text = CURRENT_GT.ToString();
            if (IsWin())
            {
                if (CURRENT_GT == gametybe.X)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    cX++;
                    label1.Text = "Selfster-X = " + cX;

                }
                if (CURRENT_GT == gametybe.O)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    cO++;
                    label2.Text = "Tweety-O = " + cO;
                }
                newgame();

            }
            if (played_games == 9)
            {
                pictureBox7.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                newgame();
            }
            switchgame();
        }
        void newgame()// لعبه جديده
        {
            foreach (Button btn in btnS) btn.Text = "";
            played_games = 0;
        }
        void switchgame()// مين ورا ثاني
        {
            if (CURRENT_GT == gametybe.X) CURRENT_GT = gametybe.O;
            else CURRENT_GT = gametybe.X;
        }
        bool IsWin()// ادا ربح
        {
            for (int i = 0; i <= 2; i++)
            {
                if (btnS[0, i].Text == CURRENT_GT.ToString() &&
                    btnS[0, i].Text == btnS[1, i].Text &&
                    btnS[1, i].Text == btnS[2, i].Text)
                    return true;
                if (btnS[i, 0].Text == CURRENT_GT.ToString() &&
                    btnS[i, 0].Text == btnS[i, 1].Text &&
                    btnS[i, 1].Text == btnS[i, 2].Text)
                    return true;
            }
            if (btnS[0, 0].Text == CURRENT_GT.ToString() &&
                    btnS[0, 0].Text == btnS[1, 1].Text &&
                    btnS[1, 1].Text == btnS[2, 2].Text)
                return true;
            if (btnS[2, 0].Text == CURRENT_GT.ToString() &&
                    btnS[2, 0].Text == btnS[1, 1].Text &&
                    btnS[1, 1].Text == btnS[0, 2].Text)
                return true;
            return false;


        }
        private void gameXO_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                System.Media.SoundPlayer play = new System.Media.SoundPlayer();
                play.SoundLocation = "music\\4.wav";
                play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox7.Visible = false;
            if (CURRENT_GT == gametybe.X)
                label3.Text = "X";
            else
                label3.Text = "O";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            game f1 = new game(s);
            f1.Show();
        }


    }
}

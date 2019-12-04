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
    public partial class Form3 : Form
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
        public Form3(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        int n = 300;

        int flag, flag2, i = 0, flag3;
        private void timermain_Tick(object sender, EventArgs e)
        {
            player.Location = Control.MousePosition;
            player.Top = player.Top - 20;
            if (player.Bounds.IntersectsWith(p1.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p2.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
              
            }
            if (player.Bounds.IntersectsWith(p3.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
             
            }
            if (player.Bounds.IntersectsWith(p4.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p5.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
           
            }
            if (player.Bounds.IntersectsWith(p6.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p7.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
             
            }
            if (player.Bounds.IntersectsWith(p8.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
            }
            if (player.Bounds.IntersectsWith(p9.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p10.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p11.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
             
            }
            if (player.Bounds.IntersectsWith(p12.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
              
            }
            if (player.Bounds.IntersectsWith(p13.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p15.Bounds))
            {
                play.Stop();
                timer2.Stop();
                this.Hide();
                win f1 = new win(s);
                f1.Show();
                timermain.Enabled = false;
            }
            if (player.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
      
            }

            if (player.Bounds.IntersectsWith(pp.Bounds))
            {
                flag3 = 1;

            }
        }

        private void player_Click(object sender, EventArgs e)
        {
            timermain.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Bounds.IntersectsWith(p3.Bounds))
            {
                flag = 0;
            }
            if (pictureBox2.Bounds.IntersectsWith(p3.Bounds))
            {
                flag2 = 0;
            }
            if (pictureBox1.Bounds.IntersectsWith(p4.Bounds))
            {

                flag = 1;
            }
            if (pictureBox2.Bounds.IntersectsWith(p4.Bounds))
            {
                flag2 = 1;
            }
            if (flag == 1)
            {
                pictureBox1.Left -= 10;
            }
            else { pictureBox1.Left += 10; }
            if (flag2 == 1)
            {
                pictureBox2.Left -= 10;
            }
            else { pictureBox2.Left += 10; }

            i++;
            if (i % 2 == 0)
            {
                pp.Visible = false;


            }
            else
            {

                pp.Visible = true;
            }
            if (flag3 == 1)
            {
                player.Top = 35;
                player.Left = 678;
                timermain.Enabled = false;
                flag3 = 0;
            }
        }
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        private void Form3_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                play.SoundLocation = "music\\4.wav";
                play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = "" + (n--);
            if (n == 0)
            {
                play.Stop();
                this.Hide();
                lose f1 = new lose(s);

                f1.Show();
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            play.Stop();
            timer1.Stop();
            timer2.Stop();
            timermain.Stop(); 
            this.Hide();
            Form8 f1 = new Form8(s);
            f1.Show();
        }


    }
}

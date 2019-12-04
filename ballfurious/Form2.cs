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
    public partial class Form2 : Form
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
        public Form2(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        int  n = 200;

        private void timermain_Tick(object sender, EventArgs e)
        {
            player.Location = Control.MousePosition;
            player.Top = player.Top - 20;
            if (player.Bounds.IntersectsWith(p1.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p2.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
           
            }
            if (player.Bounds.IntersectsWith(p3.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p4.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p5.Bounds))
            {
                player.Top = 31;
                player.Left = 361;
                timermain.Enabled = false;
              
            }
            if (player.Bounds.IntersectsWith(p6.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p7.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p8.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p9.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p10.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p11.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p12.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
              
            }
            if (player.Bounds.IntersectsWith(p13.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p14.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
              
            }
            if (player.Bounds.IntersectsWith(p15.Bounds))
            {
                player.Top = 31;
                player.Left = 361;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p16.Bounds))
            {
                player.Top = 31;
                player.Left = 361;
                timermain.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p17.Bounds))
            {
                player.Top = 40;
                player.Left = 361;
                timermain.Enabled = false;
               
            }

            if (player.Bounds.IntersectsWith(pp.Bounds))
            {
                play.Stop();
                timer2.Stop();
                this.Hide();
                win f1 = new win(s);
                f1.Show();
                timermain.Enabled = false;
            }


        }



        System.Media.SoundPlayer play = new System.Media.SoundPlayer();

        private void Form2_Load(object sender, EventArgs e)
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

        private void player_Click(object sender, EventArgs e)
        {
            timermain.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

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
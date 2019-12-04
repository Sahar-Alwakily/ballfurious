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
    public partial class Form1 : Form
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
        // بكل صفحات في s و _s له علاقه للصوت ادا هو 1 معناته يشتغل ادا 0 ما يشتغل 
        int s;
        public Form1(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        int i = 0, n = 120;



        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
                p6.Visible = false;
            else
                p6.Visible = true;
            i++;

            label1.Text = "" + (n--);
            if (n == 0)
            {
                play.Stop();
                this.Hide();
                lose f1 = new lose(s);
                f1.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
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

#region اذا فوطبول لمس جدران يرجع الفوطبول الى موقعه

        private void timer2_Tick(object sender, EventArgs e)
        {


            player.Location = Control.MousePosition;
            player.Top = player.Top - 20;
            if (player.Bounds.IntersectsWith(p1.Bounds))
            {
                player.Top = 42;
                player.Left = 482;
                timer2.Enabled = false;
                
            }
            if (player.Bounds.IntersectsWith(p2.Bounds))
            {
                player.Top = 42;
                player.Left = 482;
                timer2.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p3.Bounds))
            {
                player.Top = 42;
                player.Left = 482;
                timer2.Enabled = false;
              
            }
            if (player.Bounds.IntersectsWith(p4.Bounds))
            {
                player.Top = 42;
                player.Left = 482;
                timer2.Enabled = false;
             
            }
            if (player.Bounds.IntersectsWith(p5.Bounds))
            {
                player.Top = 42;
                player.Left = 482;
                timer2.Enabled = false;
               
            }
            if (player.Bounds.IntersectsWith(p6.Bounds))
            {
                player.Top = 42;
                player.Left = 482;
                timer2.Enabled = false;
             
            }

            if (player.Bounds.IntersectsWith(p15.Bounds))
            {
                play.Stop();
                timer1.Stop();
                timer2.Stop();
                timer1.Stop();
                this.Hide();
                win f1 = new win(s);
                f1.Show();
                timer2.Enabled = false;

            }
            if (player.Bounds.IntersectsWith(p7.Bounds))
            {
                player.Top = 42;
                player.Left = 482;
                timer2.Enabled = false;
                
            }

        }

#endregion
        private void player_Click_1(object sender, EventArgs e)
        {
            timer2.Enabled = true;// ادا ضغطنا راس فوطبول تشتغل التايمر من جديد
        }

        private void button1_Click(object sender, EventArgs e)// الرجوع
        {
            play.Stop(); 
            timer1.Stop();
            timer2.Stop();
            this.Hide();
            Form8 f1 = new Form8(s);
            f1.Show();
        }


  
    }
    }

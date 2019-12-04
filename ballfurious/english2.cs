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
    public partial class english2 : Form
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
        public english2(int y)
        {
            this.x = y;
            InitializeComponent();
 
        }


  
        int ii;

        Image blue = Image.FromFile("color\\blue.png");
        Image red = Image.FromFile("color\\red.png");
        Image green = Image.FromFile("color\\green.png");
        Image black = Image.FromFile("color\\black.png");
        Image pink = Image.FromFile("color\\pink.png");
        Image yellow = Image.FromFile("color\\yellow.png");




        Image a = Image.FromFile("hobabc\\a.jpg");
        Image b = Image.FromFile("hobabc\\b.jpg");
        Image c = Image.FromFile("hobabc\\c.jpg");
        Image d = Image.FromFile("hobabc\\d.jpg");
        Image h = Image.FromFile("hobabc\\h.jpg");
        Image l = Image.FromFile("hobabc\\l.jpg");
        Image m = Image.FromFile("hobabc\\m.jpg");
        Image mm = Image.FromFile("hobabc\\mm.jpg");
        Image o = Image.FromFile("hobabc\\o.jpg");
        Image r = Image.FromFile("hobabc\\r.jpg");
        Image k = Image.FromFile("hobabc\\k.jpg");
        Image sh = Image.FromFile("hobabc\\sh.jpg");
        Image i = Image.FromFile("hobabc\\i.jpg");
        Image kk = Image.FromFile("hobabc\\kk.jpg");
        Image hh = Image.FromFile("hobabc\\hh.jpg");
        int x;
        Random rnd = new Random();


        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        



        private void english2_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "music\\hes.wav";
            player.Play();
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            if (x == 7)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
               // MessageBox.Show("כל הכבוד ");
                this.Hide();
                Form10 f3 = new Form10(2);
                f3.Show();
            }
            if (x == 1)
            {
                pictureBox1.Image = blue;
                button1.Image = a;
                button2.Image = c;
                button3.Image = o;
                button4.Image = r;
                label4.Image = k;
                label3.Image = h;
                label2.Text = "";
                label1.Image = l;
                label5.Visible = false;

            }
            if (x == 2)
            {
                pictureBox1.Image = red;
                button1.Image = d;
                button2.Image = c;
                button3.Image =k ;
                button4.Image = r;
                label4.Image = a;
                label3.Text = "";
                label2.Image = o;
                label1.Image = mm;
                label5.Visible = false;
            }

            if (x == 3)
            {
                pictureBox1.Image = black;
                button1.Image = d;
                button2.Image = c;
                button3.Image = k;
                button4.Image = r;
                label4.Image = sh;
                label3.Image = h;
                label2.Image = o;
                label1.Text = "";
                label5.Visible = false;
            }


            if (x == 4)
            {
                pictureBox1.Image = pink;
                button1.Image = sh;
                button2.Image = d;
                button3.Image = k;
                button4.Image = h;
                label4.Image = o;
                label3.Image = r;
                label2.Image = o;
                label1.Text = "";
                label5.Visible = false;
            }


            if (x == 5)
            {
                pictureBox1.Image = green;
                button1.Image = sh;
                button2.Image = i;
                button3.Image = k;
                button4.Image = h;
                label4.Text = "";
                label3.Image = r;
                label2.Image = o;
                label1.Image = kk;
                label5.Visible = false;
            }
            if (x == 6)
            {
                pictureBox1.Image = yellow;
                button1.Image = a;
                button2.Image = i;
                button3.Image = k;
                button4.Image = hh;
                label4.Image = c ;
                label3.Text= "";
                label2.Image = o;
                label1.Image = b;
                label5.Visible = false;
            }



            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x == 5)
            {
                player.SoundLocation = "music\\kol.wav";
                player.Play();
                timer1.Start();
            }
            else
            if (x == 4)
            {
                player.SoundLocation = "music\\kol.wav";
                player.Play();
                timer1.Start();
            }

            else
            {
                player.SoundLocation = "music\\lo.wav";
                player.Play();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (x == 1)
            {
                player.SoundLocation = "music\\kol.wav";
                player.Play();
                timer1.Start();
            }
            else
            {
                player.SoundLocation = "music\\lo.wav";
                                player.Play();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x == 2)
            {
                player.SoundLocation = "music\\kol.wav";
                player.Play();
                timer1.Start();
            }
            else
            {
                player.SoundLocation = "music\\lo.wav";
                player.Play();
            }
        }



       private void button4_Click(object sender, EventArgs e)
        {

            if (x == 6)
            {
                player.SoundLocation = "music\\kol.wav";
                player.Play();
                timer1.Start();
            }
          else
            if (x == 4)
            {
                player.SoundLocation = "music\\kol.wav";
                player.Play();
                timer1.Start();
            }
           else
            if (x == 3)
            {
                player.SoundLocation = "music\\kol.wav";
                player.Play();
                timer1.Start();
            }

            else
            {
                player.SoundLocation = "music\\lo.wav";
                player.Play();
            }
        }

       private void timer1_Tick(object sender, EventArgs e)
       {

          
           if (x == 1)
           {

               button1.Visible = false;
               button4.Visible = false;
               button2.Visible = false;
               label2.Visible = false;
               button3.Left = 698;
               button3.Top = 374;
               timer3.Start();

           }
           if (x == 2)
           {
               button3.Visible = false;
               button4.Visible = false;
               button2.Visible = false;
               label3.Visible = false;
               button1.Left = 847; 
               button1.Top = 374;
               timer3.Start();
           }
           if (x == 3)
           {
               button1.Visible = false;
               button3.Visible = false;
               button2.Visible = false;
               label1.Visible = false;
               button4.Left = 547;
               button4.Top = 374;
               timer3.Start();
           }
           if (x == 4)
           {
               button1.Visible = false;
               button4.Visible = false;
               button3.Visible = false;
               label1.Visible = false;
               button2.Left = 547;
               button2.Top = 374;
               timer3.Start();
           }
           if (x == 5)
           {
               button1.Visible = false;
               button4.Visible = false;
               button3.Visible = false;
               label4.Visible = false;
               button2.Left = 991;
               button2.Top = 374;
               timer3.Start();


           }
           if (x == 6)
           {
               button1.Visible = false;
               button3.Visible = false;
               button2.Visible = false;
               label3.Visible = false;
               button4.Left = 847;
               button4.Top = 374;
               timer3.Start();
           }

       }

       private void timer2_Tick(object sender, EventArgs e)
       {

           button1.Visible = true;
           button2.Visible = true;
           button3.Visible = true;
           button4.Visible = true;
           label1.Visible = true;
           label2.Visible = true;
           label3.Visible = true;
           label4.Visible = true;
           timer1.Stop();
           if (x == 1)
           {
               pictureBox1.Image = blue;
               button1.Image = a;
               button2.Image = c;
               button3.Image = o;
               button4.Image = r;
               label4.Image = k;
               label3.Image = h;
               label2.Text = "";
               label1.Image = l;
               label5.Visible = false;

           }
           if (x == 2)
           {
               pictureBox1.Image = red;
               button1.Image = d;
               button2.Image = c;
               button3.Image = k;
               button4.Image = r;
               label4.Image = a;
               label3.Text = "";
               label2.Image = o;
               label1.Image = mm;
               label5.Visible = false;
           }

           if (x == 3)
           {
               pictureBox1.Image = black;
               button1.Image = d;
               button2.Image = c;
               button3.Image = k;
               button4.Image = r;
               label4.Image = sh;
               label3.Image = h;
               label2.Image = o;
               label1.Text = "";
               label5.Visible = false;
           }


           if (x == 4)
           {
               pictureBox1.Image = pink;
               button1.Image = sh;
               button2.Image = d;
               button3.Image = k;
               button4.Image = h;
               label4.Image = o;
               label3.Image = r;
               label2.Image = o;
               label1.Text = "";
               label5.Visible = false;
           }


           if (x == 5)
           {
               pictureBox1.Image = green;
               button1.Image = sh;
               button2.Image = i;
               button3.Image = k;
               button4.Image = h;
               label4.Text = "";
               label3.Image = r;
               label2.Image = o;
               label1.Image = kk;
               label5.Visible = false;
           }
           if (x == 6)
           {
               pictureBox1.Image = yellow;
               button1.Image = a;
               button2.Image = i;
               button3.Image = k;
               button4.Image = hh;
               label4.Image = c;
               label3.Text = "";
               label2.Image = o;
               label1.Image = b;
               label5.Visible = false;
           }
       }

       private void button5_Click(object sender, EventArgs e)
       {
           player.Stop();
           this.Hide();
           Form10 f1 = new Form10(0);
           f1.Show();
       }

       private void timer3_Tick(object sender, EventArgs e)
       {
           player.Stop();
               timer3.Stop();
               timer2.Stop();
               timer1.Stop();
               this.Hide();
               wincolor f1 = new wincolor(x);
               f1.Show();

       }

       private void label2_Click(object sender, EventArgs e)
       {

       }

       private void label5_Click(object sender, EventArgs e)
       {

       }

       private void label4_Click(object sender, EventArgs e)
       {

       }

    }
}

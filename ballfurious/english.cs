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
    public partial class english : Form
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
        public english(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        
        Image a = Image.FromFile("abc\\a.gif");
        Image b = Image.FromFile("abc\\b.gif");
        Image c = Image.FromFile("abc\\c.gif");
        Image d = Image.FromFile("abc\\d.gif");
        Image ee = Image.FromFile("abc\\e.gif");
        Image f = Image.FromFile("abc\\f.gif");
        Image g = Image.FromFile("abc\\g.gif");
        Image h = Image.FromFile("abc\\h.gif");
        Image i = Image.FromFile("abc\\i.gif");
        Image j = Image.FromFile("abc\\j.gif");
        Image k = Image.FromFile("abc\\k.gif");
        Image l = Image.FromFile("abc\\l.gif");
        Image no = Image.FromFile("no.gif");
        int count = 0,x,y=0;

        private void english_Load(object sender, EventArgs e)
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

#region لا يمكن ضعط اكثر من مرتين 
        private void button22_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button22.Text = "a";
                button22.Image = null;
                count++;
                x = 1;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button38.Text = "L";
                button38.Image = null; ; count++; x = 12;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button39.Text = "K";
                button39.Image = null; ; count++; x = 11;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button40.Text = "G";
                button40.Image = null; count++; x = 7;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button20.Text = "I";
                button20.Image = null; count++; x = 9;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button21.Text = "e";
                button21.Image = null; count++;
                x = 5;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button37.Text = "H";
                button37.Image = null; count++; x = 8;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button23.Text = "J";
                button23.Image = null; count++; x = 10;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button26.Text = "F";
                button26.Image = null; count++; x = 6;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button30.Text = "f";
                button30.Image = null; count++; x = 6;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button31.Text = "g";
                button31.Image = null; count++; x = 7;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button33.Text = "E";
                button33.Image = null; count++; x = 5;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button34.Text = "d"; x = 4;
                button34.Image = null; count++;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button35.Text = "b"; x = 2;
                button35.Image = null; count++;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button36.Text = "c"; x = 3;
                button36.Image = null; count++;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button17.Text = "D";
                button17.Image = null; count++; x = 4;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button16.Text = "k"; x = 11;
                button16.Image = null; count++;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button15.Text = "i"; x = 9;
                button15.Image = null; count++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button9.Text = "B";
                button9.Image = null; count++; x = 2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button7.Text = "j"; x = 10;
                button7.Image = null; count++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button6.Text = "h"; x = 8;
                button6.Image = null; count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button3.Text = "A";
                button3.Image = null; count++; x = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button2.Text = "l"; x = 12;
                button2.Image = null; count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(count == 2))
            {
                button1.Text = "C";
                button1.Image = null; count++; x = 3;
            }
        }
#endregion

        #region לבדוקת 
        private void timer1_Tick(object sender, EventArgs e)
        {

         
            
            if (count == 2)
            { 
                  switch(x)
           {
                      case 1 :
                   if ((button22.Text == "a" && button3.Text == "A"))
                          {
                                button22.Visible = false;
                                button3.Visible = false;
                                y++;
                        }
                  else
                          {
                              button38.Text = "";
                              button39.Text = "";
                              button40.Text = "";
                              button20.Text = "";
                              button37.Text = "";
                              button23.Text = "";
                              button26.Text = ""; 
                              button33.Text = "";
                              button17.Text = ""; 
                              button9.Text = "";
                              button3.Text = ""; 
                              button1.Text = "";










                          button22.Text = "";
                          button21.Text = "";
                          button30.Text = "";
                          button31.Text = "";
                          button34.Text = "";
                          button35.Text = "";
                          button36.Text = "";
                          button16.Text = "";
                          button15.Text = "";
                          button7.Text = "";
                          button6.Text = "";
                          button2.Text = "";
                          button22.Image=no;
                          button3.Image=no;    
                          button35.Image = no;
                          button9.Image = no;
                          button36.Image = no;
                          button1.Image = no;
                          button34.Image = no;
                          button17.Image = no;
                          button21.Image = no;
                          button33.Image = no;
                          button30.Image = no;
                          button26.Image = no;
                          button31.Image = no;
                          button40.Image = no;
                          button6.Image = no;
                          button37.Image = no;
                          button15.Image = no;
                          button20.Image = no;
                          button7.Image = no;
                          button23.Image = no;
                          button2.Image = no;
                          button38.Image = no;
                          button16.Image = no;
                          button39.Image = no;
                      }
                           break;
               case 2:
                           if ((button35.Text == "b" && button9.Text == "B"))
                {
                    button35.Visible = false;
                    button9.Visible = false;
                    y++;
                }

                else
                {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";




                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image=no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 3:
                if ((button36.Text == "c" && button1.Text == "C"))
                {
                    button36.Visible = false;
                    button1.Visible = false;
                    y++;
                }
                else
                {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";  


                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 4:
                if ((button34.Text == "d" && button17.Text == "D"))
                {
                    button34.Visible = false;
                    button17.Visible = false;
                    y++;
                }
                else
                {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";




                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 5:
                if ((button21.Text == "e" && button33.Text == "E"))
                {
                   

                    button21.Visible = false;
                    button33.Visible = false;
                    y++;
                }
                else {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";





                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 6:
                if ((button30.Text == "f" && button26.Text == "F"))
                {
                    button30.Visible = false;
                    button26.Visible = false;
                    y++;
                }
                else
                {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";







                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 7:
                if ((button31.Text == "g" && button40.Text == "G"))
                {
                    button31.Visible = false;
                    button40.Visible = false;
                    y++;
                }
                else {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";






                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 8:
                if ((button6.Text == "h" && button37.Text == "H"))
                {
                    button6.Visible = false;
                    button37.Visible = false;
                    y++;
                }
                else {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";







                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 9:
                if ((button15.Text == "i" && button20.Text == "I"))
                {
                    button15.Visible = false;
                    button20.Visible = false;
                    y++;
                }
                else {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";






                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 10:
                if ((button7.Text == "j" && button23.Text == "J"))
                {
                    button7.Visible = false;
                    button23.Visible = false;
                    y++;
                }
                else {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";






                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 11:
                if ((button16.Text == "k" && button39.Text == "K"))
                {
                    button16.Visible = false;
                    button39.Visible = false;
                    y++;
                }
                else {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";





                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
                      case 12:
                if ((button2.Text == "l" && button38.Text == "L"))
                {
                    button2.Visible = false;
                    button38.Visible = false;
                    y++;
                }
                else {
                    button38.Text = "";
                    button39.Text = "";
                    button40.Text = "";
                    button20.Text = "";
                    button37.Text = "";
                    button23.Text = "";
                    button26.Text = "";
                    button33.Text = "";
                    button17.Text = "";
                    button9.Text = "";
                    button3.Text = "";
                    button1.Text = "";






                    button22.Text = "";
                    button21.Text = "";
                    button30.Text = "";
                    button31.Text = "";
                    button34.Text = "";
                    button35.Text = "";
                    button36.Text = "";
                    button16.Text = "";
                    button15.Text = "";
                    button7.Text = "";
                    button6.Text = "";
                    button2.Text = "";
                    button22.Image = no;
                    button3.Image = no;
                    button35.Image = no;
                    button9.Image = no;
                    button36.Image = no;
                    button1.Image = no;
                    button34.Image = no;
                    button17.Image = no;
                    button21.Image = no;
                    button33.Image = no;
                    button30.Image = no;
                    button26.Image = no;
                    button31.Image = no;
                    button40.Image = no;
                    button6.Image = no;
                    button37.Image = no;
                    button15.Image = no;
                    button20.Image = no;
                    button7.Image = no;
                    button23.Image = no;
                    button2.Image = no;
                    button38.Image = no;
                    button16.Image = no;
                    button39.Image = no;
                }
                break;
            }
            }
            if (count != 1)
                count = 0;
            if (y == 12)
            {
                y = 0;
                pictureBox1.Visible = true;
                timer2.Start();
            }
            
           

        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f1 = new Form10(s);
            f1.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y++;
            if (y == 25)
            {
                timer2.Stop();
                timer1.Stop();
                this.Hide();
                Form10 f2 = new Form10(s);
                f2.Show();
            }
        }
    }
}

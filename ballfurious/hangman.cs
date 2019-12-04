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
    public partial class hangman : Form
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

        int a;
        public hangman(int _s)
        {
            this.a = _s;
            InitializeComponent();
        }

     //   public virtual void Refresh();
        Image h = Image.FromFile("cp7.png");
        string[] d = new string[9];
        int n = 0, mistakes = 6, fz = 20;
        string b = null;
        string ft = null;

        Class1 s = new miss();
        Class1 s2 = new Class2();

        Random hint = new Random();//apni tarf sa Word da ga

        #region فحص ادا اخترت حرف صحيح 
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Hide();
            s.mAll(label1, button7, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Hide();
            s.mAll(label1, button14, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            {
                button23.Hide();
                s.mAll(label1, button23, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;
                label2.Text = mistakes.ToString();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Hide();
            s.mAll(label1, button19, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {

            button13.Hide();
            s.mAll(label1, button13, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Hide();
            s.mAll(label1, button10, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Hide();
            s.mAll(label1, button18, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Hide();
            s.mAll(label1, button8, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            s.mAll(label1, button9, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Hide();
            s.mAll(label1, button5, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {

            
                button12.Hide();
                s.mAll(label1, button12, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;
                label2.Text = mistakes.ToString();
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Hide();
            s.mAll(label1, button11, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
            s.mAll(label1, button4, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Hide();
            s.mAll(label1, button16, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Hide();
            s.mAll(label1, button26, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {

           
                button24.Hide();
                s.mAll(label1, button24, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;
                label2.Text = mistakes.ToString();
           
        }

        private void button20_Click(object sender, EventArgs e)
        {

          
                button20.Hide();
                s.mAll(label1, button20, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;
                label2.Text = mistakes.ToString();

         
        }

        private void button25_Click(object sender, EventArgs e)
        {

                button25.Hide();
                s.mAll(label1, button25, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;
                label2.Text = mistakes.ToString();
          
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Hide();
            s.mAll(label1, button22, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            s.mAll(label1, button3, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Hide();
            s.mAll(label1, button6, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

           
                button2.Hide();
                s.mAll(label1, button2, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;


           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Hide();
            s.mAll(label1, button15, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Hide();
            s.mAll(label1, button21, b, ft, n, d, mistakes, hint, pictureBox1);
            if (n != s.n)
            {
                s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
            }
            n = s.n;
            b = s.b;
            ft = s.ft;
            mistakes = s.mistakes;
            label2.Text = mistakes.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            {
                button17.Hide();
                s.mAll(label1, button17, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;
                label2.Text = mistakes.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

          

                button1.Hide();
                s.mAll(label1, button1, b, ft, n, d, mistakes, hint, pictureBox1);
                if (n != s.n)
                {
                    s2.m1(button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26);
                }
                n = s.n;
                b = s.b;
                ft = s.ft;
                mistakes = s.mistakes;
                label2.Text = mistakes.ToString();
          
        }
        #endregion
        private void hangman_Load(object sender, EventArgs e)
        {
            if (a == 1)
            {
                System.Media.SoundPlayer play = new System.Media.SoundPlayer();
                play.SoundLocation = "music\\5.wav";
                play.Play();
            }
            
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            {
                label1.Font = new Font(label1.Font.FontFamily.Name, fz);//size aur writing style ko change karne ka lia
                fz = 16;
                label2.Font = new Font(label2.Font.FontFamily.Name, fz);
                d[0] = "PAKISTAN";
                d[1] = "AMERICA";
                d[2] = "KOREA";
                d[3] = "ITALIA";
                d[4] = "EMIRATES";
                d[5] = "RUSSIA";
                d[6] = "BRAZIL";
                d[7] = "JORDAN";
                d[8] = "TURKEY";
                b = d[n];
                int r = hint.Next(4);
                int r1 = hint.Next(r + 1, b.Length);
                for (int i = 0; i < b.Length; i++)
                {
                    if (r == i || r1 == i)
                    {
                        ft = ft + b[i];
                    }
                    else
                    {
                        ft = ft + "*";
                    }
                }
                label1.Text = ft;
                label2.Text = mistakes.ToString();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n == 9)
                
            {

                timer1.Stop();
               DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {
                 timer1.Stop();
                 this.Hide();
                 hangman f1 = new hangman(a);
                 f1.Show();
               }
               else if (dialogResult == DialogResult.No)
               {
               timer1.Stop();
               this.Hide();
               Form10 f1 = new Form10(a);
               f1.Show();
           }
            }
            if (mistakes == -1)
            {
                pictureBox1.Image = h;
                timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
      
                    timer1.Stop();
                   hangman myNewForm = new hangman(a);

                 this.Hide();
                 myNewForm.ShowDialog();



                }
                else if (dialogResult == DialogResult.No)
                {
                    timer1.Stop();
                    this.Hide();
                    Form10 f1 = new Form10(a);
                    f1.Show();
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form10 f1 = new Form10(a);
            f1.Show();
        }
    }
}

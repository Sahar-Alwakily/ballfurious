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
    public partial class maht : Form
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
        public maht(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        Image h = Image.FromFile("sta\\math.jpg");
        int i = 1, a, xm, ym;
        int n = 300, m = 10;
        String x, y;
        bool answer = false;
        Random rnd = new Random();
        int[] arr = new int[35] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 14, 15, 16, 18, 20, 21, 24, 25, 27, 28, 30, 32, 35, 36, 40, 42, 45, 48, 49, 54, 56, 63, 64, 72, 81 };
        private void lose2_Load(object sender, EventArgs e)
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
            // تعبئه جدول بطريقه عشوائي
            button1.Text = "" + rnd.Next(1, 10);
            button2.Text = "" + rnd.Next(1, 10);
            button3.Text = "" + rnd.Next(1, 10);
            button4.Text = "" + rnd.Next(1, 10);
            button5.Text = "" + rnd.Next(1, 10);
            button6.Text = "" + rnd.Next(1, 10);
            button7.Text = "" + rnd.Next(1, 10);
            button8.Text = "" + rnd.Next(1, 10);
            button9.Text = "" + rnd.Next(1, 10);
            button10.Text = "" + rnd.Next(1, 10);
            button11.Text = "" + rnd.Next(1, 10);
            button12.Text = "" + rnd.Next(1, 10);
            button13.Text = "" + rnd.Next(1, 10);
            button14.Text = "" + rnd.Next(1, 10);
            button15.Text = "" + rnd.Next(1, 10);
            button16.Text = "" + rnd.Next(1, 10);
            button17.Text = "" + rnd.Next(1, 10);
            button18.Text = "" + rnd.Next(1, 10);
            button19.Text = "" + rnd.Next(1, 10);
            button20.Text = "" + rnd.Next(1, 10);
            button21.Text = "" + rnd.Next(1, 10);
            button22.Text = "" + rnd.Next(1, 10);
            button23.Text = "" + rnd.Next(1, 10);
            button24.Text = "" + rnd.Next(1, 10);
            button25.Text = "" + rnd.Next(1, 10);
            button26.Text = "" + rnd.Next(1, 10);
            button27.Text = "" + rnd.Next(1, 10);
            button28.Text = "" + rnd.Next(1, 10);
            button29.Text = "" + rnd.Next(1, 10);
            button30.Text = "" + rnd.Next(1, 10);
            button31.Text = "" + rnd.Next(1, 10);
            button32.Text = "" + rnd.Next(1, 10);
            button33.Text = "" + rnd.Next(1, 10);
            button34.Text = "" + rnd.Next(1, 10);
            button35.Text = "" + rnd.Next(1, 10);
            button36.Text = "" + rnd.Next(1, 10);
            button37.Text = "" + rnd.Next(1, 10);
            button38.Text = "" + rnd.Next(1, 10);
            button39.Text = "" + rnd.Next(1, 10);
            button40.Text = "" + rnd.Next(1, 10);
            button41.Text = "" + rnd.Next(1, 10);
            button42.Text = "" + rnd.Next(1, 10);
            button43.Text = "" + rnd.Next(1, 10);
            button44.Text = "" + rnd.Next(1, 10);
            button45.Text = "" + rnd.Next(1, 10);
            button46.Text = "" + rnd.Next(1, 10);
            button47.Text = "" + rnd.Next(1, 10);
            button48.Text = "" + rnd.Next(1, 10);
            button49.Text = "" + rnd.Next(1, 10);
            button50.Text = "" + rnd.Next(1, 10);
            button51.Text = "" + rnd.Next(1, 10);
            button52.Text = "" + rnd.Next(1, 10);
            button53.Text = "" + rnd.Next(1, 10);
            button54.Text = "" + rnd.Next(1, 10);
            button55.Text = "" + rnd.Next(1, 10);
            button56.Text = "" + rnd.Next(1, 10);
            button57.Text = "" + rnd.Next(1, 10);
            button58.Text = "" + rnd.Next(1, 10);
            button59.Text = "" + rnd.Next(1, 10);
            button60.Text = "" + rnd.Next(1, 10);
            button61.Text = "" + rnd.Next(1, 10);
            button62.Text = "" + rnd.Next(1, 10);
            button63.Text = "" + rnd.Next(1, 10);
            button64.Text = "" + rnd.Next(1, 10);
            button65.Text = "" + rnd.Next(1, 10);
            button66.Text = "" + rnd.Next(1, 10);
            button67.Text = "" + rnd.Next(1, 10);
            button68.Text = "" + rnd.Next(1, 10);
            button69.Text = "" + rnd.Next(1, 10);
            button70.Text = "" + rnd.Next(1, 10);
            button71.Text = "" + rnd.Next(1, 10);
            button72.Text = "" + rnd.Next(1, 10);
            button73.Text = "" + rnd.Next(1, 10);
            button74.Text = "" + rnd.Next(1, 10);
            button75.Text = "" + rnd.Next(1, 10);
            button76.Text = "" + rnd.Next(1, 10);
            button77.Text = "" + rnd.Next(1, 10);
            button78.Text = "" + rnd.Next(1, 10);
            button79.Text = "" + rnd.Next(1, 10);
            button80.Text = "" + rnd.Next(1, 10);
            button81.Text = "" + rnd.Next(1, 10);
            button82.Text = "" + rnd.Next(1, 10);
            button83.Text = "" + rnd.Next(1, 10);
            button84.Text = "" + rnd.Next(1, 10);
            button85.Text = "" + rnd.Next(1, 10);
            button86.Text = "" + rnd.Next(1, 10);
            button87.Text = "" + rnd.Next(1, 10);
            button88.Text = "" + rnd.Next(1, 10);
            button89.Text = "" + rnd.Next(1, 10);
            button90.Text = "" + rnd.Next(1, 10);
            button91.Text = "" + rnd.Next(1, 10);
            button92.Text = "" + rnd.Next(1, 10);
            button93.Text = "" + rnd.Next(1, 10);
            button94.Text = "" + rnd.Next(1, 10);
            button95.Text = "" + rnd.Next(1, 10);
            button96.Text = "" + rnd.Next(1, 10);
            button97.Text = "" + rnd.Next(1, 10);
            button98.Text = "" + rnd.Next(1, 10);
            button99.Text = "" + rnd.Next(1, 10);
            button100.Text = "" + rnd.Next(1, 10);
            a = rnd.Next(0, 35);
            a = arr[a];
            // a = 5;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            //  

            if (i == 3)
            {
                i = 1;

                if (a == (Convert.ToInt32(x) * Convert.ToInt32(y)))
                {

                    answer = true;
                    #region אם התשבה היא נכונה
                    switch (xm)
                    {
                        case 1: button1.Visible = false;
                            break;
                        case 2: button2.Visible = false;
                            break;
                        case 3: button3.Visible = false;
                            break;
                        case 4: button4.Visible = false;
                            break;
                        case 5: button5.Visible = false;
                            break;
                        case 6: button6.Visible = false;
                            break;
                        case 7: button7.Visible = false;
                            break;
                        case 8: button8.Visible = false;
                            break;
                        case 9: button9.Visible = false;
                            break;



                        case 10: button10.Visible = false;
                            break;
                        case 11: button11.Visible = false;
                            break;
                        case 12: button12.Visible = false;
                            break;
                        case 13: button13.Visible = false;
                            break;
                        case 14: button14.Visible = false;
                            break;
                        case 15: button15.Visible = false;
                            break;
                        case 16: button16.Visible = false;
                            break;
                        case 17: button17.Visible = false;
                            break;
                        case 18: button18.Visible = false;
                            break;
                        case 19: button19.Visible = false;
                            break;





                        case 20: button20.Visible = false;
                            break;
                        case 21: button21.Visible = false;
                            break;
                        case 22: button22.Visible = false;
                            break;
                        case 23: button23.Visible = false;
                            break;
                        case 24: button24.Visible = false;
                            break;
                        case 25: button25.Visible = false;
                            break;
                        case 26: button26.Visible = false;
                            break;
                        case 27: button27.Visible = false;
                            break;
                        case 28: button28.Visible = false;
                            break;
                        case 29: button29.Visible = false;
                            break;




                        case 30: button30.Visible = false;
                            break;
                        case 31: button31.Visible = false;
                            break;
                        case 32: button32.Visible = false;
                            break;
                        case 33: button33.Visible = false;
                            break;
                        case 34: button34.Visible = false;
                            break;
                        case 35: button35.Visible = false;
                            break;
                        case 36: button36.Visible = false;
                            break;
                        case 37: button37.Visible = false;
                            break;
                        case 38: button38.Visible = false;
                            break;
                        case 39: button39.Visible = false;
                            break;






                        case 40: button40.Visible = false;
                            break;
                        case 41: button41.Visible = false;
                            break;
                        case 42: button42.Visible = false;
                            break;
                        case 43: button43.Visible = false;
                            break;
                        case 44: button44.Visible = false;
                            break;
                        case 45: button45.Visible = false;
                            break;
                        case 46: button46.Visible = false;
                            break;
                        case 47: button47.Visible = false;
                            break;
                        case 48: button48.Visible = false;
                            break;
                        case 49: button49.Visible = false;
                            break;





                        case 50: button50.Visible = false;
                            break;
                        case 51: button51.Visible = false;
                            break;
                        case 52: button52.Visible = false;
                            break;
                        case 53: button53.Visible = false;
                            break;
                        case 54: button54.Visible = false;
                            break;
                        case 55: button55.Visible = false;
                            break;
                        case 56: button56.Visible = false;
                            break;
                        case 57: button57.Visible = false;
                            break;
                        case 58: button58.Visible = false;
                            break;
                        case 59: button59.Visible = false;
                            break;




                        case 60: button60.Visible = false;
                            break;
                        case 61: button61.Visible = false;
                            break;
                        case 62: button62.Visible = false;
                            break;
                        case 63: button63.Visible = false;
                            break;
                        case 64: button64.Visible = false;
                            break;
                        case 65: button65.Visible = false;
                            break;
                        case 66: button66.Visible = false;
                            break;
                        case 67: button67.Visible = false;
                            break;
                        case 68: button68.Visible = false;
                            break;
                        case 69: button69.Visible = false;
                            break;






                        case 70: button70.Visible = false;
                            break;
                        case 71: button71.Visible = false;
                            break;
                        case 72: button72.Visible = false;
                            break;
                        case 73: button73.Visible = false;
                            break;
                        case 74: button74.Visible = false;
                            break;
                        case 75: button75.Visible = false;
                            break;
                        case 76: button76.Visible = false;
                            break;
                        case 77: button77.Visible = false;
                            break;
                        case 78: button78.Visible = false;
                            break;
                        case 79: button79.Visible = false;
                            break;




                        case 80: button80.Visible = false;
                            break;
                        case 81: button81.Visible = false;
                            break;
                        case 82: button82.Visible = false;
                            break;
                        case 83: button83.Visible = false;
                            break;
                        case 84: button84.Visible = false;
                            break;
                        case 85: button85.Visible = false;
                            break;
                        case 86: button86.Visible = false;
                            break;
                        case 87: button87.Visible = false;
                            break;
                        case 88: button88.Visible = false;
                            break;
                        case 89: button89.Visible = false;
                            break;





                        case 90: button90.Visible = false;
                            break;
                        case 91: button91.Visible = false;
                            break;
                        case 92: button92.Visible = false;
                            break;
                        case 93: button93.Visible = false;
                            break;
                        case 94: button94.Visible = false;
                            break;
                        case 95: button95.Visible = false;
                            break;
                        case 96: button96.Visible = false;
                            break;
                        case 97: button97.Visible = false;
                            break;
                        case 98: button98.Visible = false;
                            break;
                        case 99: button99.Visible = false;
                            break;
                        case 100: button100.Visible = false;
                            break;
                    }














                    switch (ym)
                    {
                        case 1: button1.Visible = false;
                            break;
                        case 2: button2.Visible = false;
                            break;
                        case 3: button3.Visible = false;
                            break;
                        case 4: button4.Visible = false;
                            break;
                        case 5: button5.Visible = false;
                            break;
                        case 6: button6.Visible = false;
                            break;
                        case 7: button7.Visible = false;
                            break;
                        case 8: button8.Visible = false;
                            break;
                        case 9: button9.Visible = false;
                            break;






                        case 10: button10.Visible = false;
                            break;
                        case 11: button11.Visible = false;
                            break;
                        case 12: button12.Visible = false;
                            break;
                        case 13: button13.Visible = false;
                            break;
                        case 14: button14.Visible = false;
                            break;
                        case 15: button15.Visible = false;
                            break;
                        case 16: button16.Visible = false;
                            break;
                        case 17: button17.Visible = false;
                            break;
                        case 18: button18.Visible = false;
                            break;
                        case 19: button19.Visible = false;
                            break;





                        case 20: button20.Visible = false;
                            break;
                        case 21: button21.Visible = false;
                            break;
                        case 22: button22.Visible = false;
                            break;
                        case 23: button23.Visible = false;
                            break;
                        case 24: button24.Visible = false;
                            break;
                        case 25: button25.Visible = false;
                            break;
                        case 26: button26.Visible = false;
                            break;
                        case 27: button27.Visible = false;
                            break;
                        case 28: button28.Visible = false;
                            break;
                        case 29: button29.Visible = false;
                            break;





                        case 30: button30.Visible = false;
                            break;
                        case 31: button31.Visible = false;
                            break;
                        case 32: button32.Visible = false;
                            break;
                        case 33: button33.Visible = false;
                            break;
                        case 34: button34.Visible = false;
                            break;
                        case 35: button35.Visible = false;
                            break;
                        case 36: button36.Visible = false;
                            break;
                        case 37: button37.Visible = false;
                            break;
                        case 38: button38.Visible = false;
                            break;
                        case 39: button39.Visible = false;
                            break;




                        case 40: button40.Visible = false;
                            break;
                        case 41: button41.Visible = false;
                            break;
                        case 42: button42.Visible = false;
                            break;
                        case 43: button43.Visible = false;
                            break;
                        case 44: button44.Visible = false;
                            break;
                        case 45: button45.Visible = false;
                            break;
                        case 46: button46.Visible = false;
                            break;
                        case 47: button47.Visible = false;
                            break;
                        case 48: button48.Visible = false;
                            break;

                        case 49: button49.Visible = false;
                            break;


                        case 50: button50.Visible = false;
                            break;
                        case 51: button51.Visible = false;
                            break;
                        case 52: button52.Visible = false;
                            break;
                        case 53: button53.Visible = false;
                            break;
                        case 54: button54.Visible = false;
                            break;
                        case 55: button55.Visible = false;
                            break;
                        case 56: button56.Visible = false;
                            break;
                        case 57: button57.Visible = false;
                            break;
                        case 58: button58.Visible = false;
                            break;
                        case 59: button59.Visible = false;
                            break;






                        case 60: button60.Visible = false;
                            break;
                        case 61: button61.Visible = false;
                            break;
                        case 62: button62.Visible = false;
                            break;
                        case 63: button63.Visible = false;
                            break;
                        case 64: button64.Visible = false;
                            break;
                        case 65: button65.Visible = false;
                            break;
                        case 66: button66.Visible = false;
                            break;
                        case 67: button67.Visible = false;
                            break;
                        case 68: button68.Visible = false;
                            break;
                        case 69: button69.Visible = false;
                            break;





                        case 70: button70.Visible = false;
                            break;
                        case 71: button71.Visible = false;
                            break;
                        case 72: button72.Visible = false;
                            break;
                        case 73: button73.Visible = false;
                            break;
                        case 74: button74.Visible = false;
                            break;
                        case 75: button75.Visible = false;
                            break;
                        case 76: button76.Visible = false;
                            break;
                        case 77: button77.Visible = false;
                            break;
                        case 78: button78.Visible = false;
                            break;
                        case 79: button79.Visible = false;
                            break;



                        case 80: button80.Visible = false;
                            break;
                        case 81: button81.Visible = false;
                            break;
                        case 82: button82.Visible = false;
                            break;
                        case 83: button83.Visible = false;
                            break;
                        case 84: button84.Visible = false;
                            break;
                        case 85: button85.Visible = false;
                            break;
                        case 86: button86.Visible = false;
                            break;
                        case 87: button87.Visible = false;
                            break;
                        case 88: button88.Visible = false;
                            break;
                        case 89: button89.Visible = false;
                            break;



                        case 90: button90.Visible = false;
                            break;
                        case 91: button91.Visible = false;
                            break;
                        case 92: button92.Visible = false;
                            break;
                        case 93: button93.Visible = false;
                            break;
                        case 94: button94.Visible = false;
                            break;
                        case 95: button95.Visible = false;
                            break;
                        case 96: button96.Visible = false;
                            break;
                        case 97: button97.Visible = false;
                            break;
                        case 98: button98.Visible = false;
                            break;
                        case 99: button99.Visible = false;
                            break;
                        case 100: button100.Visible = false;
                            break;
                    }
                    #endregion



                }
                else
                {
                    #region אם התשובה היא לא נכון
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button9.BackColor = Color.White;
                    button10.BackColor = Color.White;





                    button11.BackColor = Color.White;
                    button12.BackColor = Color.White;
                    button13.BackColor = Color.White;
                    button14.BackColor = Color.White;
                    button15.BackColor = Color.White;
                    button16.BackColor = Color.White;
                    button17.BackColor = Color.White;
                    button18.BackColor = Color.White;
                    button19.BackColor = Color.White;
                    button20.BackColor = Color.White;

                    button21.BackColor = Color.White;
                    button22.BackColor = Color.White;
                    button23.BackColor = Color.White;
                    button24.BackColor = Color.White;
                    button25.BackColor = Color.White;
                    button26.BackColor = Color.White;
                    button27.BackColor = Color.White;
                    button28.BackColor = Color.White;
                    button29.BackColor = Color.White;
                    button30.BackColor = Color.White;





                    button31.BackColor = Color.White;
                    button32.BackColor = Color.White;
                    button33.BackColor = Color.White;
                    button34.BackColor = Color.White;
                    button35.BackColor = Color.White;
                    button36.BackColor = Color.White;
                    button37.BackColor = Color.White;
                    button38.BackColor = Color.White;
                    button39.BackColor = Color.White;
                    button40.BackColor = Color.White;





                    button41.BackColor = Color.White;
                    button42.BackColor = Color.White;
                    button43.BackColor = Color.White;
                    button44.BackColor = Color.White;
                    button45.BackColor = Color.White;
                    button46.BackColor = Color.White;
                    button47.BackColor = Color.White;
                    button48.BackColor = Color.White;
                    button49.BackColor = Color.White;
                    button50.BackColor = Color.White;




                    button51.BackColor = Color.White;
                    button52.BackColor = Color.White;
                    button53.BackColor = Color.White;
                    button54.BackColor = Color.White;
                    button55.BackColor = Color.White;
                    button56.BackColor = Color.White;
                    button57.BackColor = Color.White;
                    button58.BackColor = Color.White;
                    button59.BackColor = Color.White;
                    button60.BackColor = Color.White;








                    button61.BackColor = Color.White;
                    button62.BackColor = Color.White;
                    button63.BackColor = Color.White;
                    button64.BackColor = Color.White;
                    button65.BackColor = Color.White;
                    button66.BackColor = Color.White;
                    button67.BackColor = Color.White;
                    button68.BackColor = Color.White;
                    button69.BackColor = Color.White;
                    button70.BackColor = Color.White;



                    button71.BackColor = Color.White;
                    button72.BackColor = Color.White;
                    button73.BackColor = Color.White;
                    button74.BackColor = Color.White;
                    button75.BackColor = Color.White;
                    button76.BackColor = Color.White;
                    button77.BackColor = Color.White;
                    button78.BackColor = Color.White;
                    button79.BackColor = Color.White;
                    button80.BackColor = Color.White;








                    button81.BackColor = Color.White;
                    button82.BackColor = Color.White;
                    button83.BackColor = Color.White;
                    button84.BackColor = Color.White;
                    button85.BackColor = Color.White;
                    button86.BackColor = Color.White;
                    button87.BackColor = Color.White;
                    button88.BackColor = Color.White;
                    button89.BackColor = Color.White;
                    button90.BackColor = Color.White;






                    button91.BackColor = Color.White;
                    button92.BackColor = Color.White;
                    button93.BackColor = Color.White;
                    button94.BackColor = Color.White;
                    button95.BackColor = Color.White;
                    button96.BackColor = Color.White;
                    button97.BackColor = Color.White;
                    button98.BackColor = Color.White;
                    button99.BackColor = Color.White;
                    button100.BackColor = Color.White;













                    #endregion
                }

                y = "";
                x = "";
                xm = 0;
                ym = 0;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region בודק אם התשובה נכונה או לא

        private void button72_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button72.BackColor = Color.Red;
                if (i == 1) { y = button72.Text; ym = 72; }
                if (i == 2) { x = button72.Text; xm = 72; }
                i++;


            }

        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button92.BackColor = Color.Red;
                if (i == 1) { y = button92.Text; ym = 92; }
                if (i == 2) { x = button92.Text; xm = 92; }
                i++;


            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button93.BackColor = Color.Red;
                if (i == 1) { y = button93.Text; ym = 93; }
                if (i == 2) { x = button93.Text; xm = 93; }
                i++;


            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button94.BackColor = Color.Red;
                if (i == 1) { y = button94.Text; ym = 94; }
                if (i == 2) { x = button94.Text; xm = 94; }
                i++;


            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button95.BackColor = Color.Red;
                if (i == 1)
                { y = button95.Text; ym = 95; }
                if (i == 2) { x = button95.Text; xm = 95; }
                i++;


            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button96.BackColor = Color.Red;
                if (i == 1) { y = button96.Text; ym = 96; }
                if (i == 2) { x = button96.Text; xm = 96; }
                i++;


            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button97.BackColor = Color.Red;
                if (i == 1) { y = button97.Text; ym = 97; }
                if (i == 2) { x = button97.Text; xm = 97; }
                i++;


            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button98.BackColor = Color.Red;
                if (i == 1) { y = button98.Text; ym = 98; }
                if (i == 2) { x = button98.Text; xm = 98; }
                i++;


            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button99.BackColor = Color.Red;
                if (i == 1) { y = button99.Text; ym = 99; }
                if (i == 2) { x = button99.Text; xm = 99; }
                i++;


            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button100.BackColor = Color.Red;
                if (i == 1) { y = button100.Text; ym = 100; }
                if (i == 2) { x = button100.Text; xm = 100; }
                i++;


            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button81.BackColor = Color.Red;
                if (i == 1) { y = button81.Text; ym = 81; }
                if (i == 2) { x = button81.Text; xm = 81; }
                i++;


            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button82.BackColor = Color.Red;
                if (i == 1) { y = button82.Text; ym = 82; }
                if (i == 2) { x = button82.Text; xm = 82; }
                i++;


            }

        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button83.BackColor = Color.Red;
                if (i == 1) { y = button83.Text; ym = 83; }
                if (i == 2) { x = button83.Text; xm = 83; }
                i++;


            }

        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button84.BackColor = Color.Red;
                if (i == 1) { y = button84.Text; ym = 84; }
                if (i == 2) { x = button84.Text; xm = 84; }
                i++;


            }

        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button85.BackColor = Color.Red;
                if (i == 1) y = button85.Text;
                if (i == 2) x = button85.Text;
                i++;
                xm = 85;
                ym = 85;
            }

        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button86.BackColor = Color.Red;
                if (i == 1) { y = button86.Text; ym = 86; }
                if (i == 2) { x = button86.Text; xm = 86; }
                i++;


            }

        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button87.BackColor = Color.Red;
                if (i == 1) { y = button87.Text; ym = 87; }
                if (i == 2) { x = button87.Text; xm = 87; }
                i++;


            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button88.BackColor = Color.Red;
                if (i == 1) { y = button88.Text; ym = 88; }
                if (i == 2) { x = button88.Text; xm = 88; }
                i++;


            }

        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button89.BackColor = Color.Red;
                if (i == 1) { y = button89.Text; ym = 89; }
                if (i == 2) { x = button89.Text; xm = 89; }
                i++;


            }

        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button90.BackColor = Color.Red;
                if (i == 1) { y = button90.Text; ym = 90; }
                if (i == 2) { x = button90.Text; xm = 90; }
                i++;


            }

        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button71.BackColor = Color.Red;
                if (i == 1) { y = button71.Text; ym = 71; }
                if (i == 2) { x = button71.Text; xm = 71; }
                i++;


            }

        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button91.BackColor = Color.Red;
                if (i == 1) { y = button91.Text; ym = 91; }
                if (i == 2) { x = button91.Text; xm = 91; }
                i++;


            }

        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button73.BackColor = Color.Red;
                if (i == 1) { y = button73.Text; ym = 73; }
                if (i == 2) { x = button73.Text; xm = 73; }
                i++;


            }

        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button74.BackColor = Color.Red;
                if (i == 1) { y = button74.Text; ym = 74; }
                if (i == 2) { x = button74.Text; xm = 74; }
                i++;


            }

        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button75.BackColor = Color.Red;
                if (i == 1) { y = button75.Text; ym = 75; }
                if (i == 2) { x = button75.Text; xm = 75; }
                i++;


            }

        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button76.BackColor = Color.Red;
                if (i == 1) { y = button76.Text; ym = 76; }
                if (i == 2) { x = button76.Text; xm = 76; }
                i++;


            }

        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button77.BackColor = Color.Red;
                if (i == 1) { y = button77.Text; ym = 77; }
                if (i == 2) { x = button77.Text; xm = 77; }
                i++;


            }

        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button78.BackColor = Color.Red;
                if (i == 1) { y = button78.Text; ym = 78; }
                if (i == 2) { x = button78.Text; xm = 78; }
                i++;


            }

        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button79.BackColor = Color.Red;
                if (i == 1) { y = button79.Text; ym = 79; }
                if (i == 2) { x = button79.Text; xm = 79; }
                i++;


            }

        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button80.BackColor = Color.Red;
                if (i == 1) { y = button80.Text; ym = 80; }
                if (i == 2) { x = button80.Text; xm = 80; }
                i++;


            }

        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button61.BackColor = Color.Red;
                if (i == 1) { y = button61.Text; ym = 61; }
                if (i == 2) { x = button61.Text; xm = 61; }
                i++;


            }

        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button62.BackColor = Color.Red;
                if (i == 1) { y = button62.Text; ym = 62; }
                if (i == 2) { x = button62.Text; xm = 62; }
                i++;


            }

        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button63.BackColor = Color.Red;
                if (i == 1) { y = button63.Text; ym = 63; }

                if (i == 2) { x = button63.Text; xm = 63; }
                i++;


            }

        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button64.BackColor = Color.Red;
                if (i == 1) { y = button64.Text; ym = 64; }
                if (i == 2) { x = button64.Text; xm = 64; }
                i++;


            }

        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button65.BackColor = Color.Red;
                if (i == 1) { y = button65.Text; ym = 65; }
                if (i == 2) { x = button65.Text; xm = 65; }
                i++;


            }

        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button66.BackColor = Color.Red;
                if (i == 1) { y = button66.Text; ym = 66; }
                if (i == 2) { x = button66.Text; xm = 66; }
                i++;


            }

        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button67.BackColor = Color.Red;
                if (i == 1) { y = button67.Text; ym = 67; }
                if (i == 2) { x = button67.Text; xm = 67; }
                i++;


            }

        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button68.BackColor = Color.Red;
                if (i == 1) { y = button68.Text; ym = 68; }
                if (i == 2) { x = button68.Text; xm = 68; }
                i++;


            }

        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button69.BackColor = Color.Red;
                if (i == 1) { y = button69.Text; ym = 69; }
                if (i == 2) { x = button69.Text; xm = 69; }
                i++;


            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button70.BackColor = Color.Red;
                if (i == 1) { y = button70.Text; ym = 70; }
                if (i == 2) { x = button70.Text; xm = 70; }
                i++;


            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button51.BackColor = Color.Red;
                if (i == 1) { y = button51.Text; ym = 51; }
                if (i == 2) { x = button51.Text; xm = 51; }
                i++;


            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button52.BackColor = Color.Red;
                if (i == 1) { y = button52.Text; ym = 52; }
                if (i == 2) { x = button52.Text; xm = 52; }
                i++;


            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button53.BackColor = Color.Red;
                if (i == 1) { y = button53.Text; ym = 53; }
                if (i == 2) { x = button53.Text; xm = 53; }
                i++;


            }

        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button54.BackColor = Color.Red;
                if (i == 1) { y = button54.Text; ym = 54; }
                if (i == 2) { x = button54.Text; xm = 54; }
                i++;


            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button55.BackColor = Color.Red;
                if (i == 1) { y = button55.Text; ym = 55; }
                if (i == 2) { x = button55.Text; xm = 55; }
                i++;


            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button56.BackColor = Color.Red;
                if (i == 1) { y = button56.Text; ym = 56; }
                if (i == 2) { x = button56.Text; xm = 56; }
                i++;


            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button57.BackColor = Color.Red;
                if (i == 1) { y = button57.Text; ym = 57; }
                if (i == 2) { x = button57.Text; xm = 57; }
                i++;


            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button58.BackColor = Color.Red;
                if (i == 1) { y = button58.Text; ym = 58; }
                if (i == 2) { x = button58.Text; xm = 58; }
                i++;


            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button59.BackColor = Color.Red;
                if (i == 1) { y = button59.Text; ym = 59; }
                if (i == 2) { x = button59.Text; xm = 59; }
                i++;


            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button60.BackColor = Color.Red;
                if (i == 1) { y = button60.Text; ym = 60; }
                if (i == 2) { x = button60.Text; xm = 60; }
                i++;


            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button41.BackColor = Color.Red;
                if (i == 1) { y = button41.Text; ym = 41; }
                if (i == 2) { x = button41.Text; xm = 41; }
                i++;


            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button42.BackColor = Color.Red;
                if (i == 1) { y = button42.Text; ym = 42; }
                if (i == 2) { x = button42.Text; xm = 42; }
                i++;


            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button43.BackColor = Color.Red;
                if (i == 1) { y = button43.Text; ym = 43; }
                if (i == 2) { x = button43.Text; xm = 43; }
                i++;


            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button44.BackColor = Color.Red;
                if (i == 1) { y = button44.Text; ym = 44; }
                if (i == 2) { x = button44.Text; xm = 44; }
                i++;


            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button45.BackColor = Color.Red;
                if (i == 1) { y = button45.Text; ym = 45; }
                if (i == 2) { x = button45.Text; xm = 45; }
                i++;


            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button46.BackColor = Color.Red;
                if (i == 1) { y = button46.Text; ym = 46; }
                if (i == 2) { x = button46.Text; xm = 46; }
                i++;


            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button47.BackColor = Color.Red;
                if (i == 1) { y = button47.Text; ym = 47; }
                if (i == 2) { x = button47.Text; xm = 47; }
                i++;


            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button48.BackColor = Color.Red;
                if (i == 1) { y = button48.Text; ym = 48; }
                if (i == 2) { x = button48.Text; xm = 48; }
                i++;


            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button49.BackColor = Color.Red;
                if (i == 1) { y = button49.Text; ym = 49; }
                if (i == 2) { x = button49.Text; xm = 49; }
                i++;


            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button50.BackColor = Color.Red;
                if (i == 1) { y = button50.Text; ym = 50; }
                if (i == 2) { x = button50.Text; xm = 50; }
                i++;


            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button31.BackColor = Color.Red;
                if (i == 1) { y = button31.Text; ym = 31; }
                if (i == 2) { x = button31.Text; xm = 31; }
                i++;


            }

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button32.BackColor = Color.Red;
                if (i == 1) { y = button32.Text; ym = 32; }
                if (i == 2) { x = button32.Text; xm = 32; }
                i++;


            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button33.BackColor = Color.Red;
                if (i == 1) { y = button33.Text; ym = 33; }
                if (i == 2) { x = button33.Text; xm = 33; }
                i++;


            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button34.BackColor = Color.Red;
                if (i == 1) { y = button34.Text; ym = 34; }
                if (i == 2) { x = button34.Text; xm = 34; }
                i++;


            }

        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button35.BackColor = Color.Red;
                if (i == 1) { y = button35.Text; ym = 35; }
                if (i == 2) { x = button35.Text; xm = 35; }
                i++;


            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button36.BackColor = Color.Red;
                if (i == 1) { y = button36.Text; ym = 36; }
                if (i == 2) { x = button36.Text; xm = 36; }

                i++;


            }

        }

        private void button37_Click(object sender, EventArgs e)
        {

            if (i != 3)
            {
                button37.BackColor = Color.Red;
                if (i == 1) { y = button37.Text; ym = 37; }
                if (i == 2) { x = button37.Text; xm = 37; }
                i++;


            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button38.BackColor = Color.Red;
                if (i == 1) { y = button38.Text; ym = 38; }
                if (i == 2) { x = button38.Text; xm = 38; }
                i++;


            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button39.BackColor = Color.Red;
                if (i == 1) { y = button39.Text; ym = 39; }
                if (i == 2) { x = button39.Text; xm = 39; }
                i++;


            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button40.BackColor = Color.Red;
                if (i == 1) { y = button40.Text; ym = 40; }
                if (i == 2) { x = button40.Text; xm = 40; }
                i++;


            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button21.BackColor = Color.Red;
                if (i == 1) { y = button21.Text; ym = 21; }
                if (i == 2) { x = button21.Text; xm = 21; }
                i++;


            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button22.BackColor = Color.Red;
                if (i == 1) { y = button22.Text; ym = 22; }
                if (i == 2) { x = button22.Text; xm = 22; }
                i++;


            }
        }

        private void button23_Click(object sender, EventArgs e)
        {

            if (i != 3)
            {
                button23.BackColor = Color.Red;
                if (i == 1) { y = button23.Text; ym = 23; }
                if (i == 2) { x = button23.Text; xm = 23; }
                i++;


            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button24.BackColor = Color.Red;
                if (i == 1) { y = button24.Text; ym = 24; }
                if (i == 2) { x = button24.Text; xm = 24; }
                i++;


            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button25.BackColor = Color.Red;
                if (i == 1) { y = button25.Text; ym = 25; }
                if (i == 2) { x = button25.Text; xm = 25; }
                i++;


            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button26.BackColor = Color.Red;
                if (i == 1) { y = button26.Text; ym = 26; }
                if (i == 2) { x = button26.Text; xm = 26; }
                i++;


            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button27.BackColor = Color.Red;
                if (i == 1) { y = button27.Text; ym = 27; }
                if (i == 2) { x = button27.Text; xm = 27; }
                i++;


            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button28.BackColor = Color.Red;
                if (i == 1) { y = button28.Text; ym = 28; }
                if (i == 2) { x = button28.Text; xm = 28; }
                i++;


            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button29.BackColor = Color.Red;
                if (i == 1) { y = button29.Text; ym = 29; }
                if (i == 2) { x = button29.Text; xm = 29; }
                i++;


            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button30.BackColor = Color.Red;
                if (i == 1) { y = button30.Text; ym = 30; }
                if (i == 2) { x = button30.Text; xm = 30; }
                i++;


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button11.BackColor = Color.Red;
                if (i == 1) { y = button11.Text; ym = 11; }
                if (i == 2) { x = button11.Text; xm = 11; }
                i++;


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button12.BackColor = Color.Red;
                if (i == 1) { y = button12.Text; ym = 12; }
                if (i == 2) { x = button12.Text; xm = 12; }
                i++;


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button13.BackColor = Color.Red;
                if (i == 1) { y = button13.Text; ym = 13; }
                if (i == 2) { x = button13.Text; xm = 13; }
                i++;


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button14.BackColor = Color.Red;
                if (i == 1) { y = button14.Text; ym = 14; }
                if (i == 2) { x = button14.Text; xm = 14; }
                i++;


            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button15.BackColor = Color.Red;
                if (i == 1) { y = button15.Text; ym = 15; }
                if (i == 2) { x = button15.Text; xm = 15; }
                i++;


            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button16.BackColor = Color.Red;
                if (i == 1) { y = button16.Text; ym = 16; }
                if (i == 2) { x = button16.Text; xm = 16; }
                i++;


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button17.BackColor = Color.Red;
                if (i == 1) { y = button17.Text; ym = 17; }
                if (i == 2) { x = button17.Text; xm = 17; }
                i++;


            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button18.BackColor = Color.Red;
                if (i == 1) { y = button18.Text; ym = 18; }
                if (i == 2) { x = button18.Text; xm = 18; }
                i++;


            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button19.BackColor = Color.Red;
                if (i == 1) { y = button19.Text; ym = 19; }
                if (i == 2) { x = button19.Text; xm = 19; }
                i++;


            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button20.BackColor = Color.Red;
                if (i == 1) { y = button20.Text; ym = 20; }
                if (i == 2) { x = button20.Text; xm = 20; }
                i++;


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button10.BackColor = Color.Red;
                if (i == 1) { y = button10.Text; ym = 10; }
                if (i == 2) { x = button10.Text; xm = 10; }
                i++;


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button9.BackColor = Color.Red;
                if (i == 1) { y = button9.Text; ym = 9; }
                if (i == 2) { x = button9.Text; xm = 9; }
                i++;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button8.BackColor = Color.Red;
                if (i == 1) { y = button8.Text; ym = 8; }
                if (i == 2) { x = button8.Text; xm = 8; }
                i++;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button7.BackColor = Color.Red;
                if (i == 1) { y = button7.Text; ym = 7; }
                if (i == 2) { x = button7.Text; xm = 7; }
                i++;


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button6.BackColor = Color.Red;
                if (i == 1) { y = button6.Text; ym = 6; }
                if (i == 2) { x = button6.Text; xm = 6; }
                i++;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button5.BackColor = Color.Red;
                if (i == 1) { y = button5.Text; ym = 5; }
                if (i == 2) { x = button5.Text; xm = 5; }
                i++;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button4.BackColor = Color.Red;
                if (i == 1) { y = button4.Text; ym = 4; }
                if (i == 2) { x = button4.Text; xm = 4; }
                i++;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button3.BackColor = Color.Red;
                if (i == 1) { y = button3.Text; ym = 3; }
                if (i == 2) { x = button3.Text; xm = 3; }
                i++;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button2.BackColor = Color.Red;
                if (i == 1) { y = button2.Text; ym = 2; }
                if (i == 2) { x = button2.Text; xm = 2; }
                i++;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                button1.BackColor = Color.Red;
                if (i == 1) { y = button1.Text; ym = 1; }
                if (i == 2) { x = button1.Text; xm = 1; }
                i++;


            }
        }
        #endregion
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (answer == true)
            {
                maskedTextBox4.Text = (Convert.ToInt32(maskedTextBox4.Text) + m) + "";
                timer4.Start();
                m = 10;
                a = rnd.Next(0, 35);
                a = arr[a];
                //  a = 5;

                label1.Text = "ــــــ" + "*" + "ــــــ";
                label8.Text = "=" + a;

                answer = false;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            n--;
            maskedTextBox1.Text = "" + n;
            if (n == 0)
            {

            }

            maskedTextBox2.Text = "" + a;
            label1.Text = "ــــــ" + "*" + "ــــــ";
            label8.Text = "=" + a;

        }


        private void timer4_Tick_1(object sender, EventArgs e)
        {
            m--;
            maskedTextBox3.Text = "" + m;
            if (m == 0) timer4.Stop();
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            n--;
            maskedTextBox1.Text = "" + n;
            if (n == 0)
            {
                timer2.Stop();
                timer1.Stop();
                timer3.Stop();
                timer4.Stop();
               // pictureBox1.Image = h;
               pictureBox1.Visible = true;
                label7.Text = "game over\n" + "Score = " + maskedTextBox4.Text;
                label8.Visible = false;
                label1.Visible = false;
                label7.Visible = true;

                DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    timer1.Stop();
                    maht myNewForm = new maht(s);

                    this.Hide();
                    myNewForm.ShowDialog();



                }
                else if (dialogResult == DialogResult.No)
                {
                    timer1.Stop();
                    this.Hide();
                    Form10 f1 = new Form10(s);
                    f1.Show();
                }
             

            }
         

            maskedTextBox2.Text = "" + a;
            label1.Text = "ــــــ" + "*" + "ــــــ";
            label8.Text = "=" + a;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (answer == true)
            {
                maskedTextBox4.Text = (Convert.ToInt32(maskedTextBox4.Text) + m) + "";
                timer4.Start();
                m = 10;
                a = rnd.Next(0, 35);
                a = arr[a];
                //  a = 5;

                label1.Text = "ــــــ" + "*" + "ــــــ";
                label8.Text = "=" + a;

                answer = false;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop(); 
            timer3.Stop(); 
            timer4.Stop();
            this.Hide();
            Form10 f1 = new Form10(s);
            f1.Show();
        }
     
    }
}

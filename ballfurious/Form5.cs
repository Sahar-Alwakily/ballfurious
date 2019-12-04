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
    public partial class Form5 : Form
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
        public Form5(int _s)
        {
            InitializeComponent();
        }


     //   sodoco m = new sodoco();
        int[,] arr = new int[9, 9] 
         {{7,9,2,8,4,6,3,5,1},
          {4,6,8,5,1,3,9,2,7},
          {1,3,5,7,9,2,6,8,4},
          {6,2,1,4,3,8,5,7,9},
          {5,8,3,1,7,9,2,4,6},
          {9,7,4,2,6,5,8,1,3},
          {2,4,9,6,8,1,7,3,5},
          {3,5,7,9,2,4,1,6,8},
          {8,1,6,3,5,7,4,9,2}};
        // مصفوفه داخلها حل صحيح 
        void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f1 = new Form10(s);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            // فحص الجواب وطبعا حولناه من نص الى رقم 
            if (Convert.ToInt32(maskedTextBox1.Text) == 7 && Convert.ToInt32(maskedTextBox2.Text) == 9 && Convert.ToInt32(maskedTextBox3.Text) == 2 &&
                Convert.ToInt32(maskedTextBox4.Text) == 8 && Convert.ToInt32(maskedTextBox5.Text) == 4 && Convert.ToInt32(maskedTextBox6.Text) == 6 &&
                Convert.ToInt32(maskedTextBox7.Text) == 3 && Convert.ToInt32(maskedTextBox8.Text) == 5 && Convert.ToInt32(maskedTextBox9.Text) == 1 &&
                Convert.ToInt32(maskedTextBox10.Text) == 4 && Convert.ToInt32(maskedTextBox11.Text) == 6 && Convert.ToInt32(maskedTextBox12.Text) == 8 &&
                Convert.ToInt32(maskedTextBox13.Text) == 5 && Convert.ToInt32(maskedTextBox14.Text) == 1 && Convert.ToInt32(maskedTextBox15.Text) == 3 &&
                Convert.ToInt32(maskedTextBox16.Text) == 9 && Convert.ToInt32(maskedTextBox17.Text) == 2 && Convert.ToInt32(maskedTextBox18.Text) == 7 &&
                Convert.ToInt32(maskedTextBox19.Text) == 1 && Convert.ToInt32(maskedTextBox20.Text) == 3 && Convert.ToInt32(maskedTextBox21.Text) == 5 &&
                Convert.ToInt32(maskedTextBox22.Text) == 7 && Convert.ToInt32(maskedTextBox23.Text) == 9 && Convert.ToInt32(maskedTextBox24.Text) == 2 &&
                Convert.ToInt32(maskedTextBox25.Text) == 6 && Convert.ToInt32(maskedTextBox26.Text) == 8 && Convert.ToInt32(maskedTextBox27.Text) == 4 &&
                Convert.ToInt32(maskedTextBox28.Text) == 6 && Convert.ToInt32(maskedTextBox29.Text) == 2 && Convert.ToInt32(maskedTextBox30.Text) == 1 &&
                Convert.ToInt32(maskedTextBox31.Text) == 4 && Convert.ToInt32(maskedTextBox32.Text) == 3 && Convert.ToInt32(maskedTextBox33.Text) == 8 &&
                Convert.ToInt32(maskedTextBox34.Text) == 5 && Convert.ToInt32(maskedTextBox35.Text) == 7 && Convert.ToInt32(maskedTextBox36.Text) == 9 &&
                Convert.ToInt32(maskedTextBox37.Text) == 5 && Convert.ToInt32(maskedTextBox38.Text) == 8 && Convert.ToInt32(maskedTextBox39.Text) == 3 &&
                Convert.ToInt32(maskedTextBox40.Text) == 1 && Convert.ToInt32(maskedTextBox41.Text) == 7 && Convert.ToInt32(maskedTextBox42.Text) == 9 &&
                Convert.ToInt32(maskedTextBox43.Text) == 2 && Convert.ToInt32(maskedTextBox44.Text) == 4 && Convert.ToInt32(maskedTextBox45.Text) == 6 &&
                Convert.ToInt32(maskedTextBox46.Text) == 9 && Convert.ToInt32(maskedTextBox47.Text) == 7 && Convert.ToInt32(maskedTextBox48.Text) == 4 &&
                Convert.ToInt32(maskedTextBox49.Text) == 2 && Convert.ToInt32(maskedTextBox50.Text) == 6 && Convert.ToInt32(maskedTextBox51.Text) == 5 &&
                Convert.ToInt32(maskedTextBox52.Text) == 8 && Convert.ToInt32(maskedTextBox53.Text) == 1 && Convert.ToInt32(maskedTextBox54.Text) == 3 &&
                Convert.ToInt32(maskedTextBox55.Text) == 2 && Convert.ToInt32(maskedTextBox56.Text) == 4 && Convert.ToInt32(maskedTextBox57.Text) == 9 &&
                Convert.ToInt32(maskedTextBox58.Text) == 6 && Convert.ToInt32(maskedTextBox59.Text) == 8 && Convert.ToInt32(maskedTextBox60.Text) == 1 &&
                Convert.ToInt32(maskedTextBox61.Text) == 7 && Convert.ToInt32(maskedTextBox62.Text) == 3 && Convert.ToInt32(maskedTextBox63.Text) == 5 &&
                Convert.ToInt32(maskedTextBox64.Text) == 3 && Convert.ToInt32(maskedTextBox65.Text) == 5 && Convert.ToInt32(maskedTextBox66.Text) == 7 &&
                Convert.ToInt32(maskedTextBox67.Text) == 9 && Convert.ToInt32(maskedTextBox68.Text) == 2 && Convert.ToInt32(maskedTextBox69.Text) == 4 &&
                Convert.ToInt32(maskedTextBox70.Text) == 1 && Convert.ToInt32(maskedTextBox71.Text) == 6 && Convert.ToInt32(maskedTextBox72.Text) == 8 &&
                Convert.ToInt32(maskedTextBox73.Text) == 8 && Convert.ToInt32(maskedTextBox74.Text) == 1 && Convert.ToInt32(maskedTextBox75.Text) == 6 &&
                Convert.ToInt32(maskedTextBox76.Text) == 3 && Convert.ToInt32(maskedTextBox77.Text) == 5 && Convert.ToInt32(maskedTextBox78.Text) == 7 &&
                Convert.ToInt32(maskedTextBox79.Text) == 4 && Convert.ToInt32(maskedTextBox80.Text) == 9 && Convert.ToInt32(maskedTextBox81.Text) == 2)
            {
                label1.Text = "נכון :) כל הכבוד";
                DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
 
                    this.Hide();
                    Form5 f1 = new Form5(s);
                    f1.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
     
                    this.Hide();
                    Form10 f1 = new Form10(s);
                    f1.Show();
                }
            }
            else
                label1.Text = "לא נכון :( .";
        }

        private void maskedTextBox73_KeyPress(object sender, KeyPressEventArgs e)
        {
            // تكتب بس الارقام غيرها ما بتقدر تكتب 
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            string inputChar = e.KeyChar.ToString();
            if (inputChar == ".")
            {
                if (maskedTextBox1.Text.Trim().Length == 0)
                {
                    e.Handled = true;
                    return;
                }

                if (maskedTextBox1.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

        }



   

  

  
    }
}

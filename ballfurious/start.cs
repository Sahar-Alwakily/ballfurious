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
    public partial class start : Form
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
        public start()
        {
            InitializeComponent();
        }


        
        int i=0;
        int[] arr = new int[8] { 1,2,3,4,5,6,7,8 };
        int sound = 1;
        player play = new player();
        private void start_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            satart2 f1 = new satart2(sound);
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("do you want sound?", "music option", MessageBoxButtons.YesNo);//בחירת מוזיקה או בלי מוזיקה 
            if (DialogResult == DialogResult.Yes)
            {
                sound = 1;
                
                play.Play(true);
            }
            else if (DialogResult == DialogResult.No)
            {
                sound = 0;
                play.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice day ");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("פרויקט גמר\n 'משחק לימוד'\n :מגישים\n זהרה אבו-קרינאת\n סחר אלוקילי\n 2016", "אודות");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



    
    }
}

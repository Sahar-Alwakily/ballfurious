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
    public partial class wincolor : Form
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
        public wincolor(int y)
        {
            this.x = y;
            InitializeComponent();
        }
        int i=0,x;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void wincolor_Load(object sender, EventArgs e)
        {

            player.SoundLocation = "2.wav";
             player.Load();
            //player.PlaySync();
            player.Play();
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++; 
            if (i == 25)
            {
                if (x == 7)
                {
                    timer1.Stop();
                    MessageBox.Show("כל הכבוד ");
                    this.Hide();
                    Form10 f3 = new Form10(2);
                    f3.Show();
                }
                else
                {
                    timer1.Stop();
                    x++;
                    this.Hide();
                    english2 f1 = new english2(x);
                    f1.Show();
                }
            }
        }
    }
}

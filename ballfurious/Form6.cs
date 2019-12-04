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
    public partial class Form6 : Form
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
        public Form6()
        {
            InitializeComponent();
        }
        int i = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void Form6_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            player.SoundLocation = "music\\5.wav";
           // player.Load();
          player.Play();
        //  FileStream ff = new FileStream("win.txt", FileMode.Append);
     //     System.IO.File.WriteAllText(@"win.txt", string.Empty);
       //   ff.Close();
       //   Close();
          
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 25)
            {
                player.Stop();
                timer1.Stop();
                this.Hide();
                start f1 = new start();
                f1.Show();
            }
        }
    }
}


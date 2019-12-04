using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace ballfurious
{
    public partial class print : Form
    {
        bool IsMoveDown = false;
        int SizeH = 10;
        int SizeW = 10;
        Graphics myGraphics;
        int Num;
        int i;
        string myColor = "Black";
        bool IsRectangle = false;
        bool IsEllipes = true;

        Random rand;
        public print()
        {
            InitializeComponent();
            rand = new Random();

            myGraphics = pnlPaint.CreateGraphics();
        }

        private void pnlPaint_MouseDown(object sender, MouseEventArgs e)
        {
            IsMoveDown = true;
        }
        private void pnlPaint_MouseUp(object sender, MouseEventArgs e)
        {
            IsMoveDown = false;
        }
        private void pnlPaint_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (IsEllipes)
            {
                if (IsMoveDown)
                {

                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        switch (myColor)
                        {


                            case "Black":
                                myGraphics.FillEllipse(Brushes.Black, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Blue":
                                myGraphics.FillEllipse(Brushes.Blue, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Brown":
                                myGraphics.FillEllipse(Brushes.Brown, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Yellow":
                                myGraphics.FillEllipse(Brushes.Yellow, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Green":
                                myGraphics.FillEllipse(Brushes.Green, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Cyan":
                                myGraphics.FillEllipse(Brushes.Cyan, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Remove":
                                myGraphics.FillRectangle(Brushes.White, e.X, e.Y, SizeH, SizeW);
                                break;


                        }
                    }


                }
            }////////end of ellipse

            if (IsRectangle)
            {
                if (IsMoveDown)
                {

                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        switch (myColor)
                        {


                            case "Black":
                                myGraphics.FillRectangle(Brushes.Black, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Blue":
                                myGraphics.FillRectangle(Brushes.Blue, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Brown":
                                myGraphics.FillRectangle(Brushes.Brown, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Yellow":
                                myGraphics.FillRectangle(Brushes.Yellow, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Green":
                                myGraphics.FillRectangle(Brushes.Green, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Cyan":
                                myGraphics.FillRectangle(Brushes.Cyan, e.X, e.Y, SizeH, SizeW);
                                break;
                            case "Remove":
                                myGraphics.FillRectangle(Brushes.White, e.X, e.Y, SizeH, SizeW);
                                break;


                        }
                    }


                }
            }////////end of Rectangle

        }


        private void btnBlue_MouseEnter(object sender, EventArgs e)
        {
            btnBlue.BackColor = Color.White;
        }
        private void btnBlue_MouseLeave(object sender, EventArgs e)
        {
               btnBlue.BackColor = Color.Blue;
        }

        private void btnYellow_MouseEnter(object sender, EventArgs e)
        {

           
                btnYellow.BackColor = Color.White;
           
        }
        private void btnYellow_MouseLeave(object sender, EventArgs e)
        {
                btnYellow.BackColor = Color.Yellow;
        }

        private void btnGreen_MouseEnter(object sender, EventArgs e)
        {
            btnGreen.BackColor = Color.White;
        }
        private void btnGreen_MouseLeave(object sender, EventArgs e)
        {
            btnGreen.BackColor = Color.Green;
        }

        private void btnCyan_MouseEnter(object sender, EventArgs e)
        {
            btnCyan.BackColor = Color.White;

        }
        private void btnCyan_MouseLeave(object sender, EventArgs e)
        {
                btnCyan.BackColor = Color.Cyan;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {

                button8.BackColor = Color.White;
    
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Brown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            {
                Num++;

                switch (Num)
                {
                    case 1:
                        lblP.ForeColor = Color.Green;
                        lblA.ForeColor = Color.Gold;
                        lblI.ForeColor = Color.Red;
                        lblN.ForeColor = Color.Blue;
                        lblT.ForeColor = Color.DeepPink;
                        lblI2.ForeColor = Color.IndianRed;
                        lblN2.ForeColor = Color.Magenta;
                        lblG.ForeColor = Color.Lime;
                        break;

                    case 2:
                        lblP.ForeColor = Color.Lime;
                        lblA.ForeColor = Color.Green;
                        lblI.ForeColor = Color.Gold;
                        lblN.ForeColor = Color.Red;
                        lblT.ForeColor = Color.Blue;
                        lblI2.ForeColor = Color.DeepPink;
                        lblN2.ForeColor = Color.IndianRed;
                        lblG.ForeColor = Color.Magenta;

                        break;


                    case 3:
                        lblP.ForeColor = Color.Magenta;
                        lblA.ForeColor = Color.Lime;
                        lblI.ForeColor = Color.Green;
                        lblN.ForeColor = Color.Gold;
                        lblT.ForeColor = Color.Red;
                        lblI2.ForeColor = Color.Blue;
                        lblN2.ForeColor = Color.DeepPink;
                        lblG.ForeColor = Color.IndianRed;

                        break;

                    case 4:
                        lblP.ForeColor = Color.IndianRed;
                        lblA.ForeColor = Color.Magenta;
                        lblI.ForeColor = Color.Lime;
                        lblN.ForeColor = Color.Green;
                        lblT.ForeColor = Color.Gold;
                        lblI2.ForeColor = Color.Red;
                        lblN2.ForeColor = Color.Blue;
                        lblG.ForeColor = Color.DeepPink;

                        break;

                    case 5:
                        lblP.ForeColor = Color.DeepPink;
                        lblA.ForeColor = Color.IndianRed;
                        lblI.ForeColor = Color.Magenta;
                        lblN.ForeColor = Color.Lime;
                        lblT.ForeColor = Color.Green;
                        lblI2.ForeColor = Color.Gold;
                        lblN2.ForeColor = Color.Red;
                        lblG.ForeColor = Color.Blue;

                        break;

                    case 6:
                        lblP.ForeColor = Color.Blue;
                        lblA.ForeColor = Color.DeepPink;
                        lblI.ForeColor = Color.IndianRed;
                        lblN.ForeColor = Color.Magenta;
                        lblT.ForeColor = Color.Lime;
                        lblI2.ForeColor = Color.Green;
                        lblN2.ForeColor = Color.Gold;
                        lblG.ForeColor = Color.Red;

                        break;


                    case 7:
                        lblP.ForeColor = Color.Red;
                        lblA.ForeColor = Color.Blue;
                        lblI.ForeColor = Color.DeepPink;
                        lblN.ForeColor = Color.IndianRed;
                        lblT.ForeColor = Color.Magenta;
                        lblI2.ForeColor = Color.Lime;
                        lblN2.ForeColor = Color.Green;
                        lblG.ForeColor = Color.Gold;

                        break;

                    case 8:
                        lblP.ForeColor = Color.Gold;
                        lblA.ForeColor = Color.Red;
                        lblI.ForeColor = Color.Blue;
                        lblN.ForeColor = Color.DeepPink;
                        lblT.ForeColor = Color.IndianRed;
                        lblI2.ForeColor = Color.Magenta;
                        lblN2.ForeColor = Color.Lime;
                        lblG.ForeColor = Color.Green;

                        break;




                }
                if (Num == 8)
                    Num = 0;


            }
        }

        private void btnBlue_Click_1(object sender, EventArgs e)
        {

            {
                myColor = "Blue";
            }
        }

        private void btnYellow_Click_1(object sender, EventArgs e)
        {

            {
                myColor = "Yellow";
            }
        }

        private void btnGreen_Click_1(object sender, EventArgs e)
        {

            {
                myColor = "Green";
            }
        }

        private void btnCyan_Click_1(object sender, EventArgs e)
        {


                myColor = "Cyan";
         
        }

        private void print_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            {
                myColor = "Brown";
            }
        }

        private void btnRect_Click_1(object sender, EventArgs e)
        {

                IsRectangle = true;
                IsEllipes = false;
      
        }

        private void btnElp_Click(object sender, EventArgs e)
        {
            IsEllipes = true;
            IsRectangle = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {


            SizeH = 5;
            SizeW = 5;

        }

        private void btn10_Click_1(object sender, EventArgs e)
        {

            SizeH = 10;
            SizeW = 10;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            {

                SizeH = 15;
                SizeW = 15;

            }
        }

        private void btn20_Click_1(object sender, EventArgs e)
        {

            {


                SizeH = 20;
                SizeW = 20;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            {

                SizeH = 25;
                SizeW = 25;

            }
        }

        private void btn30_Click_1(object sender, EventArgs e)
        {

            {


                SizeH = 30;
                SizeW = 30;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myColor = "Remove";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form10 f1 = new Form10(0);
            f1.Show();
        }




        








    }
}

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
    public partial class mazegame : Form
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
        public mazegame(int _s)
        {
            this.s = _s;
            InitializeComponent();
            KeyDown +=  new KeyEventHandler(Form2_KeyDown);
    

            Player.Location = new Point(23, 14);
        }

        int counter = 90;

        //تحكم في الفوطبول ع حسب اتجاهات يا ويلك ي زهره ادا فهمتي لاني شرحت اكثر من مليون مرة
        void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = Player.Location.X;
            int y = Player.Location.Y;
            mazegame form = new mazegame(s);
            if (e.KeyCode == Keys.Right)
            {
                #region rightkey

                Rightkey.rightkey(Player, Box1);
                Rightkey.rightkey(Player, Box2);
                Rightkey.rightkey(Player, Box3);
                Rightkey.rightkey(Player, Box4);
                Rightkey.rightkey(Player, Box5);
                Rightkey.rightkey(Player, Box6);
                Rightkey.rightkey(Player, Box7);
                Rightkey.rightkey(Player, Box8);
                Rightkey.rightkey(Player, Box9);
                Rightkey.rightkey(Player, Box10);
                Rightkey.rightkey(Player, Box11);
                Rightkey.rightkey(Player, Box12);
                Rightkey.rightkey(Player, Box13);
                Rightkey.rightkey(Player, Box14);
                Rightkey.rightkey(Player, Box15);
                Rightkey.rightkey(Player, Box16);
                Rightkey.rightkey(Player, Box17);
                Rightkey.rightkey(Player, Box18);
                Rightkey.rightkey(Player, Box19);
                Rightkey.rightkey(Player, Box20);
                Rightkey.rightkey(Player, Box21);
                Rightkey.rightkey(Player, Box22);
                Rightkey.rightkey(Player, Box23);
                Rightkey.rightkey(Player, Box24);
                Rightkey.rightkey(Player, Box25);
                Rightkey.rightkey(Player, Box26);
                Rightkey.rightkey(Player, Box27);
                Rightkey.rightkey(Player, Box28);
                Rightkey.rightkey(Player, Box29);
                Rightkey.rightkey(Player, Box30);
                Rightkey.rightkey(Player, Box31);
                Rightkey.rightkey(Player, Box32);
                Rightkey.rightkey(Player, Box33);
                Rightkey.rightkey(Player, Box34);
                Rightkey.rightkey(Player, Box35);
                Rightkey.rightkey(Player, Box36);
                Rightkey.rightkey(Player, Box37);
                Rightkey.rightkey(Player, Box38);
                Rightkey.rightkey(Player, Box39);
                Rightkey.rightkey(Player, Box40);
                Rightkey.rightkey(Player, Box41);
                Rightkey.rightkey(Player, Box42);
                Rightkey.rightkey(Player, Box43);
                Rightkey.rightkey(Player, Box44);
                Rightkey.rightkey(Player, Box45);
                Rightkey.rightkey(Player, Box46);
                Rightkey.rightkey(Player, Box47);
                Rightkey.rightkey(Player, Box48);
                Rightkey.rightkey(Player, Box49);
                Rightkey.rightkey(Player, Box50);
                Rightkey.rightkey(Player, Box51);
                Rightkey.rightkey(Player, Box52);
                Rightkey.rightkey(Player, Box53);
                Rightkey.rightkey(Player, Box54);
                Rightkey.rightkey(Player, Box55);
                Rightkey.rightkey(Player, Box56);
                Rightkey.rightkey(Player, Box57);
                Rightkey.rightkey(Player, Box58);
                Rightkey.rightkey(Player, Box59);
                Rightkey.rightkey(Player, Box60);
                Rightkey.rightkey(Player, Box61);
                Rightkey.rightkey(Player, scoress);
                Rightkey.rightkey(Player, Box63);
                Rightkey.rightkey(Player, Box64);
                Rightkey.rightkey(Player, Box65);
                Rightkey.rightkey(Player, Box66);
                Rightkey.rightkey(Player, Box67);
                Rightkey.rightkey(Player, Box68);
                Rightkey.rightkey(Player, Box69);
                Rightkey.rightkey(Player, Box70);
                Rightkey.rightkey(Player, Box71);
                Rightkey.rightkey(Player, Box72);
                Rightkey.rightkey(Player, Box73);
                Rightkey.rightkey(Player, Box74);
                Rightkey.rightkey(Player, Box75);
                Rightkey.rightkey(Player, Box76);
               Rightkey.rightkey(Player, Box77);
                Rightkey.rightkey(Player, Box78);
                #endregion

                Finishes.finish1(Player, Finish, form);
                Addscore.score(scoress);
                playermove.playerright(Player);
            }
            else if (e.KeyCode == Keys.Left)
            {


                #region leftkey
                Rightkey.leftkey(Player, Box1);
                Rightkey.leftkey(Player, Box2);
                Rightkey.leftkey(Player, Box3);
                Rightkey.leftkey(Player, Box4);
                Rightkey.leftkey(Player, Box5);
                Rightkey.leftkey(Player, Box6);
                Rightkey.leftkey(Player, Box7);
                Rightkey.leftkey(Player, Box8);
                Rightkey.leftkey(Player, Box9);
                Rightkey.leftkey(Player, Box10);
                Rightkey.leftkey(Player, Box11);
                Rightkey.leftkey(Player, Box12);
                Rightkey.leftkey(Player, Box13);
                Rightkey.leftkey(Player, Box14);
                Rightkey.leftkey(Player, Box15);
                Rightkey.leftkey(Player, Box16);
                Rightkey.leftkey(Player, Box17);
                Rightkey.leftkey(Player, Box18);
                Rightkey.leftkey(Player, Box19);
                Rightkey.leftkey(Player, Box20);
                Rightkey.leftkey(Player, Box21);
                Rightkey.leftkey(Player, Box22);
                Rightkey.leftkey(Player, Box23);
                Rightkey.leftkey(Player, Box24);
                Rightkey.leftkey(Player, Box25);
                Rightkey.leftkey(Player, Box26);
                Rightkey.leftkey(Player, Box27);
                Rightkey.leftkey(Player, Box28);
                Rightkey.leftkey(Player, Box29);
                Rightkey.leftkey(Player, Box30);
                Rightkey.leftkey(Player, Box31);
                Rightkey.leftkey(Player, Box32);
                Rightkey.leftkey(Player, Box33);
                Rightkey.leftkey(Player, Box34);
                Rightkey.leftkey(Player, Box35);
                Rightkey.leftkey(Player, Box36);
                Rightkey.leftkey(Player, Box37);
                Rightkey.leftkey(Player, Box38);
                Rightkey.leftkey(Player, Box39);
                Rightkey.leftkey(Player, Box40);
                Rightkey.leftkey(Player, Box41);
                Rightkey.leftkey(Player, Box42);
                Rightkey.leftkey(Player, Box43);
                Rightkey.leftkey(Player, Box44);
                Rightkey.leftkey(Player, Box45);
                Rightkey.leftkey(Player, Box46);
                Rightkey.leftkey(Player, Box47);
                Rightkey.leftkey(Player, Box48);
                Rightkey.leftkey(Player, Box49);
                Rightkey.leftkey(Player, Box50);
                Rightkey.leftkey(Player, Box51);
                Rightkey.leftkey(Player, Box52);
                Rightkey.leftkey(Player, Box53);
                Rightkey.leftkey(Player, Box54);
                Rightkey.leftkey(Player, Box55);
                Rightkey.leftkey(Player, Box56);
                Rightkey.leftkey(Player, Box57);
                Rightkey.leftkey(Player, Box58);
                Rightkey.leftkey(Player, Box59);
                Rightkey.leftkey(Player, Box60);
                Rightkey.leftkey(Player, Box61);
                Rightkey.leftkey(Player, scoress);
                Rightkey.leftkey(Player, Box63);
                Rightkey.leftkey(Player, Box64);
                Rightkey.leftkey(Player, Box65);
                Rightkey.leftkey(Player, Box66);
                Rightkey.leftkey(Player, Box67);
                Rightkey.leftkey(Player, Box68);
                Rightkey.leftkey(Player, Box69);
                Rightkey.leftkey(Player, Box70);
                Rightkey.leftkey(Player, Box71);
                Rightkey.leftkey(Player, Box72);
                Rightkey.leftkey(Player, Box73);
                Rightkey.leftkey(Player, Box74);
                Rightkey.leftkey(Player, Box75);
                Rightkey.leftkey(Player, Box76);
           Rightkey.leftkey(Player, Box77);
                Rightkey.leftkey(Player, Box78);

                #endregion
                Finishes.finish1(Player, Finish, form);
                Addscore.score(scoress);
                playermove.playerleft(Player);

            }
            else if (e.KeyCode == Keys.Up)
            {

                #region upkey
                Rightkey.upkey(Player, Box1);
                Rightkey.upkey(Player, Box2);
                Rightkey.upkey(Player, Box3);
                Rightkey.upkey(Player, Box4);
                Rightkey.upkey(Player, Box5);
                Rightkey.upkey(Player, Box6);
                Rightkey.upkey(Player, Box7);
                Rightkey.upkey(Player, Box8);
                Rightkey.upkey(Player, Box9);
                Rightkey.upkey(Player, Box10);
                Rightkey.upkey(Player, Box11);
                Rightkey.upkey(Player, Box12);
                Rightkey.upkey(Player, Box13);
                Rightkey.upkey(Player, Box14);
                Rightkey.upkey(Player, Box15);
                Rightkey.upkey(Player, Box16);
                Rightkey.upkey(Player, Box17);
                Rightkey.upkey(Player, Box18);
                Rightkey.upkey(Player, Box19);
                Rightkey.upkey(Player, Box20);
                Rightkey.upkey(Player, Box21);
                Rightkey.upkey(Player, Box22);
                Rightkey.upkey(Player, Box23);
                Rightkey.upkey(Player, Box24);
                Rightkey.upkey(Player, Box25);
                Rightkey.upkey(Player, Box26);
                Rightkey.upkey(Player, Box27);
                Rightkey.upkey(Player, Box28);
                Rightkey.upkey(Player, Box29);
                Rightkey.upkey(Player, Box30);
                Rightkey.upkey(Player, Box31);
                Rightkey.upkey(Player, Box32);
                Rightkey.upkey(Player, Box33);
                Rightkey.upkey(Player, Box34);
                Rightkey.upkey(Player, Box35);
                Rightkey.upkey(Player, Box36);
                Rightkey.upkey(Player, Box37);
                Rightkey.upkey(Player, Box38);
                Rightkey.upkey(Player, Box39);
                Rightkey.upkey(Player, Box40);
                Rightkey.upkey(Player, Box41);
                Rightkey.upkey(Player, Box42);
                Rightkey.upkey(Player, Box43);
                Rightkey.upkey(Player, Box44);
                Rightkey.upkey(Player, Box45);
                Rightkey.upkey(Player, Box46);
                Rightkey.upkey(Player, Box47);
                Rightkey.upkey(Player, Box48);
                Rightkey.upkey(Player, Box49);
                Rightkey.upkey(Player, Box50);
                Rightkey.upkey(Player, Box51);
                Rightkey.upkey(Player, Box52);
                Rightkey.upkey(Player, Box53);
                Rightkey.upkey(Player, Box54);
                Rightkey.upkey(Player, Box55);
                Rightkey.upkey(Player, Box56);
                Rightkey.upkey(Player, Box57);
                Rightkey.upkey(Player, Box58);
                Rightkey.upkey(Player, Box59);
                Rightkey.upkey(Player, Box60);
                Rightkey.upkey(Player, Box61);
                Rightkey.upkey(Player, scoress);
                Rightkey.upkey(Player, Box63);
                Rightkey.upkey(Player, Box64);
                Rightkey.upkey(Player, Box65);
                Rightkey.upkey(Player, Box66);
                Rightkey.upkey(Player, Box67);
                Rightkey.upkey(Player, Box68);
                Rightkey.upkey(Player, Box69);
                Rightkey.upkey(Player, Box70);
                Rightkey.upkey(Player, Box71);
                Rightkey.upkey(Player, Box72);
                Rightkey.upkey(Player, Box73);
                Rightkey.upkey(Player, Box74);
                Rightkey.upkey(Player, Box75);
                Rightkey.upkey(Player, Box76);
           //     Rightkey.upkey(Player, Box77);
                Rightkey.upkey(Player, Box78);


                #endregion
                Finishes.finish1(Player, Finish, form);
                Addscore.score(scoress);
                playermove.playerup(Player);

            }
            else if (e.KeyCode == Keys.Down)
            {
                #region downkey
                Rightkey.downkey(Player, Box1);
                Rightkey.downkey(Player, Box2);
                Rightkey.downkey(Player, Box3);
                Rightkey.downkey(Player, Box4);
                Rightkey.downkey(Player, Box5);
                Rightkey.downkey(Player, Box6);
                Rightkey.downkey(Player, Box7);
                Rightkey.downkey(Player, Box8);
                Rightkey.downkey(Player, Box9);
                Rightkey.downkey(Player, Box10);
                Rightkey.downkey(Player, Box11);
                Rightkey.downkey(Player, Box12);
                Rightkey.downkey(Player, Box13);
                Rightkey.downkey(Player, Box14);
                Rightkey.downkey(Player, Box15);
                Rightkey.downkey(Player, Box16);
                Rightkey.downkey(Player, Box17);
                Rightkey.downkey(Player, Box18);
                Rightkey.downkey(Player, Box19);
                Rightkey.downkey(Player, Box20);
                Rightkey.downkey(Player, Box21);
                Rightkey.downkey(Player, Box22);
                Rightkey.downkey(Player, Box23);
                Rightkey.downkey(Player, Box24);
                Rightkey.downkey(Player, Box25);
                Rightkey.downkey(Player, Box26);
                Rightkey.downkey(Player, Box27);
                Rightkey.downkey(Player, Box28);
                Rightkey.downkey(Player, Box29);
                Rightkey.downkey(Player, Box30);
                Rightkey.downkey(Player, Box31);
                Rightkey.downkey(Player, Box32);
                Rightkey.downkey(Player, Box33);
                Rightkey.downkey(Player, Box34);
                Rightkey.downkey(Player, Box35);
                Rightkey.downkey(Player, Box36);
                Rightkey.downkey(Player, Box37);
                Rightkey.downkey(Player, Box38);
                Rightkey.downkey(Player, Box39);
                Rightkey.downkey(Player, Box40);
                Rightkey.downkey(Player, Box41);
                Rightkey.downkey(Player, Box42);
                Rightkey.downkey(Player, Box43);
                Rightkey.downkey(Player, Box44);
                Rightkey.downkey(Player, Box45);
                Rightkey.downkey(Player, Box46);
                Rightkey.downkey(Player, Box47);
                Rightkey.downkey(Player, Box48);
                Rightkey.downkey(Player, Box49);
                Rightkey.downkey(Player, Box50);
                Rightkey.downkey(Player, Box51);
                Rightkey.downkey(Player, Box52);
                Rightkey.downkey(Player, Box53);
                Rightkey.downkey(Player, Box54);
                Rightkey.downkey(Player, Box55);
                Rightkey.downkey(Player, Box56);
                Rightkey.downkey(Player, Box57);
                Rightkey.downkey(Player, Box58);
                Rightkey.downkey(Player, Box59);
                Rightkey.downkey(Player, Box60);
                Rightkey.downkey(Player, Box61);
                Rightkey.downkey(Player, scoress);
                Rightkey.downkey(Player, Box63);
                Rightkey.downkey(Player, Box64);
                Rightkey.downkey(Player, Box65);
                Rightkey.downkey(Player, Box66);
                Rightkey.downkey(Player, Box67);
                Rightkey.downkey(Player, Box68);
                Rightkey.downkey(Player, Box69);
                Rightkey.downkey(Player, Box70);
                Rightkey.downkey(Player, Box71);
                Rightkey.downkey(Player, Box72);
                Rightkey.downkey(Player, Box73);
                Rightkey.downkey(Player, Box74);
                Rightkey.downkey(Player, Box75);
                Rightkey.downkey(Player, Box76);
                //Rightkey.downkey(Player, Box77);
                Rightkey.downkey(Player, Box78);

                #endregion

                Finishes.finish1(Player, Finish, form);

                Addscore.score(scoress);
                playermove.playerdown(Player);
            }

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (Player.Bounds.IntersectsWith(Finish.Bounds))
            {
                Time.Stop();
                DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Time.Stop();
                    mazegame myNewForm = new mazegame(s);
                    this.Hide();
                    myNewForm.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Time.Stop();
                    this.Hide();
                    game f1 = new game(s);
                    f1.Show();
                }
            }

            if (counter == -1)
            {
                counter = 90;
                Time.Stop();
                MessageBox.Show("game over");
                mazegame myNewForm = new mazegame(s);
                this.Hide();
                myNewForm.ShowDialog();
               // this.Hide();
            }
            else
                Timerclock.Text = Convert.ToString(counter--);
        }




        private void mazegame_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                System.Media.SoundPlayer play = new System.Media.SoundPlayer();
                play.SoundLocation = "music\\4.wav";
                play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Time.Stop();
            this.Hide();
            game f1 = new game(s);
            f1.Show();
        }



  


    }
}

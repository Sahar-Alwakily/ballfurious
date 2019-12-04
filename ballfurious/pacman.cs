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
    public partial class pacman : Form
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
        public pacman(int _s)
        {
            this.s = _s;
            InitializeComponent();
           KeyDown += new KeyEventHandler(pacman_KeyDown);

                
        }

        int BonusCounter = 0;
        //Form1 GameForm = new Form1();
        bool PacmanUp;
        bool PacmanDown;
        bool PacmanRight = true;
        bool PacmanLeft;

        bool Ghost1Up;
        bool Ghost1Down;
        bool Ghost1Right;
        bool Ghost1Left = true;

        bool Ghost2Up;
        bool Ghost2Down;
        bool Ghost2Right;
        bool Ghost2Left = true;

        bool Ghost3Up;
        bool Ghost3Down;
        bool Ghost3Right;
        bool Ghost3Left = true;

        bool Ghost4Up;
        bool Ghost4Down;
        bool Ghost4Right;
        bool Ghost4Left = true;
        
        private void pacman_KeyDown(object sender, KeyEventArgs e)
        {
            Pacman1.Visible = true;
            if (e.KeyCode == Keys.Up)
            {
                PacmanUp = true;
                PacmanDown = false;
                PacmanLeft = false;
                PacmanRight = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                PacmanUp = false;
                PacmanDown = true;
                PacmanLeft = false;
                PacmanRight = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                PacmanUp = false;
                PacmanDown = false;
                PacmanLeft = false;
                PacmanRight = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                PacmanUp = false;
                PacmanDown = false;
                PacmanLeft = true;
                PacmanRight = false;
            }
        }

        private void PacmanTimer_Tick(object sender, EventArgs e)
        {
            if (PacmanUp == true)
            {
                int Y = 3;
                Pacman1.Top -= Y;
                #region UpCollision
                Collision.UpKey(Pacman1, Wall1, PacmanUp);
                Collision.UpKey(Pacman1, Wall2, PacmanUp);
                Collision.UpKey(Pacman1, Wall3, PacmanUp);
                Collision.UpKey(Pacman1, Wall4, PacmanUp);
                Collision.UpKey(Pacman1, Wall5, PacmanUp);
                Collision.UpKey(Pacman1, Wall6, PacmanUp);
                Collision.UpKey(Pacman1, Wall7, PacmanUp);
                Collision.UpKey(Pacman1, Wall8, PacmanUp);
                Collision.UpKey(Pacman1, Wall9, PacmanUp);
                Collision.UpKey(Pacman1, Wall10, PacmanUp);
                Collision.UpKey(Pacman1, Wall11, PacmanUp);
                Collision.UpKey(Pacman1, Wall12, PacmanUp);
                Collision.UpKey(Pacman1, Wall13, PacmanUp);
                Collision.UpKey(Pacman1, Wall14, PacmanUp);
                Collision.UpKey(Pacman1, Wall15, PacmanUp);
                Collision.UpKey(Pacman1, Wall16, PacmanUp);
                Collision.UpKey(Pacman1, Wall17, PacmanUp);
                Collision.UpKey(Pacman1, Wall18, PacmanUp);
                Collision.UpKey(Pacman1, Wall19, PacmanUp);
                Collision.UpKey(Pacman1, Wall20, PacmanUp);
                Collision.UpKey(Pacman1, Wall21, PacmanUp);
                Collision.UpKey(Pacman1, Wall22, PacmanUp);
                Collision.UpKey(Pacman1, Wall23, PacmanUp);
                Collision.UpKey(Pacman1, Wall24, PacmanUp);
                Collision.UpKey(Pacman1, Wall25, PacmanUp);
                Collision.UpKey(Pacman1, Wall26, PacmanUp);
                Collision.UpKey(Pacman1, Wall27, PacmanUp);
                #endregion
                #region UpBonusCollision
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus1, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus2, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus3, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus4, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus5, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus6, Pacman1, BonusTimer, Score);
                #endregion
                #region UpSeedCollision
                Collision.SeedCollision(Seed1, Pacman1, Score);
                Collision.SeedCollision(Seed2, Pacman1, Score);
                Collision.SeedCollision(Seed3, Pacman1, Score);
                Collision.SeedCollision(Seed4, Pacman1, Score);
                Collision.SeedCollision(Seed5, Pacman1, Score);
                Collision.SeedCollision(Seed6, Pacman1, Score);
                Collision.SeedCollision(Seed7, Pacman1, Score);
                Collision.SeedCollision(Seed8, Pacman1, Score);
                Collision.SeedCollision(Seed9, Pacman1, Score);
                Collision.SeedCollision(Seed10, Pacman1, Score);
                Collision.SeedCollision(Seed11, Pacman1, Score);
                Collision.SeedCollision(Seed12, Pacman1, Score);
                Collision.SeedCollision(Seed13, Pacman1, Score);
                Collision.SeedCollision(Seed14, Pacman1, Score);
                Collision.SeedCollision(Seed15, Pacman1, Score);
                Collision.SeedCollision(Seed16, Pacman1, Score);
                Collision.SeedCollision(Seed17, Pacman1, Score);
                Collision.SeedCollision(Seed18, Pacman1, Score);
                Collision.SeedCollision(Seed19, Pacman1, Score);
                Collision.SeedCollision(Seed20, Pacman1, Score);
                Collision.SeedCollision(Seed21, Pacman1, Score);
                Collision.SeedCollision(Seed22, Pacman1, Score);
                Collision.SeedCollision(Seed23, Pacman1, Score);
                Collision.SeedCollision(Seed24, Pacman1, Score);
                Collision.SeedCollision(Seed25, Pacman1, Score);
                Collision.SeedCollision(Seed26, Pacman1, Score);
                Collision.SeedCollision(Seed27, Pacman1, Score);
                Collision.SeedCollision(Seed28, Pacman1, Score);
                Collision.SeedCollision(Seed29, Pacman1, Score);
                Collision.SeedCollision(Seed30, Pacman1, Score);
                Collision.SeedCollision(Seed31, Pacman1, Score);
                Collision.SeedCollision(Seed32, Pacman1, Score);
                Collision.SeedCollision(Seed33, Pacman1, Score);
                Collision.SeedCollision(Seed34, Pacman1, Score);
                Collision.SeedCollision(Seed35, Pacman1, Score);
                Collision.SeedCollision(Seed36, Pacman1, Score);
                Collision.SeedCollision(Seed37, Pacman1, Score);
                Collision.SeedCollision(Seed38, Pacman1, Score);
                Collision.SeedCollision(Seed39, Pacman1, Score);
                Collision.SeedCollision(Seed40, Pacman1, Score);
                Collision.SeedCollision(Seed41, Pacman1, Score);
                Collision.SeedCollision(Seed42, Pacman1, Score);
                Collision.SeedCollision(Seed43, Pacman1, Score);
                Collision.SeedCollision(Seed44, Pacman1, Score);
                Collision.SeedCollision(Seed45, Pacman1, Score);
                Collision.SeedCollision(Seed46, Pacman1, Score);
                Collision.SeedCollision(Seed47, Pacman1, Score);
                Collision.SeedCollision(Seed48, Pacman1, Score);
                Collision.SeedCollision(Seed49, Pacman1, Score);
                Collision.SeedCollision(Seed50, Pacman1, Score);
                Collision.SeedCollision(Seed51, Pacman1, Score);
                Collision.SeedCollision(Seed52, Pacman1, Score);
                Collision.SeedCollision(Seed53, Pacman1, Score);
                Collision.SeedCollision(Seed54, Pacman1, Score);
                Collision.SeedCollision(Seed55, Pacman1, Score);
                Collision.SeedCollision(Seed56, Pacman1, Score);
                Collision.SeedCollision(Seed57, Pacman1, Score);
                Collision.SeedCollision(Seed58, Pacman1, Score);
                Collision.SeedCollision(Seed59, Pacman1, Score);
                Collision.SeedCollision(Seed60, Pacman1, Score);
                Collision.SeedCollision(Seed61, Pacman1, Score);
                Collision.SeedCollision(Seed62, Pacman1, Score);
                Collision.SeedCollision(Seed63, Pacman1, Score);
                Collision.SeedCollision(Seed64, Pacman1, Score);
                Collision.SeedCollision(Seed65, Pacman1, Score);
                Collision.SeedCollision(Seed66, Pacman1, Score);

                #endregion
                Collision.PacmanCollideGhost(Ghost1, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost2, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost3, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost4, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);
            }
            else if (PacmanDown == true)
            {
                int Y = 3;
                Pacman1.Top += Y;
                #region DownCollision
                Collision.DownKey(Pacman1, Wall1, PacmanDown);
                Collision.DownKey(Pacman1, Wall2, PacmanDown);
                Collision.DownKey(Pacman1, Wall3, PacmanDown);
                Collision.DownKey(Pacman1, Wall4, PacmanDown);
                Collision.DownKey(Pacman1, Wall5, PacmanDown);
                Collision.DownKey(Pacman1, Wall6, PacmanDown);
                Collision.DownKey(Pacman1, Wall7, PacmanDown);
                Collision.DownKey(Pacman1, Wall8, PacmanDown);
                Collision.DownKey(Pacman1, Wall9, PacmanDown);
                Collision.DownKey(Pacman1, Wall10, PacmanDown);
                Collision.DownKey(Pacman1, Wall11, PacmanDown);
                Collision.DownKey(Pacman1, Wall12, PacmanDown);
                Collision.DownKey(Pacman1, Wall13, PacmanDown);
                Collision.DownKey(Pacman1, Wall14, PacmanDown);
                Collision.DownKey(Pacman1, Wall15, PacmanDown);
                Collision.DownKey(Pacman1, Wall16, PacmanDown);
                Collision.DownKey(Pacman1, Wall17, PacmanDown);
                Collision.DownKey(Pacman1, Wall18, PacmanDown);
                Collision.DownKey(Pacman1, Wall19, PacmanDown);
                Collision.DownKey(Pacman1, Wall20, PacmanDown);
                Collision.DownKey(Pacman1, Wall21, PacmanDown);
                Collision.DownKey(Pacman1, Wall22, PacmanDown);
                Collision.DownKey(Pacman1, Wall23, PacmanDown);
                Collision.DownKey(Pacman1, Wall24, PacmanDown);
                Collision.DownKey(Pacman1, Wall25, PacmanDown);
                Collision.DownKey(Pacman1, Wall26, PacmanDown);
                Collision.DownKey(Pacman1, Wall27, PacmanDown);
                #endregion
                #region DownBonusCollision
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus1, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus2, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus3, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus4, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus5, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus6, Pacman1, BonusTimer, Score);
                #endregion
                #region DownSeedCollision
                Collision.SeedCollision(Seed1, Pacman1, Score);
                Collision.SeedCollision(Seed2, Pacman1, Score);
                Collision.SeedCollision(Seed3, Pacman1, Score);
                Collision.SeedCollision(Seed4, Pacman1, Score);
                Collision.SeedCollision(Seed5, Pacman1, Score);
                Collision.SeedCollision(Seed6, Pacman1, Score);
                Collision.SeedCollision(Seed7, Pacman1, Score);
                Collision.SeedCollision(Seed8, Pacman1, Score);
                Collision.SeedCollision(Seed9, Pacman1, Score);
                Collision.SeedCollision(Seed10, Pacman1, Score);
                Collision.SeedCollision(Seed11, Pacman1, Score);
                Collision.SeedCollision(Seed12, Pacman1, Score);
                Collision.SeedCollision(Seed13, Pacman1, Score);
                Collision.SeedCollision(Seed14, Pacman1, Score);
                Collision.SeedCollision(Seed15, Pacman1, Score);
                Collision.SeedCollision(Seed16, Pacman1, Score);
                Collision.SeedCollision(Seed17, Pacman1, Score);
                Collision.SeedCollision(Seed18, Pacman1, Score);
                Collision.SeedCollision(Seed19, Pacman1, Score);
                Collision.SeedCollision(Seed20, Pacman1, Score);
                Collision.SeedCollision(Seed21, Pacman1, Score);
                Collision.SeedCollision(Seed22, Pacman1, Score);
                Collision.SeedCollision(Seed23, Pacman1, Score);
                Collision.SeedCollision(Seed24, Pacman1, Score);
                Collision.SeedCollision(Seed25, Pacman1, Score);
                Collision.SeedCollision(Seed26, Pacman1, Score);
                Collision.SeedCollision(Seed27, Pacman1, Score);
                Collision.SeedCollision(Seed28, Pacman1, Score);
                Collision.SeedCollision(Seed29, Pacman1, Score);
                Collision.SeedCollision(Seed30, Pacman1, Score);
                Collision.SeedCollision(Seed31, Pacman1, Score);
                Collision.SeedCollision(Seed32, Pacman1, Score);
                Collision.SeedCollision(Seed33, Pacman1, Score);
                Collision.SeedCollision(Seed34, Pacman1, Score);
                Collision.SeedCollision(Seed35, Pacman1, Score);
                Collision.SeedCollision(Seed36, Pacman1, Score);
                Collision.SeedCollision(Seed37, Pacman1, Score);
                Collision.SeedCollision(Seed38, Pacman1, Score);
                Collision.SeedCollision(Seed39, Pacman1, Score);
                Collision.SeedCollision(Seed40, Pacman1, Score);
                Collision.SeedCollision(Seed41, Pacman1, Score);
                Collision.SeedCollision(Seed42, Pacman1, Score);
                Collision.SeedCollision(Seed43, Pacman1, Score);
                Collision.SeedCollision(Seed44, Pacman1, Score);
                Collision.SeedCollision(Seed45, Pacman1, Score);
                Collision.SeedCollision(Seed46, Pacman1, Score);
                Collision.SeedCollision(Seed47, Pacman1, Score);
                Collision.SeedCollision(Seed48, Pacman1, Score);
                Collision.SeedCollision(Seed49, Pacman1, Score);
                Collision.SeedCollision(Seed50, Pacman1, Score);
                Collision.SeedCollision(Seed51, Pacman1, Score);
                Collision.SeedCollision(Seed52, Pacman1, Score);
                Collision.SeedCollision(Seed53, Pacman1, Score);
                Collision.SeedCollision(Seed54, Pacman1, Score);
                Collision.SeedCollision(Seed55, Pacman1, Score);
                Collision.SeedCollision(Seed56, Pacman1, Score);
                Collision.SeedCollision(Seed57, Pacman1, Score);
                Collision.SeedCollision(Seed58, Pacman1, Score);
                Collision.SeedCollision(Seed59, Pacman1, Score);
                Collision.SeedCollision(Seed60, Pacman1, Score);
                Collision.SeedCollision(Seed61, Pacman1, Score);
                Collision.SeedCollision(Seed62, Pacman1, Score);
                Collision.SeedCollision(Seed63, Pacman1, Score);
                Collision.SeedCollision(Seed64, Pacman1, Score);
                Collision.SeedCollision(Seed65, Pacman1, Score);
                Collision.SeedCollision(Seed66, Pacman1, Score);

                #endregion

                Collision.PacmanCollideGhost(Ghost1, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost2, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost3, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost4, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);
            }
            else if (PacmanLeft == true)
            {
                int X = 3;
                Pacman1.Left -= X;
                #region LeftCollision
                Collision.LeftKey(Pacman1, Wall1, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall2, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall3, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall4, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall5, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall6, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall7, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall8, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall9, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall10, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall11, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall12, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall13, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall14, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall15, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall16, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall17, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall18, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall19, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall20, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall21, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall22, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall23, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall24, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall25, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall26, PacmanLeft);
                Collision.LeftKey(Pacman1, Wall27, PacmanLeft);
                #endregion
                #region LeftBonusCollision
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus1, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus2, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus3, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus4, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus5, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus6, Pacman1, BonusTimer, Score);
                #endregion
                #region LeftSeedCollision
                Collision.SeedCollision(Seed1, Pacman1, Score);
                Collision.SeedCollision(Seed2, Pacman1, Score);
                Collision.SeedCollision(Seed3, Pacman1, Score);
                Collision.SeedCollision(Seed4, Pacman1, Score);
                Collision.SeedCollision(Seed5, Pacman1, Score);
                Collision.SeedCollision(Seed6, Pacman1, Score);
                Collision.SeedCollision(Seed7, Pacman1, Score);
                Collision.SeedCollision(Seed8, Pacman1, Score);
                Collision.SeedCollision(Seed9, Pacman1, Score);
                Collision.SeedCollision(Seed10, Pacman1, Score);
                Collision.SeedCollision(Seed11, Pacman1, Score);
                Collision.SeedCollision(Seed12, Pacman1, Score);
                Collision.SeedCollision(Seed13, Pacman1, Score);
                Collision.SeedCollision(Seed14, Pacman1, Score);
                Collision.SeedCollision(Seed15, Pacman1, Score);
                Collision.SeedCollision(Seed16, Pacman1, Score);
                Collision.SeedCollision(Seed17, Pacman1, Score);
                Collision.SeedCollision(Seed18, Pacman1, Score);
                Collision.SeedCollision(Seed19, Pacman1, Score);
                Collision.SeedCollision(Seed20, Pacman1, Score);
                Collision.SeedCollision(Seed21, Pacman1, Score);
                Collision.SeedCollision(Seed22, Pacman1, Score);
                Collision.SeedCollision(Seed23, Pacman1, Score);
                Collision.SeedCollision(Seed24, Pacman1, Score);
                Collision.SeedCollision(Seed25, Pacman1, Score);
                Collision.SeedCollision(Seed26, Pacman1, Score);
                Collision.SeedCollision(Seed27, Pacman1, Score);
                Collision.SeedCollision(Seed28, Pacman1, Score);
                Collision.SeedCollision(Seed29, Pacman1, Score);
                Collision.SeedCollision(Seed30, Pacman1, Score);
                Collision.SeedCollision(Seed31, Pacman1, Score);
                Collision.SeedCollision(Seed32, Pacman1, Score);
                Collision.SeedCollision(Seed33, Pacman1, Score);
                Collision.SeedCollision(Seed34, Pacman1, Score);
                Collision.SeedCollision(Seed35, Pacman1, Score);
                Collision.SeedCollision(Seed36, Pacman1, Score);
                Collision.SeedCollision(Seed37, Pacman1, Score);
                Collision.SeedCollision(Seed38, Pacman1, Score);
                Collision.SeedCollision(Seed39, Pacman1, Score);
                Collision.SeedCollision(Seed40, Pacman1, Score);
                Collision.SeedCollision(Seed41, Pacman1, Score);
                Collision.SeedCollision(Seed42, Pacman1, Score);
                Collision.SeedCollision(Seed43, Pacman1, Score);
                Collision.SeedCollision(Seed44, Pacman1, Score);
                Collision.SeedCollision(Seed45, Pacman1, Score);
                Collision.SeedCollision(Seed46, Pacman1, Score);
                Collision.SeedCollision(Seed47, Pacman1, Score);
                Collision.SeedCollision(Seed48, Pacman1, Score);
                Collision.SeedCollision(Seed49, Pacman1, Score);
                Collision.SeedCollision(Seed50, Pacman1, Score);
                Collision.SeedCollision(Seed51, Pacman1, Score);
                Collision.SeedCollision(Seed52, Pacman1, Score);
                Collision.SeedCollision(Seed53, Pacman1, Score);
                Collision.SeedCollision(Seed54, Pacman1, Score);
                Collision.SeedCollision(Seed55, Pacman1, Score);
                Collision.SeedCollision(Seed56, Pacman1, Score);
                Collision.SeedCollision(Seed57, Pacman1, Score);
                Collision.SeedCollision(Seed58, Pacman1, Score);
                Collision.SeedCollision(Seed59, Pacman1, Score);
                Collision.SeedCollision(Seed60, Pacman1, Score);
                Collision.SeedCollision(Seed61, Pacman1, Score);
                Collision.SeedCollision(Seed62, Pacman1, Score);
                Collision.SeedCollision(Seed63, Pacman1, Score);
                Collision.SeedCollision(Seed64, Pacman1, Score);
                Collision.SeedCollision(Seed65, Pacman1, Score);
                Collision.SeedCollision(Seed66, Pacman1, Score);

                #endregion

                Collision.PacmanCollideGhost(Ghost1, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost2, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost3, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost4, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

            }
            else if (PacmanRight == true)
            {
                int X = 3;
                Pacman1.Left += X;
                #region RightCollision
                Collision.RighteKey(Pacman1, Wall1, PacmanRight);
                Collision.RighteKey(Pacman1, Wall2, PacmanRight);
                Collision.RighteKey(Pacman1, Wall3, PacmanRight);
                Collision.RighteKey(Pacman1, Wall4, PacmanRight);
                Collision.RighteKey(Pacman1, Wall5, PacmanRight);
                Collision.RighteKey(Pacman1, Wall6, PacmanRight);
                Collision.RighteKey(Pacman1, Wall7, PacmanRight);
                Collision.RighteKey(Pacman1, Wall8, PacmanRight);
                Collision.RighteKey(Pacman1, Wall9, PacmanRight);
                Collision.RighteKey(Pacman1, Wall10, PacmanRight);
                Collision.RighteKey(Pacman1, Wall11, PacmanRight);
                Collision.RighteKey(Pacman1, Wall12, PacmanRight);
                Collision.RighteKey(Pacman1, Wall13, PacmanRight);
                Collision.RighteKey(Pacman1, Wall14, PacmanRight);
                Collision.RighteKey(Pacman1, Wall15, PacmanRight);
                Collision.RighteKey(Pacman1, Wall16, PacmanRight);
                Collision.RighteKey(Pacman1, Wall17, PacmanRight);
                Collision.RighteKey(Pacman1, Wall18, PacmanRight);
                Collision.RighteKey(Pacman1, Wall19, PacmanRight);
                Collision.RighteKey(Pacman1, Wall20, PacmanRight);
                Collision.RighteKey(Pacman1, Wall21, PacmanRight);
                Collision.RighteKey(Pacman1, Wall22, PacmanRight);
                Collision.RighteKey(Pacman1, Wall23, PacmanRight);
                Collision.RighteKey(Pacman1, Wall24, PacmanRight);
                Collision.RighteKey(Pacman1, Wall25, PacmanRight);
                Collision.RighteKey(Pacman1, Wall26, PacmanRight);
                Collision.RighteKey(Pacman1, Wall27, PacmanRight);
                #endregion
                #region RightBonusCollision
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus1, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus2, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus3, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus4, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus5, Pacman1, BonusTimer, Score);
                Collision.BonusCollide(Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, Bonus6, Pacman1, BonusTimer, Score);
                #endregion
                #region RightSeedCollision
                Collision.SeedCollision(Seed1, Pacman1, Score);
                Collision.SeedCollision(Seed2, Pacman1, Score);
                Collision.SeedCollision(Seed3, Pacman1, Score);
                Collision.SeedCollision(Seed4, Pacman1, Score);
                Collision.SeedCollision(Seed5, Pacman1, Score);
                Collision.SeedCollision(Seed6, Pacman1, Score);
                Collision.SeedCollision(Seed7, Pacman1, Score);
                Collision.SeedCollision(Seed8, Pacman1, Score);
                Collision.SeedCollision(Seed9, Pacman1, Score);
                Collision.SeedCollision(Seed10, Pacman1, Score);
                Collision.SeedCollision(Seed11, Pacman1, Score);
                Collision.SeedCollision(Seed12, Pacman1, Score);
                Collision.SeedCollision(Seed13, Pacman1, Score);
                Collision.SeedCollision(Seed14, Pacman1, Score);
                Collision.SeedCollision(Seed15, Pacman1, Score);
                Collision.SeedCollision(Seed16, Pacman1, Score);
                Collision.SeedCollision(Seed17, Pacman1, Score);
                Collision.SeedCollision(Seed18, Pacman1, Score);
                Collision.SeedCollision(Seed19, Pacman1, Score);
                Collision.SeedCollision(Seed20, Pacman1, Score);
                Collision.SeedCollision(Seed21, Pacman1, Score);
                Collision.SeedCollision(Seed22, Pacman1, Score);
                Collision.SeedCollision(Seed23, Pacman1, Score);
                Collision.SeedCollision(Seed24, Pacman1, Score);
                Collision.SeedCollision(Seed25, Pacman1, Score);
                Collision.SeedCollision(Seed26, Pacman1, Score);
                Collision.SeedCollision(Seed27, Pacman1, Score);
                Collision.SeedCollision(Seed28, Pacman1, Score);
                Collision.SeedCollision(Seed29, Pacman1, Score);
                Collision.SeedCollision(Seed30, Pacman1, Score);
                Collision.SeedCollision(Seed31, Pacman1, Score);
                Collision.SeedCollision(Seed32, Pacman1, Score);
                Collision.SeedCollision(Seed33, Pacman1, Score);
                Collision.SeedCollision(Seed34, Pacman1, Score);
                Collision.SeedCollision(Seed35, Pacman1, Score);
                Collision.SeedCollision(Seed36, Pacman1, Score);
                Collision.SeedCollision(Seed37, Pacman1, Score);
                Collision.SeedCollision(Seed38, Pacman1, Score);
                Collision.SeedCollision(Seed39, Pacman1, Score);
                Collision.SeedCollision(Seed40, Pacman1, Score);
                Collision.SeedCollision(Seed41, Pacman1, Score);
                Collision.SeedCollision(Seed42, Pacman1, Score);
                Collision.SeedCollision(Seed43, Pacman1, Score);
                Collision.SeedCollision(Seed44, Pacman1, Score);
                Collision.SeedCollision(Seed45, Pacman1, Score);
                Collision.SeedCollision(Seed46, Pacman1, Score);
                Collision.SeedCollision(Seed47, Pacman1, Score);
                Collision.SeedCollision(Seed48, Pacman1, Score);
                Collision.SeedCollision(Seed49, Pacman1, Score);
                Collision.SeedCollision(Seed50, Pacman1, Score);
                Collision.SeedCollision(Seed51, Pacman1, Score);
                Collision.SeedCollision(Seed52, Pacman1, Score);
                Collision.SeedCollision(Seed53, Pacman1, Score);
                Collision.SeedCollision(Seed54, Pacman1, Score);
                Collision.SeedCollision(Seed55, Pacman1, Score);
                Collision.SeedCollision(Seed56, Pacman1, Score);
                Collision.SeedCollision(Seed57, Pacman1, Score);
                Collision.SeedCollision(Seed58, Pacman1, Score);
                Collision.SeedCollision(Seed59, Pacman1, Score);
                Collision.SeedCollision(Seed60, Pacman1, Score);
                Collision.SeedCollision(Seed61, Pacman1, Score);
                Collision.SeedCollision(Seed62, Pacman1, Score);
                Collision.SeedCollision(Seed63, Pacman1, Score);
                Collision.SeedCollision(Seed64, Pacman1, Score);
                Collision.SeedCollision(Seed65, Pacman1, Score);
                Collision.SeedCollision(Seed66, Pacman1, Score);

                #endregion

                Collision.PacmanCollideGhost(Ghost1, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost2, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost3, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);

                Collision.PacmanCollideGhost(Ghost4, Pacman1, Ghost1Timer, Ghost2Timer, Ghost3Timer, Ghost4Timer, PacmanTimer, BonusTimer);
            }
        }

        private void pacman_KeyUp(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    PacmanUp = false;
            //}
            //else if (e.KeyCode == Keys.Down)
            //{
            //    PacmanDown = false;
            //}
            //else if (e.KeyCode == Keys.Right)
            //{
            //    PacmanRight = false;
            //}
            //else if (e.KeyCode == Keys.Left)
            //{
            //    PacmanLeft = false;
            //}
        }

        private void Ghost1Timer_Tick(object sender, EventArgs e)
        {

            {

                if (Ghost1Up == true)
                {
                    int Y = 1;
                    Ghost1.Top -= Y;
                    #region GhostUpCollision
                    #region Wall1
                    if (Ghost1.Bounds.IntersectsWith(Wall1.Bounds))
                    {
                        int Y1 = 5;
                        Ghost1.Top += Y1;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall2
                    if (Ghost1.Bounds.IntersectsWith(Wall2.Bounds))
                    {
                        int Y2 = 5;
                        Ghost1.Top += Y2;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall3
                    if (Ghost1.Bounds.IntersectsWith(Wall3.Bounds))
                    {
                        int Y3 = 5;
                        Ghost1.Top += Y3;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall4
                    if (Ghost1.Bounds.IntersectsWith(Wall4.Bounds))
                    {
                        int Y4 = 5;
                        Ghost1.Top += Y4;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall5
                    if (Ghost1.Bounds.IntersectsWith(Wall5.Bounds))
                    {
                        int Y5 = 5;
                        Ghost1.Top += Y5;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall6
                    if (Ghost1.Bounds.IntersectsWith(Wall6.Bounds))
                    {
                        int Y6 = 5;
                        Ghost1.Top += Y6;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall7
                    if (Ghost1.Bounds.IntersectsWith(Wall7.Bounds))
                    {
                        int Y7 = 5;
                        Ghost1.Top += Y7;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall8
                    if (Ghost1.Bounds.IntersectsWith(Wall8.Bounds))
                    {
                        int Y8 = 5;
                        Ghost1.Top += Y8;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall9
                    if (Ghost1.Bounds.IntersectsWith(Wall9.Bounds))
                    {
                        int Y9 = 5;
                        Ghost1.Top += Y9;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall10
                    if (Ghost1.Bounds.IntersectsWith(Wall10.Bounds))
                    {
                        int Y10 = 5;
                        Ghost1.Top += Y10;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall11
                    if (Ghost1.Bounds.IntersectsWith(Wall11.Bounds))
                    {
                        int Y11 = 5;
                        Ghost1.Top += Y11;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall12
                    if (Ghost1.Bounds.IntersectsWith(Wall12.Bounds))
                    {
                        int Y12 = 5;
                        Ghost1.Top += Y12;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall13
                    if (Ghost1.Bounds.IntersectsWith(Wall13.Bounds))
                    {
                        int Y13 = 5;
                        Ghost1.Top += Y13;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall14
                    if (Ghost1.Bounds.IntersectsWith(Wall14.Bounds))
                    {
                        int Y14 = 5;
                        Ghost1.Top += Y14;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall15
                    if (Ghost1.Bounds.IntersectsWith(Wall15.Bounds))
                    {
                        int Y15 = 5;
                        Ghost1.Top += Y15;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall16
                    if (Ghost1.Bounds.IntersectsWith(Wall16.Bounds))
                    {
                        int Y16 = 5;
                        Ghost1.Top += Y16;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall17
                    if (Ghost1.Bounds.IntersectsWith(Wall17.Bounds))
                    {
                        int Y17 = 5;
                        Ghost1.Top += Y17;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall18
                    if (Ghost1.Bounds.IntersectsWith(Wall18.Bounds))
                    {
                        int Y18 = 5;
                        Ghost1.Top += Y18;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall19
                    if (Ghost1.Bounds.IntersectsWith(Wall19.Bounds))
                    {
                        int Y19 = 5;
                        Ghost1.Top += Y19;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall20
                    if (Ghost1.Bounds.IntersectsWith(Wall20.Bounds))
                    {
                        int Y20 = 5;
                        Ghost1.Top += Y20;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall21
                    if (Ghost1.Bounds.IntersectsWith(Wall21.Bounds))
                    {
                        int Y21 = 5;
                        Ghost1.Top += Y21;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall22
                    if (Ghost1.Bounds.IntersectsWith(Wall22.Bounds))
                    {
                        int Y22 = 5;
                        Ghost1.Top += Y22;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall23
                    if (Ghost1.Bounds.IntersectsWith(Wall23.Bounds))
                    {
                        int Y23 = 5;
                        Ghost1.Top += Y23;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall24
                    if (Ghost1.Bounds.IntersectsWith(Wall24.Bounds))
                    {
                        int Y24 = 5;
                        Ghost1.Top += Y24;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall25
                    if (Ghost1.Bounds.IntersectsWith(Wall25.Bounds))
                    {
                        int Y25 = 5;
                        Ghost1.Top += Y25;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall26
                    if (Ghost1.Bounds.IntersectsWith(Wall26.Bounds))
                    {
                        int Y26 = 5;
                        Ghost1.Top += Y26;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall27
                    if (Ghost1.Bounds.IntersectsWith(Wall27.Bounds))
                    {
                        int Y27 = 5;
                        Ghost1.Top += Y27;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion

                    #endregion
                }
                else if (Ghost1Down == true)
                {
                    int Y = 1;
                    Ghost1.Top += Y;
                    #region GhostDownCollision
                    #region Wall1
                    if (Ghost1.Bounds.IntersectsWith(Wall1.Bounds))
                    {
                        int Y1 = 5;
                        Ghost1.Top -= Y1;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall2
                    if (Ghost1.Bounds.IntersectsWith(Wall2.Bounds))
                    {
                        int Y2 = 5;
                        Ghost1.Top -= Y2;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall3
                    if (Ghost1.Bounds.IntersectsWith(Wall3.Bounds))
                    {
                        int Y3 = 5;
                        Ghost1.Top -= Y3;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall4
                    if (Ghost1.Bounds.IntersectsWith(Wall4.Bounds))
                    {
                        int Y4 = 5;
                        Ghost1.Top -= Y4;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall5
                    if (Ghost1.Bounds.IntersectsWith(Wall5.Bounds))
                    {
                        int Y5 = 5;
                        Ghost1.Top -= Y5;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall6
                    if (Ghost1.Bounds.IntersectsWith(Wall6.Bounds))
                    {
                        int Y6 = 5;
                        Ghost1.Top -= Y6;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall7
                    if (Ghost1.Bounds.IntersectsWith(Wall7.Bounds))
                    {
                        int Y7 = 5;
                        Ghost1.Top -= Y7;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall8
                    if (Ghost1.Bounds.IntersectsWith(Wall8.Bounds))
                    {
                        int Y8 = 5;
                        Ghost1.Top -= Y8;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall9
                    if (Ghost1.Bounds.IntersectsWith(Wall9.Bounds))
                    {
                        int Y9 = 5;
                        Ghost1.Top -= Y9;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall10
                    if (Ghost1.Bounds.IntersectsWith(Wall10.Bounds))
                    {
                        int Y10 = 5;
                        Ghost1.Top -= Y10;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall11
                    if (Ghost1.Bounds.IntersectsWith(Wall11.Bounds))
                    {
                        int Y11 = 5;
                        Ghost1.Top -= Y11;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall12
                    if (Ghost1.Bounds.IntersectsWith(Wall12.Bounds))
                    {
                        int Y12 = 5;
                        Ghost1.Top -= Y12;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall13
                    if (Ghost1.Bounds.IntersectsWith(Wall13.Bounds))
                    {
                        int Y13 = 5;
                        Ghost1.Top -= Y13;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall14
                    if (Ghost1.Bounds.IntersectsWith(Wall14.Bounds))
                    {
                        int Y14 = 5;
                        Ghost1.Top -= Y14;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall15
                    if (Ghost1.Bounds.IntersectsWith(Wall15.Bounds))
                    {
                        int Y15 = 5;
                        Ghost1.Top -= Y15;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall16
                    if (Ghost1.Bounds.IntersectsWith(Wall16.Bounds))
                    {
                        int Y16 = 5;
                        Ghost1.Top -= Y16;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall17
                    if (Ghost1.Bounds.IntersectsWith(Wall17.Bounds))
                    {
                        int Y17 = 5;
                        Ghost1.Top -= Y17;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall18
                    if (Ghost1.Bounds.IntersectsWith(Wall18.Bounds))
                    {
                        int Y18 = 5;
                        Ghost1.Top -= Y18;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall19
                    if (Ghost1.Bounds.IntersectsWith(Wall19.Bounds))
                    {
                        int Y19 = 5;
                        Ghost1.Top -= Y19;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall20
                    if (Ghost1.Bounds.IntersectsWith(Wall20.Bounds))
                    {
                        int Y20 = 5;
                        Ghost1.Top -= Y20;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall21
                    if (Ghost1.Bounds.IntersectsWith(Wall21.Bounds))
                    {
                        int Y21 = 5;
                        Ghost1.Top -= Y21;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall22
                    if (Ghost1.Bounds.IntersectsWith(Wall22.Bounds))
                    {
                        int Y22 = 5;
                        Ghost1.Top -= Y22;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall23
                    if (Ghost1.Bounds.IntersectsWith(Wall23.Bounds))
                    {
                        int Y23 = 5;
                        Ghost1.Top -= Y23;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall24
                    if (Ghost1.Bounds.IntersectsWith(Wall24.Bounds))
                    {
                        int Y24 = 5;
                        Ghost1.Top -= Y24;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall25
                    if (Ghost1.Bounds.IntersectsWith(Wall25.Bounds))
                    {
                        int Y25 = 5;
                        Ghost1.Top -= Y25;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall26
                    if (Ghost1.Bounds.IntersectsWith(Wall26.Bounds))
                    {
                        int Y26 = 5;
                        Ghost1.Top -= Y26;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall27
                    if (Ghost1.Bounds.IntersectsWith(Wall27.Bounds))
                    {
                        int Y27 = 5;
                        Ghost1.Top -= Y27;
                        Ghost1Down = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = true;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion


                    #endregion
                }
                else if (Ghost1Left == true)
                {
                    int X = 1;
                    Ghost1.Left -= X;
                    #region GhostLeftCollision
                    #region Wall1
                    if (Ghost1.Bounds.IntersectsWith(Wall1.Bounds))
                    {
                        int X1 = 5;
                        Ghost1.Left += X1;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall2
                    if (Ghost1.Bounds.IntersectsWith(Wall2.Bounds))
                    {
                        int X2 = 5;
                        Ghost1.Left += X2;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall3
                    if (Ghost1.Bounds.IntersectsWith(Wall3.Bounds))
                    {
                        int X3 = 5;
                        Ghost1.Left += X3;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall4
                    if (Ghost1.Bounds.IntersectsWith(Wall4.Bounds))
                    {

                        int X4 = 5;
                        Ghost1.Left += X4;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }

                    }
                    #endregion
                    #region Wall5
                    if (Ghost1.Bounds.IntersectsWith(Wall5.Bounds))
                    {
                        int X5 = 5;
                        Ghost1.Left += X5;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall6
                    if (Ghost1.Bounds.IntersectsWith(Wall6.Bounds))
                    {
                        int X6 = 5;
                        Ghost1.Left += X6;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall7
                    if (Ghost1.Bounds.IntersectsWith(Wall7.Bounds))
                    {
                        int X7 = 5;
                        Ghost1.Left += X7;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall8
                    if (Ghost1.Bounds.IntersectsWith(Wall8.Bounds))
                    {
                        int X8 = 5;
                        Ghost1.Left += X8;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall9
                    if (Ghost1.Bounds.IntersectsWith(Wall9.Bounds))
                    {
                        int X9 = 5;
                        Ghost1.Left += X9;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall10
                    if (Ghost1.Bounds.IntersectsWith(Wall10.Bounds))
                    {
                        int X10 = 5;
                        Ghost1.Left += X10;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall11
                    if (Ghost1.Bounds.IntersectsWith(Wall11.Bounds))
                    {
                        int X11 = 5;
                        Ghost1.Left += X11;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall12
                    if (Ghost1.Bounds.IntersectsWith(Wall12.Bounds))
                    {
                        int X12 = 5;
                        Ghost1.Left += X12;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall13
                    if (Ghost1.Bounds.IntersectsWith(Wall13.Bounds))
                    {
                        int X13 = 5;
                        Ghost1.Left += X13;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall14
                    if (Ghost1.Bounds.IntersectsWith(Wall14.Bounds))
                    {
                        int X14 = 5;
                        Ghost1.Left += X14;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                        Ghost1.Location = new Point(809, 158);
                    }
                    #endregion
                    #region Wall15
                    if (Ghost1.Bounds.IntersectsWith(Wall15.Bounds))
                    {
                        int X15 = 5;
                        Ghost1.Left += X15;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall16
                    if (Ghost1.Bounds.IntersectsWith(Wall16.Bounds))
                    {
                        int X16 = 5;
                        Ghost1.Left += X16;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall17
                    if (Ghost1.Bounds.IntersectsWith(Wall17.Bounds))
                    {
                        int X17 = 5;
                        Ghost1.Left += X17;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall18
                    if (Ghost1.Bounds.IntersectsWith(Wall18.Bounds))
                    {
                        int X18 = 5;
                        Ghost1.Left += X18;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall19
                    if (Ghost1.Bounds.IntersectsWith(Wall19.Bounds))
                    {
                        int X19 = 5;
                        Ghost1.Left += X19;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall20
                    if (Ghost1.Bounds.IntersectsWith(Wall20.Bounds))
                    {
                        int X20 = 5;
                        Ghost1.Left += X20;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall21
                    if (Ghost1.Bounds.IntersectsWith(Wall21.Bounds))
                    {
                        int X21 = 5;
                        Ghost1.Left += X21;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall22
                    if (Ghost1.Bounds.IntersectsWith(Wall22.Bounds))
                    {
                        int X22 = 5;
                        Ghost1.Left += X22;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall23
                    if (Ghost1.Bounds.IntersectsWith(Wall23.Bounds))
                    {
                        int X23 = 5;
                        Ghost1.Left += X23;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall24
                    if (Ghost1.Bounds.IntersectsWith(Wall24.Bounds))
                    {
                        int X24 = 5;
                        Ghost1.Left += X24;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall25
                    if (Ghost1.Bounds.IntersectsWith(Wall25.Bounds))
                    {
                        int X25 = 5;
                        Ghost1.Left += X25;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall26
                    if (Ghost1.Bounds.IntersectsWith(Wall26.Bounds))
                    {
                        int X26 = 5;
                        Ghost1.Left += X26;
                        Ghost1Left = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall27
                    if (Ghost1.Bounds.IntersectsWith(Wall27.Bounds))
                    {
                        int X27 = 5;
                        Ghost1.Top += X27;
                        Ghost1Up = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #endregion
                }
                else if (Ghost1Right == true)
                {
                    int X = 1;
                    Ghost1.Left += X;
                    #region GhostRightCollision
                    #region Wall1
                    if (Ghost1.Bounds.IntersectsWith(Wall1.Bounds))
                    {
                        int X1 = 5;
                        Ghost1.Left -= X1;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall2
                    if (Ghost1.Bounds.IntersectsWith(Wall2.Bounds))
                    {
                        int X2 = 5;
                        Ghost1.Left -= X2;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall3
                    if (Ghost1.Bounds.IntersectsWith(Wall3.Bounds))
                    {
                        int X3 = 5;
                        Ghost1.Left -= X3;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall4
                    if (Ghost1.Bounds.IntersectsWith(Wall4.Bounds))
                    {
                        int X4 = 5;
                        Ghost1.Left -= X4;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall5
                    if (Ghost1.Bounds.IntersectsWith(Wall5.Bounds))
                    {
                        int X5 = 5;
                        Ghost1.Left -= X5;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall6
                    if (Ghost1.Bounds.IntersectsWith(Wall6.Bounds))
                    {
                        int X6 = 5;
                        Ghost1.Left -= X6;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall7
                    if (Ghost1.Bounds.IntersectsWith(Wall7.Bounds))
                    {
                        int X7 = 5;
                        Ghost1.Left -= X7;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall8
                    if (Ghost1.Bounds.IntersectsWith(Wall8.Bounds))
                    {
                        int X8 = 5;
                        Ghost1.Left -= X8;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall9
                    if (Ghost1.Bounds.IntersectsWith(Wall9.Bounds))
                    {
                        int X9 = 5;
                        Ghost1.Left -= X9;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall10
                    if (Ghost1.Bounds.IntersectsWith(Wall10.Bounds))
                    {
                        int X10 = 5;
                        Ghost1.Left -= X10;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall11
                    if (Ghost1.Bounds.IntersectsWith(Wall11.Bounds))
                    {
                        int X11 = 5;
                        Ghost1.Left -= X11;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall12
                    if (Ghost1.Bounds.IntersectsWith(Wall12.Bounds))
                    {
                        int X12 = 5;
                        Ghost1.Left -= X12;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall13
                    if (Ghost1.Bounds.IntersectsWith(Wall13.Bounds))
                    {
                        int X13 = 5;
                        Ghost1.Left -= X13;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall14
                    if (Ghost1.Bounds.IntersectsWith(Wall14.Bounds))
                    {
                        int X14 = 5;
                        Ghost1.Left -= X14;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall15
                    if (Ghost1.Bounds.IntersectsWith(Wall15.Bounds))
                    {
                        int X15 = 5;
                        Ghost1.Left -= X15;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall16
                    if (Ghost1.Bounds.IntersectsWith(Wall16.Bounds))
                    {
                        int X16 = 5;
                        Ghost1.Left -= X16;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall17
                    if (Ghost1.Bounds.IntersectsWith(Wall17.Bounds))
                    {
                        int X17 = 5;
                        Ghost1.Left -= X17;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall18
                    if (Ghost1.Bounds.IntersectsWith(Wall18.Bounds))
                    {
                        int X18 = 5;
                        Ghost1.Left -= X18;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall19
                    if (Ghost1.Bounds.IntersectsWith(Wall19.Bounds))
                    {
                        int X19 = 5;
                        Ghost1.Left -= X19;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall20
                    if (Ghost1.Bounds.IntersectsWith(Wall20.Bounds))
                    {
                        int X20 = 5;
                        Ghost1.Left -= X20;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall21
                    if (Ghost1.Bounds.IntersectsWith(Wall21.Bounds))
                    {
                        int X21 = 5;
                        Ghost1.Left -= X21;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall22
                    if (Ghost1.Bounds.IntersectsWith(Wall22.Bounds))
                    {
                        int X22 = 5;
                        Ghost1.Left -= X22;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall23
                    if (Ghost1.Bounds.IntersectsWith(Wall23.Bounds))
                    {
                        int X23 = 5;
                        Ghost1.Left -= X23;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall24
                    if (Ghost1.Bounds.IntersectsWith(Wall24.Bounds))
                    {
                        int X24 = 5;
                        Ghost1.Left -= X24;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall25
                    if (Ghost1.Bounds.IntersectsWith(Wall25.Bounds))
                    {
                        int X25 = 5;
                        Ghost1.Left -= X25;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall26
                    if (Ghost1.Bounds.IntersectsWith(Wall26.Bounds))
                    {
                        int X26 = 5;
                        Ghost1.Left -= X26;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #region Wall27
                    if (Ghost1.Bounds.IntersectsWith(Wall27.Bounds))
                    {
                        int X27 = 5;
                        Ghost1.Left -= X27;
                        Ghost1Right = false;
                        Randoms rn = new Randoms();
                        int RetRan = rn.Direction();
                        switch (RetRan)
                        {
                            case 1:
                                Ghost1Up = false;
                                Ghost1Down = true;
                                Ghost1Left = false;
                                Ghost1Right = false;
                                break;
                            case 2:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = true;
                                Ghost1Right = false;
                                break;
                            case 3:
                                Ghost1Up = false;
                                Ghost1Down = false;
                                Ghost1Left = false;
                                Ghost1Right = true;
                                break;

                            default:
                                MessageBox.Show("Error");
                                break;
                        }
                    }
                    #endregion
                    #endregion
                }
            }
        }

        private void Ghost2Timer_Tick(object sender, EventArgs e)
        {
            if (Ghost2Up == true)
            {
                int Y = 1;
                Ghost2.Top -= Y;
                #region GhostUpCollision
                #region Wall1
                if (Ghost2.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int Y1 = 5;
                    Ghost2.Top += Y1;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost2.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int Y2 = 5;
                    Ghost2.Top += Y2;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost2.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int Y3 = 5;
                    Ghost2.Top += Y3;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost2.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int Y4 = 5;
                    Ghost2.Top += Y4;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost2.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int Y5 = 5;
                    Ghost2.Top += Y5;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost2.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int Y6 = 5;
                    Ghost2.Top += Y6;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost2.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int Y7 = 5;
                    Ghost2.Top += Y7;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost2.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int Y8 = 5;
                    Ghost2.Top += Y8;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost2.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int Y9 = 5;
                    Ghost2.Top += Y9;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost2.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int Y10 = 5;
                    Ghost2.Top += Y10;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost2.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int Y11 = 5;
                    Ghost2.Top += Y11;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost2.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int Y12 = 5;
                    Ghost2.Top += Y12;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost2.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int Y13 = 5;
                    Ghost2.Top += Y13;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost2.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int Y14 = 5;
                    Ghost2.Top += Y14;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost2.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int Y15 = 5;
                    Ghost2.Top += Y15;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost2.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int Y16 = 5;
                    Ghost2.Top += Y16;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost2.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int Y17 = 5;
                    Ghost2.Top += Y17;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost2.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int Y18 = 5;
                    Ghost2.Top += Y18;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost2.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int Y19 = 5;
                    Ghost2.Top += Y19;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost2.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int Y20 = 5;
                    Ghost2.Top += Y20;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost2.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int Y21 = 5;
                    Ghost2.Top += Y21;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost2.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int Y22 = 5;
                    Ghost2.Top += Y22;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost2.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int Y23 = 5;
                    Ghost2.Top += Y23;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost2.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int Y24 = 5;
                    Ghost2.Top += Y24;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost2.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int Y25 = 5;
                    Ghost2.Top += Y25;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost1.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int Y26 = 5;
                    Ghost2.Top += Y26;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost1.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int Y27 = 5;
                    Ghost2.Top += Y27;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion

                #endregion
            }
            else if (Ghost2Down == true)
            {
                int Y = 1;
                Ghost2.Top += Y;
                #region GhostDownCollision
                #region Wall1
                if (Ghost2.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int Y1 = 5;
                    Ghost2.Top -= Y1;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost2.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int Y2 = 5;
                    Ghost2.Top -= Y2;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost2.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int Y3 = 5;
                    Ghost2.Top -= Y3;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost2.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int Y4 = 5;
                    Ghost2.Top -= Y4;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost2.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int Y5 = 5;
                    Ghost2.Top -= Y5;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost2.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int Y6 = 5;
                    Ghost2.Top -= Y6;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost2.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int Y7 = 5;
                    Ghost2.Top -= Y7;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost2.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int Y8 = 5;
                    Ghost2.Top -= Y8;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost2.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int Y9 = 5;
                    Ghost2.Top -= Y9;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost2.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int Y10 = 5;
                    Ghost2.Top -= Y10;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost2.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int Y11 = 5;
                    Ghost2.Top -= Y11;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost2.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int Y12 = 5;
                    Ghost2.Top -= Y12;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost2.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int Y13 = 5;
                    Ghost2.Top -= Y13;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost2.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int Y14 = 5;
                    Ghost2.Top -= Y14;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost2.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int Y15 = 5;
                    Ghost2.Top -= Y15;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost2.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int Y16 = 5;
                    Ghost2.Top -= Y16;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost2.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int Y17 = 5;
                    Ghost2.Top -= Y17;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost2.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int Y18 = 5;
                    Ghost2.Top -= Y18;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost2.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int Y19 = 5;
                    Ghost2.Top -= Y19;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost2.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int Y20 = 5;
                    Ghost2.Top -= Y20;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost2.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int Y21 = 5;
                    Ghost2.Top -= Y21;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost2.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int Y22 = 5;
                    Ghost2.Top -= Y22;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost2.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int Y23 = 5;
                    Ghost2.Top -= Y23;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost2.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int Y24 = 5;
                    Ghost2.Top -= Y24;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost2.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int Y25 = 5;
                    Ghost2.Top -= Y25;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost2.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int Y26 = 5;
                    Ghost2.Top -= Y26;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost2.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int Y27 = 5;
                    Ghost2.Top -= Y27;
                    Ghost2Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = true;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion


                #endregion
            }
            else if (Ghost2Left == true)
            {
                int X = 1;
                Ghost2.Left -= X;
                #region GhostLeftCollision
                #region Wall1
                if (Ghost2.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int X1 = 5;
                    Ghost2.Left += X1;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost2.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int X2 = 5;
                    Ghost2.Left += X2;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost2.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int X3 = 5;
                    Ghost2.Left += X3;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost2.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int X4 = 5;
                    Ghost2.Left += X4;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }

                }
                #endregion
                #region Wall5
                if (Ghost2.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int X5 = 5;
                    Ghost2.Left += X5;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost2.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int X6 = 5;
                    Ghost2.Left += X6;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost2.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int X7 = 5;
                    Ghost2.Left += X7;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost2.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int X8 = 5;
                    Ghost2.Left += X8;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost2.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int X9 = 5;
                    Ghost2.Left += X9;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost2.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int X10 = 5;
                    Ghost2.Left += X10;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost2.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int X11 = 5;
                    Ghost2.Left += X11;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost2.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int X12 = 5;
                    Ghost2.Left += X12;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost2.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int X13 = 5;
                    Ghost2.Left += X13;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost2.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int X14 = 5;
                    Ghost2.Left += X14;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                    Ghost2.Location = new Point(818, 367);
                }
                #endregion
                #region Wall15
                if (Ghost2.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int X15 = 5;
                    Ghost2.Left += X15;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost2.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int X16 = 5;
                    Ghost2.Left += X16;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost2.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int X17 = 5;
                    Ghost2.Left += X17;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost1.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int X18 = 5;
                    Ghost2.Left += X18;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost2.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int X19 = 5;
                    Ghost2.Left += X19;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost2.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int X20 = 5;
                    Ghost2.Left += X20;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost2.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int X21 = 5;
                    Ghost2.Left += X21;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost2.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int X22 = 5;
                    Ghost2.Left += X22;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost2.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int X23 = 5;
                    Ghost2.Left += X23;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost2.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int X24 = 5;
                    Ghost2.Left += X24;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost2.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int X25 = 5;
                    Ghost2.Left += X25;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost2.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int X26 = 5;
                    Ghost2.Left += X26;
                    Ghost2Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost2.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int X27 = 5;
                    Ghost2.Top += X27;
                    Ghost2Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #endregion
            }
            else if (Ghost2Right == true)
            {
                int X = 1;
                Ghost2.Left += X;
                #region GhostRightCollision
                #region Wall1
                if (Ghost2.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int X1 = 5;
                    Ghost2.Left -= X1;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost2.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int X2 = 5;
                    Ghost2.Left -= X2;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost2.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int X3 = 5;
                    Ghost2.Left -= X3;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost2.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int X4 = 5;
                    Ghost2.Left -= X4;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost2.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int X5 = 5;
                    Ghost2.Left -= X5;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost2.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int X6 = 5;
                    Ghost2.Left -= X6;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost2.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int X7 = 5;
                    Ghost2.Left -= X7;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost2.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int X8 = 5;
                    Ghost2.Left -= X8;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost2.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int X9 = 5;
                    Ghost2.Left -= X9;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost2.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int X10 = 5;
                    Ghost2.Left -= X10;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost2.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int X11 = 5;
                    Ghost2.Left -= X11;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost2.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int X12 = 5;
                    Ghost2.Left -= X12;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost2.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int X13 = 5;
                    Ghost2.Left -= X13;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost2.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int X14 = 5;
                    Ghost2.Left -= X14;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost2.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int X15 = 5;
                    Ghost2.Left -= X15;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost2.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int X16 = 5;
                    Ghost2.Left -= X16;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost2.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int X17 = 5;
                    Ghost2.Left -= X17;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost2.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int X18 = 5;
                    Ghost2.Left -= X18;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost2.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int X19 = 5;
                    Ghost2.Left -= X19;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost2.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int X20 = 5;
                    Ghost2.Left -= X20;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost2.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int X21 = 5;
                    Ghost2.Left -= X21;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost2.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int X22 = 5;
                    Ghost2.Left -= X22;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost2.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int X23 = 5;
                    Ghost2.Left -= X23;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost2.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int X24 = 5;
                    Ghost2.Left -= X24;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost2.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int X25 = 5;
                    Ghost2.Left -= X25;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost2.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int X26 = 5;
                    Ghost2.Left -= X26;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost2.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int X27 = 5;
                    Ghost2.Left -= X27;
                    Ghost2Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost2Up = false;
                            Ghost2Down = true;
                            Ghost2Left = false;
                            Ghost2Right = false;
                            break;
                        case 2:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = true;
                            Ghost2Right = false;
                            break;
                        case 3:
                            Ghost2Up = false;
                            Ghost2Down = false;
                            Ghost2Left = false;
                            Ghost2Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #endregion
            }
        }

        private void Ghost3Timer_Tick(object sender, EventArgs e)
        {
            if (Ghost3Up == true)
            {
                int Y = 1;
                Ghost3.Top -= Y;
                #region GhostUpCollision
                #region Wall1
                if (Ghost3.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int Y1 = 5;
                    Ghost3.Top += Y1;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost3.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int Y2 = 5;
                    Ghost3.Top += Y2;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost3.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int Y3 = 5;
                    Ghost3.Top += Y3;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost3.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int Y4 = 5;
                    Ghost3.Top += Y4;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost3.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int Y5 = 5;
                    Ghost3.Top += Y5;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost3.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int Y6 = 5;
                    Ghost3.Top += Y6;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost3.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int Y7 = 5;
                    Ghost3.Top += Y7;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost3.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int Y8 = 5;
                    Ghost3.Top += Y8;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost3.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int Y9 = 5;
                    Ghost3.Top += Y9;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost3.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int Y10 = 5;
                    Ghost3.Top += Y10;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost3.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int Y11 = 5;
                    Ghost3.Top += Y11;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost3.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int Y12 = 5;
                    Ghost3.Top += Y12;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost3.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int Y13 = 5;
                    Ghost3.Top += Y13;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost3.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int Y14 = 5;
                    Ghost3.Top += Y14;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost3.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int Y15 = 5;
                    Ghost3.Top += Y15;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost3.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int Y16 = 5;
                    Ghost3.Top += Y16;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost3.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int Y17 = 5;
                    Ghost3.Top += Y17;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost3.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int Y18 = 5;
                    Ghost3.Top += Y18;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost3.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int Y19 = 5;
                    Ghost3.Top += Y19;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost3.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int Y20 = 5;
                    Ghost3.Top += Y20;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost3.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int Y21 = 5;
                    Ghost3.Top += Y21;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost3.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int Y22 = 5;
                    Ghost3.Top += Y22;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost3.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int Y23 = 5;
                    Ghost3.Top += Y23;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost3.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int Y24 = 5;
                    Ghost3.Top += Y24;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost3.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int Y25 = 5;
                    Ghost3.Top += Y25;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost1.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int Y26 = 5;
                    Ghost3.Top += Y26;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost1.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int Y27 = 5;
                    Ghost3.Top += Y27;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion

                #endregion
            }
            else if (Ghost3Down == true)
            {
                int Y = 1;
                Ghost3.Top += Y;
                #region GhostDownCollision
                #region Wall1
                if (Ghost3.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int Y1 = 5;
                    Ghost3.Top -= Y1;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost3.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int Y2 = 5;
                    Ghost3.Top -= Y2;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost3.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int Y3 = 5;
                    Ghost3.Top -= Y3;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost3.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int Y4 = 5;
                    Ghost3.Top -= Y4;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost3.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int Y5 = 5;
                    Ghost3.Top -= Y5;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost3.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int Y6 = 5;
                    Ghost3.Top -= Y6;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost3.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int Y7 = 5;
                    Ghost3.Top -= Y7;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost3.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int Y8 = 5;
                    Ghost3.Top -= Y8;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost3.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int Y9 = 5;
                    Ghost3.Top -= Y9;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost3.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int Y10 = 5;
                    Ghost3.Top -= Y10;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost3.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int Y11 = 5;
                    Ghost3.Top -= Y11;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost3.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int Y12 = 5;
                    Ghost3.Top -= Y12;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost3.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int Y13 = 5;
                    Ghost3.Top -= Y13;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost3.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int Y14 = 5;
                    Ghost3.Top -= Y14;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost3.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int Y15 = 5;
                    Ghost3.Top -= Y15;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost3.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int Y16 = 5;
                    Ghost3.Top -= Y16;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost3.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int Y17 = 5;
                    Ghost3.Top -= Y17;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost3.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int Y18 = 5;
                    Ghost3.Top -= Y18;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost3.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int Y19 = 5;
                    Ghost3.Top -= Y19;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost3.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int Y20 = 5;
                    Ghost3.Top -= Y20;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost3.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int Y21 = 5;
                    Ghost3.Top -= Y21;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost3.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int Y22 = 5;
                    Ghost3.Top -= Y22;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost3.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int Y23 = 5;
                    Ghost3.Top -= Y23;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost3.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int Y24 = 5;
                    Ghost3.Top -= Y24;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost3.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int Y25 = 5;
                    Ghost3.Top -= Y25;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost3.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int Y26 = 5;
                    Ghost3.Top -= Y26;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost3.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int Y27 = 5;
                    Ghost3.Top -= Y27;
                    Ghost3Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = true;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion


                #endregion
            }
            else if (Ghost3Left == true)
            {
                int X = 1;
                Ghost3.Left -= X;
                #region GhostLeftCollision
                #region Wall1
                if (Ghost3.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int X1 = 5;
                    Ghost3.Left += X1;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost3.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int X2 = 5;
                    Ghost3.Left += X2;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost3.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int X3 = 5;
                    Ghost3.Left += X3;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost3.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int X4 = 5;
                    Ghost3.Left += X4;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }

                }
                #endregion
                #region Wall5
                if (Ghost3.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int X5 = 5;
                    Ghost3.Left += X5;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost3.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int X6 = 5;
                    Ghost3.Left += X6;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost3.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int X7 = 5;
                    Ghost3.Left += X7;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost3.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int X8 = 5;
                    Ghost3.Left += X8;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost3.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int X9 = 5;
                    Ghost3.Left += X9;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost3.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int X10 = 5;
                    Ghost3.Left += X10;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost3.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int X11 = 5;
                    Ghost3.Left += X11;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost3.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int X12 = 5;
                    Ghost3.Left += X12;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost3.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int X13 = 5;
                    Ghost3.Left += X13;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost3.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int X14 = 5;
                    Ghost3.Left += X14;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                    Ghost3.Location = new Point(719, 158);
                }
                #endregion
                #region Wall15
                if (Ghost3.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int X15 = 5;
                    Ghost3.Left += X15;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost3.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int X16 = 5;
                    Ghost3.Left += X16;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost3.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int X17 = 5;
                    Ghost3.Left += X17;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost1.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int X18 = 5;
                    Ghost3.Left += X18;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost3.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int X19 = 5;
                    Ghost3.Left += X19;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost3.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int X20 = 5;
                    Ghost3.Left += X20;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost3.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int X21 = 5;
                    Ghost3.Left += X21;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost3.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int X22 = 5;
                    Ghost3.Left += X22;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost3.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int X23 = 5;
                    Ghost3.Left += X23;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost3.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int X24 = 5;
                    Ghost3.Left += X24;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost3.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int X25 = 5;
                    Ghost3.Left += X25;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost3.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int X26 = 5;
                    Ghost3.Left += X26;
                    Ghost3Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost3.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int X27 = 5;
                    Ghost3.Top += X27;
                    Ghost3Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #endregion
            }
            else if (Ghost3Right == true)
            {
                int X = 1;
                Ghost3.Left += X;
                #region GhostRightCollision
                #region Wall1
                if (Ghost3.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int X1 = 5;
                    Ghost3.Left -= X1;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost3.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int X2 = 5;
                    Ghost3.Left -= X2;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost3.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int X3 = 5;
                    Ghost3.Left -= X3;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost3.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int X4 = 5;
                    Ghost3.Left -= X4;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost3.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int X5 = 5;
                    Ghost3.Left -= X5;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost3.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int X6 = 5;
                    Ghost3.Left -= X6;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost3.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int X7 = 5;
                    Ghost3.Left -= X7;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost3.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int X8 = 5;
                    Ghost3.Left -= X8;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost3.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int X9 = 5;
                    Ghost3.Left -= X9;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost3.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int X10 = 5;
                    Ghost3.Left -= X10;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost3.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int X11 = 5;
                    Ghost3.Left -= X11;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost3.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int X12 = 5;
                    Ghost3.Left -= X12;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost3.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int X13 = 5;
                    Ghost3.Left -= X13;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost3.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int X14 = 5;
                    Ghost3.Left -= X14;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost3.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int X15 = 5;
                    Ghost3.Left -= X15;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost3.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int X16 = 5;
                    Ghost3.Left -= X16;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost3.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int X17 = 5;
                    Ghost3.Left -= X17;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost3.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int X18 = 5;
                    Ghost3.Left -= X18;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost3.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int X19 = 5;
                    Ghost3.Left -= X19;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost3.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int X20 = 5;
                    Ghost3.Left -= X20;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost3.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int X21 = 5;
                    Ghost3.Left -= X21;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost3.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int X22 = 5;
                    Ghost3.Left -= X22;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost3.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int X23 = 5;
                    Ghost3.Left -= X23;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost3.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int X24 = 5;
                    Ghost3.Left -= X24;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost3.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int X25 = 5;
                    Ghost3.Left -= X25;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost3.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int X26 = 5;
                    Ghost3.Left -= X26;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost3.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int X27 = 5;
                    Ghost3.Left -= X27;
                    Ghost3Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost3Up = false;
                            Ghost3Down = true;
                            Ghost3Left = false;
                            Ghost3Right = false;
                            break;
                        case 2:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = true;
                            Ghost3Right = false;
                            break;
                        case 3:
                            Ghost3Up = false;
                            Ghost3Down = false;
                            Ghost3Left = false;
                            Ghost3Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #endregion
            }
        }

        private void Ghost4Timer_Tick(object sender, EventArgs e)
        {
            if (Ghost4Up == true)
            {
                int Y = 1;
                Ghost4.Top -= Y;
                #region GhostUpCollision
                #region Wall1
                if (Ghost4.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int Y1 = 5;
                    Ghost4.Top += Y1;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost4.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int Y2 = 5;
                    Ghost4.Top += Y2;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost4.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int Y3 = 5;
                    Ghost4.Top += Y3;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost4.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int Y4 = 5;
                    Ghost4.Top += Y4;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }

                }
                #endregion
                #region Wall5
                if (Ghost4.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int Y5 = 5;
                    Ghost4.Top += Y5;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost4.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int Y6 = 5;
                    Ghost4.Top += Y6;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost4.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int Y7 = 5;
                    Ghost4.Top += Y7;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost4.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int Y8 = 5;
                    Ghost4.Top += Y8;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost4.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int Y9 = 5;
                    Ghost4.Top += Y9;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost4.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int Y10 = 5;
                    Ghost4.Top += Y10;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost4.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int Y11 = 5;
                    Ghost4.Top += Y11;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost4.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int Y12 = 5;
                    Ghost4.Top += Y12;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost4.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int Y13 = 5;
                    Ghost4.Top += Y13;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost4.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int Y14 = 5;
                    Ghost4.Top += Y14;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost4.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int Y15 = 5;
                    Ghost4.Top += Y15;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost4.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int Y16 = 5;
                    Ghost4.Top += Y16;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost4.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int Y17 = 5;
                    Ghost4.Top += Y17;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost4.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int Y18 = 5;
                    Ghost4.Top += Y18;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost4.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int Y19 = 5;
                    Ghost4.Top += Y19;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost4.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int Y20 = 5;
                    Ghost4.Top += Y20;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost4.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int Y21 = 5;
                    Ghost4.Top += Y21;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost4.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int Y22 = 5;
                    Ghost4.Top += Y22;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost4.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int Y23 = 5;
                    Ghost4.Top += Y23;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost4.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int Y24 = 5;
                    Ghost4.Top += Y24;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost4.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int Y25 = 5;
                    Ghost4.Top += Y25;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost1.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int Y26 = 5;
                    Ghost4.Top += Y26;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost1.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int Y27 = 5;
                    Ghost4.Top += Y27;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion

                #endregion
            }
            else if (Ghost4Down == true)
            {
                int Y = 1;
                Ghost4.Top += Y;
                #region GhostDownCollision
                #region Wall1
                if (Ghost4.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int Y1 = 5;
                    Ghost4.Top -= Y1;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost4.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int Y2 = 5;
                    Ghost4.Top -= Y2;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost4.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int Y3 = 5;
                    Ghost4.Top -= Y3;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost4.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int Y4 = 5;
                    Ghost4.Top -= Y4;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost4.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int Y5 = 5;
                    Ghost4.Top -= Y5;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost4.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int Y6 = 5;
                    Ghost4.Top -= Y6;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost4.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int Y7 = 5;
                    Ghost4.Top -= Y7;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost4.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int Y8 = 5;
                    Ghost4.Top -= Y8;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost4.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int Y9 = 5;
                    Ghost4.Top -= Y9;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost4.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int Y10 = 5;
                    Ghost4.Top -= Y10;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost4.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int Y11 = 5;
                    Ghost4.Top -= Y11;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost4.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int Y12 = 5;
                    Ghost4.Top -= Y12;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost4.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int Y13 = 5;
                    Ghost4.Top -= Y13;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost4.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int Y14 = 5;
                    Ghost4.Top -= Y14;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost4.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int Y15 = 5;
                    Ghost4.Top -= Y15;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost4.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int Y16 = 5;
                    Ghost4.Top -= Y16;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost4.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int Y17 = 5;
                    Ghost4.Top -= Y17;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost4.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int Y18 = 5;
                    Ghost4.Top -= Y18;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost4.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int Y19 = 5;
                    Ghost4.Top -= Y19;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost4.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int Y20 = 5;
                    Ghost4.Top -= Y20;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost4.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int Y21 = 5;
                    Ghost4.Top -= Y21;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost4.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int Y22 = 5;
                    Ghost4.Top -= Y22;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost4.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int Y23 = 5;
                    Ghost4.Top -= Y23;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost4.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int Y24 = 5;
                    Ghost4.Top -= Y24;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost4.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int Y25 = 5;
                    Ghost4.Top -= Y25;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost4.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int Y26 = 5;
                    Ghost4.Top -= Y26;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost4.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int Y27 = 5;
                    Ghost4.Top -= Y27;
                    Ghost4Down = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = true;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion


                #endregion
            }
            else if (Ghost4Left == true)
            {
                int X = 1;
                Ghost4.Left -= X;
                #region GhostLeftCollision
                #region Wall1
                if (Ghost4.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int X1 = 5;
                    Ghost4.Left += X1;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost4.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int X2 = 5;
                    Ghost4.Left += X2;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost4.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int X3 = 5;
                    Ghost4.Left += X3;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost1.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int X4 = 5;
                    Ghost4.Left += X4;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }

                }
                #endregion
                #region Wall5
                if (Ghost4.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int X5 = 5;
                    Ghost4.Left += X5;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost4.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int X6 = 5;
                    Ghost4.Left += X6;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost4.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int X7 = 5;
                    Ghost4.Left += X7;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost4.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int X8 = 5;
                    Ghost4.Left += X8;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost4.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int X9 = 5;
                    Ghost4.Left += X9;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost4.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int X10 = 5;
                    Ghost4.Left += X10;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost4.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int X11 = 5;
                    Ghost4.Left += X11;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost4.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int X12 = 5;
                    Ghost4.Left += X12;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost4.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int X13 = 5;
                    Ghost4.Left += X13;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost4.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int X14 = 5;
                    Ghost4.Left += X14;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                    Ghost4.Location = new Point(663, 252);
                }
                #endregion
                #region Wall15
                if (Ghost4.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int X15 = 5;
                    Ghost4.Left += X15;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost4.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int X16 = 5;
                    Ghost4.Left += X16;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost4.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int X17 = 5;
                    Ghost4.Left += X17;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost1.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int X18 = 5;
                    Ghost4.Left += X18;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost4.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int X19 = 5;
                    Ghost4.Left += X19;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost4.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int X20 = 5;
                    Ghost4.Left += X20;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall21
                if (Ghost4.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int X21 = 5;
                    Ghost4.Left += X21;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost4.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int X22 = 5;
                    Ghost4.Left += X22;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost4.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int X23 = 5;
                    Ghost4.Left += X23;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost4.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int X24 = 5;
                    Ghost4.Left += X24;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost4.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int X25 = 5;
                    Ghost4.Left += X25;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost4.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int X26 = 5;
                    Ghost4.Left += X26;
                    Ghost4Left = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost4.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int X27 = 5;
                    Ghost4.Top += X27;
                    Ghost4Up = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #endregion
            }
            else if (Ghost4Right == true)
            {
                int X = 1;
                Ghost4.Left += X;
                #region GhostRightCollision
                #region Wall1
                if (Ghost4.Bounds.IntersectsWith(Wall1.Bounds))
                {
                    int X1 = 5;
                    Ghost4.Left -= X1;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall2
                if (Ghost4.Bounds.IntersectsWith(Wall2.Bounds))
                {
                    int X2 = 5;
                    Ghost4.Left -= X2;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall3
                if (Ghost4.Bounds.IntersectsWith(Wall3.Bounds))
                {
                    int X3 = 5;
                    Ghost4.Left -= X3;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall4
                if (Ghost4.Bounds.IntersectsWith(Wall4.Bounds))
                {
                    int X4 = 5;
                    Ghost4.Left -= X4;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall5
                if (Ghost4.Bounds.IntersectsWith(Wall5.Bounds))
                {
                    int X5 = 5;
                    Ghost4.Left -= X5;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall6
                if (Ghost4.Bounds.IntersectsWith(Wall6.Bounds))
                {
                    int X6 = 5;
                    Ghost4.Left -= X6;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall7
                if (Ghost4.Bounds.IntersectsWith(Wall7.Bounds))
                {
                    int X7 = 5;
                    Ghost4.Left -= X7;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall8
                if (Ghost4.Bounds.IntersectsWith(Wall8.Bounds))
                {
                    int X8 = 5;
                    Ghost4.Left -= X8;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall9
                if (Ghost4.Bounds.IntersectsWith(Wall9.Bounds))
                {
                    int X9 = 5;
                    Ghost4.Left -= X9;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall10
                if (Ghost4.Bounds.IntersectsWith(Wall10.Bounds))
                {
                    int X10 = 5;
                    Ghost4.Left -= X10;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall11
                if (Ghost4.Bounds.IntersectsWith(Wall11.Bounds))
                {
                    int X11 = 5;
                    Ghost4.Left -= X11;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall12
                if (Ghost4.Bounds.IntersectsWith(Wall12.Bounds))
                {
                    int X12 = 5;
                    Ghost4.Left -= X12;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall13
                if (Ghost4.Bounds.IntersectsWith(Wall13.Bounds))
                {
                    int X13 = 5;
                    Ghost4.Left -= X13;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall14
                if (Ghost4.Bounds.IntersectsWith(Wall14.Bounds))
                {
                    int X14 = 5;
                    Ghost4.Left -= X14;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall15
                if (Ghost4.Bounds.IntersectsWith(Wall15.Bounds))
                {
                    int X15 = 5;
                    Ghost4.Left -= X15;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall16
                if (Ghost4.Bounds.IntersectsWith(Wall16.Bounds))
                {
                    int X16 = 5;
                    Ghost4.Left -= X16;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall17
                if (Ghost4.Bounds.IntersectsWith(Wall17.Bounds))
                {
                    int X17 = 5;
                    Ghost4.Left -= X17;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall18
                if (Ghost4.Bounds.IntersectsWith(Wall18.Bounds))
                {
                    int X18 = 5;
                    Ghost4.Left -= X18;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall19
                if (Ghost4.Bounds.IntersectsWith(Wall19.Bounds))
                {
                    int X19 = 5;
                    Ghost4.Left -= X19;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall20
                if (Ghost4.Bounds.IntersectsWith(Wall20.Bounds))
                {
                    int X20 = 5;
                    Ghost4.Left -= X20;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost4.Bounds.IntersectsWith(Wall21.Bounds))
                {
                    int X21 = 5;
                    Ghost4.Left -= X21;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall22
                if (Ghost4.Bounds.IntersectsWith(Wall22.Bounds))
                {
                    int X22 = 5;
                    Ghost4.Left -= X22;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall23
                if (Ghost4.Bounds.IntersectsWith(Wall23.Bounds))
                {
                    int X23 = 5;
                    Ghost4.Left -= X23;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall24
                if (Ghost4.Bounds.IntersectsWith(Wall24.Bounds))
                {
                    int X24 = 5;
                    Ghost4.Left -= X24;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall25
                if (Ghost4.Bounds.IntersectsWith(Wall25.Bounds))
                {
                    int X25 = 5;
                    Ghost4.Left -= X25;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall26
                if (Ghost4.Bounds.IntersectsWith(Wall26.Bounds))
                {
                    int X26 = 5;
                    Ghost4.Left -= X26;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #region Wall27
                if (Ghost4.Bounds.IntersectsWith(Wall27.Bounds))
                {
                    int X27 = 5;
                    Ghost4.Left -= X27;
                    Ghost4Right = false;
                    Randoms rn = new Randoms();
                    int RetRan = rn.Direction();
                    switch (RetRan)
                    {
                        case 1:
                            Ghost4Up = false;
                            Ghost4Down = true;
                            Ghost4Left = false;
                            Ghost4Right = false;
                            break;
                        case 2:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = true;
                            Ghost4Right = false;
                            break;
                        case 3:
                            Ghost4Up = false;
                            Ghost4Down = false;
                            Ghost4Left = false;
                            Ghost4Right = true;
                            break;

                        default:
                            MessageBox.Show("Error");
                            break;
                    }
                }
                #endregion
                #endregion
            }
        }

        private void BonusTimer_Tick(object sender, EventArgs e)
        {

            {
                BonusCounter++;
                Stoping.Text = Convert.ToString(BonusCounter);
                if (BonusCounter == 10 || BonusCounter > 10)
                {
                    Stoping.Text = "0";
                    Ghost1Timer.Start();
                    Ghost2Timer.Start();
                    Ghost3Timer.Start();
                    Ghost4Timer.Start();
                    BonusTimer.Stop();
                    BonusCounter = 0;
                }
            }


                


           
      }
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        private void pacman_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                play.SoundLocation = "music\\4.wav";
                play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Pacman1_Click(object sender, EventArgs e)
        {

        }

        private void Visibletimer_Tick(object sender, EventArgs e)
        {
            if (PacmanTimer.Enabled == false && Ghost1Timer.Enabled == false && Ghost2Timer.Enabled == false
                && Ghost3Timer.Enabled == false && Ghost4Timer.Enabled == false &&
                BonusTimer.Enabled == false)
            {
                pictureBox5.Visible = true;
            }







            if (Seed1.Visible == false && Seed2.Visible == false && Seed3.Visible == false &&
    Seed4.Visible == false && Seed5.Visible == false && Seed6.Visible == false &&
    Seed7.Visible == false && Seed8.Visible == false && Seed9.Visible == false &&
    Seed10.Visible == false && Seed11.Visible == false && Seed12.Visible == false &&
Seed13.Visible == false && Seed14.Visible == false && Seed15.Visible == false &&
    Seed15.Visible == false && Seed16.Visible == false && Seed17.Visible == false &&
    Seed18.Visible == false && Seed19.Visible == false && Seed20.Visible == false &&
    Seed21.Visible == false && Seed22.Visible == false && Seed23.Visible == false &&
    Seed24.Visible == false && Seed25.Visible == false && Seed26.Visible == false &&
    Seed27.Visible == false && Seed28.Visible == false && Seed29.Visible == false &&
    Seed30.Visible == false && Seed31.Visible == false && Seed32.Visible == false &&
    Seed33.Visible == false && Seed34.Visible == false && Seed35.Visible == false &&
    Seed38.Visible == false && Seed37.Visible == false && Seed36.Visible == false &&
    Seed39.Visible == false && Seed40.Visible == false && Seed41.Visible == false &&
    Seed42.Visible == false && Seed43.Visible == false && Seed44.Visible == false &&
    Seed45.Visible == false && Seed46.Visible == false && Seed47.Visible == false &&
    Seed48.Visible == false && Seed49.Visible == false && Seed50.Visible == false &&
    Seed51.Visible == false && Seed52.Visible == false && Seed53.Visible == false &&
    Seed54.Visible == false && Seed55.Visible == false && Seed56.Visible == false &&
    Seed57.Visible == false && Seed58.Visible == false && Seed59.Visible == false &&
    Seed61.Visible == false && Seed62.Visible == false && Seed63.Visible == false &&
    Seed64.Visible == false && Seed65.Visible == false && Seed66.Visible == false &&
    Seed60.Visible == false)
            {
                Ghost1Timer.Stop();
                Ghost2Timer.Stop();
                Ghost3Timer.Stop();
                Ghost4Timer.Stop();
                BonusTimer.Stop();
                PacmanTimer.Stop();
                label1.Text = "YOU WIN ";
                pictureBox3.Visible = true;
                label1.Left=10;
                label1.Top = 10;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Ghost1Timer.Stop();
            Ghost2Timer.Stop();
            Ghost3Timer.Stop();
            Ghost4Timer.Stop();
            BonusTimer.Stop();
            PacmanTimer.Stop();
            this.Hide();
            game f1 = new game(s);
            f1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PacmanTimer.Enabled == false)
            {
                timer1.Stop();
                Ghost1Timer.Stop();
                Ghost2Timer.Stop();
                Ghost3Timer.Stop();
                Ghost4Timer.Stop();
                BonusTimer.Stop();
                PacmanTimer.Stop();
                this.Hide();
                game f1 = new game(s);
                f1.Show();

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                timer1.Stop();
                pacman myNewForm = new pacman(s);
                this.Hide();
                myNewForm.ShowDialog();



            }
            else if (dialogResult == DialogResult.No)
            {
                timer1.Stop();
                this.Hide();
                game f1 = new game(s);
                f1.Show();
            }
        }


    }
}

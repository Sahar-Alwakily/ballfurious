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
    class Collision
    {
        
        public static void UpKey(Label Pacman, Label Wall, bool PacmanUP)
        {
            if (Pacman.Bounds.IntersectsWith(Wall.Bounds))
            {
                int Y = 3;
                Pacman.Top += Y;
                PacmanUP = false;
            }
        }
        public static void DownKey(Label Pacman, Label Wall, bool PacmanDown)
        {
            if (Pacman.Bounds.IntersectsWith(Wall.Bounds))
            {
                int Y = 3;
                Pacman.Top -= Y;
                PacmanDown = false;
            }
        }
        public static void RighteKey(Label Pacman, Label Wall, bool PacmanRight)
        {
            if (Pacman.Bounds.IntersectsWith(Wall.Bounds))
            {
                int X = 3;
                Pacman.Left -= X;
                PacmanRight = false;
            }
        }
        public static void LeftKey(Label Pacman, Label Wall, bool PacmanLeft)
        {
            if (Pacman.Bounds.IntersectsWith(Wall.Bounds))
            {
                int X = 3;
                Pacman.Left += X;
                PacmanLeft = false;
            }
        }
        public static void BonusCollide(Timer Ghost1, Timer Ghost2, Timer Ghost3, Timer Ghost4, Label Bonus, Label Pacman, Timer BonusTimer, Label Score)
        {
            if (Pacman.Bounds.IntersectsWith(Bonus.Bounds))
            {
                Bonus.Visible = false;
                Ghost1.Stop();
                Ghost2.Stop();
                Ghost3.Stop();
                Ghost4.Stop();
                BonusTimer.Start();
                int S = Convert.ToInt32(Score.Text);
                S = S + 10;
                Score.Text = Convert.ToString(S);
            }
        }
        public static void SeedCollision(Label Seed, Label Pacman, Label Score)
        {
            if (Pacman.Bounds.IntersectsWith(Seed.Bounds))
            {
                Seed.Visible = false;
                int S = Convert.ToInt32(Score.Text);
                S++;
                Score.Text = Convert.ToString(S);
            }
        }
        public static void PacmanCollideGhost(Label Ghost, Label Pacman, Timer Ghost1Timer, Timer Ghost2Timer, Timer Ghost3Timer, Timer Ghost4Timer, Timer PacmanTimer, Timer BonusTimer)
        {
            if (Pacman.Bounds.IntersectsWith(Ghost.Bounds))
            {

                Ghost1Timer.Stop();
                Ghost2Timer.Stop();
                Ghost3Timer.Stop();
                Ghost4Timer.Stop();
                PacmanTimer.Stop();
                BonusTimer.Stop();
                MessageBox.Show("you loser ");
            }
        }
       
    }
}

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
    abstract class Rightkey : playermove
    {

        public static void rightkey(PictureBox player, Label allwall)
        {



            if (player.Bounds.IntersectsWith(allwall.Bounds))
            {

                MessageBox.Show("game over");
                player.Left = 25;
                player.Top = 25;
               // Application.Exit();


            }

        }
        public static void leftkey(PictureBox player, Label allwall)
        {

            if (player.Bounds.IntersectsWith(allwall.Bounds))
            {
                MessageBox.Show("game over");
                player.Left = 25;
                player.Top = 25;
             //   Application.Exit();

            }
        }
        
        public static void downkey(PictureBox player, Label allwall)
        {


            if (player.Bounds.IntersectsWith(allwall.Bounds))
            {
                MessageBox.Show("game over");
                player.Left = 25;
                player.Top = 25;
                //   Application.Exit();

            }
        }
        public static void upkey(PictureBox player, Label allwall)
        {


            if (player.Bounds.IntersectsWith(allwall.Bounds))
            {
                MessageBox.Show("game over");
                player.Left = 25;
                player.Top = 25;
                //   Application.Exit();

            }
        }
    }
}

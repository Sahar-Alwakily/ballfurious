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
    class Finishes : Rightkey
    {

        public static void finish1(PictureBox player, Label finish, mazegame form)
        {
            if (player.Bounds.IntersectsWith(finish.Bounds))
            {
                MessageBox.Show("You win");
                player.Left = 25;
                player.Top = 25;

            }
        }
    }
}

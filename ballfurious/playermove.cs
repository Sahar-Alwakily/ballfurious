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
    abstract class playermove
    {
        public static void playerup(PictureBox player)
        {
            int x = 6;
            player.Top -= x;
        }

        public static void playerdown(PictureBox player)
        {
            int x = 6;
            player.Top += x;
        }
        public static void playerleft(PictureBox player)
        {
            int x = 6;
            player.Left -= x;
        }
        public static void playerright(PictureBox player)
        {
            int x = 6;
            player.Left += x;
        }
    }
}

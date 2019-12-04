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
    class Timerclocks : Rightkey
    {
        public static void Timer(Label time, int count, mazegame form, Timer timer1)
        {

            if (count == -1)
            {
                MessageBox.Show("Game Over");
                timer1.Enabled = false;
                form.Close();

            }
            else
                time.Text = Convert.ToString(count--);
        }
    }
}

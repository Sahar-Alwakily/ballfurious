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
    class Addscore : Rightkey
    {
        public static void score(Label score)
        {
            int scoring = Convert.ToInt32(score.Text);
            scoring += 1;
            score.Text = scoring.ToString();

        }
    }
}

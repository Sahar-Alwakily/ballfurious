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
    class Randoms
    {
        public int Direction()
        {
            Random rn = new Random();
            int Random = Convert.ToInt32(rn.Next(1, 3));
            return Random;
        }
    }
}

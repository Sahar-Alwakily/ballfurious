using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ballfurious
{
    class miss : Class1
    {
        public void tru(PictureBox p, string[] j, int mistakes)
        {
            p.ImageLocation = j[mistakes];
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       public override void mAll(Label a, Button c, string b, string ft, int n, string[] d, int mistakesract, Random hint, PictureBox p)
        {

            int location = 67, location2 = 67, more = 0;


            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].ToString() == c.Text)
                {
                    if (more == 0)
                    {
                        location = i;
                        more = 1;
                    }
                    else
                    {
                        location2 = i;
                    }
                }
            }
            if (location != 67)
            {
                string replace = ft;
                ft = null;
                for (int i = 0; i < b.Length; i++)
                {
                    if (replace[i].ToString() == "*")
                    {
                        if (location == i || location2 == i)
                        {
                            ft = ft + c.Text;
                        }
                        else
                        {
                            ft = ft + "*";
                        }
                    }
                    else
                    {
                        ft = ft + b[i];
                    }
                }
                a.Text = ft;
            }
            else
            {
                if (mistakes > 0)
                {
                    this.tru(p, j, mistakes);
                    mistakes--;
                }
                else
                {
                    this.tru(p, j, mistakes);



                    MessageBox.Show("You Fail\nAnswere: " + b);
                   // Form10 f1 = new Form10();
                       // f1.Show();
                    
                   

    
                  //  Application.Exit();
                }
            }
            location = 67;
            location2 = 67;
            more = 0;
            if (a.Text == b)
            {
                ft = null;
                n = n + 1;
                if (n < d.Length)
                {
                    b = d[n];
                    MessageBox.Show("VEREY GOOD \n :)");
                }
                else
                {
                    MessageBox.Show("You Won");
                 //   Application.Exit();
                }
                int r = hint.Next(4);
                int r1 = hint.Next(r + 1, b.Length);
                for (int i = 0; i < b.Length; i++)
                {
                    if (r == i || r1 == i)
                    {
                        ft = ft + b[i];
                    }
                    else
                    {
                        ft = ft + "*";
                    }
                }
                a.Text = ft;
            }
            this.ft = ft;
            this.b = b;
            this.n = n;
            this.mistakes = mistakes;
        }
        public override void m1(Button a, Button b, Button c, Button d, Button e, Button f, Button g, Button h, Button i, Button j, Button k, Button l, Button m, Button n, Button o, Button p, Button q, Button r, Button s, Button t, Button u, Button v, Button w, Button x, Button y, Button z)
        {
        }
  
    }
}

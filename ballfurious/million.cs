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
    public partial class million : Form
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
        public million(int _s)
        {
            this.s = _s;
            InitializeComponent();
        }
        string[] d = new string[15] {
   
              "מהו ג'מוס؟",

           "? איך נקרא החלק הפנימי הצהוב של הביצה",
                           
          " ?מיהו הנחש הארוך ביותר בעולם",

          ":בית הנבחרים הוא",

       "  ?מה הכוונה במושג 'בית הכיסא ' "  ,

             "     ?מהו תיקן", 

             "       ?'מה הכוונה בביטוי 'כבשה שחורה     ",

             "      ?מהו אשד ",

              "        : ממחה הוא",
        
            "מי מהבאים הוא פרי האהבה؟   ",

             "  ؟C איזה פרי מכיל כמות רבה ובריאה של ויטמין ",


              "    מהו קרוקודיל؟ ",


              "  מיהו תתרן؟  ",


             " ?לפני כמה זמן בערך מתו אחרוני הממוטות   ",
             
             
           "האם צָפִיר הוא",

          };

          int i = 0,an=1,tm=0,win=0,x=1;
          bool answer=true;
        
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void million_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                System.Media.SoundPlayer play = new System.Media.SoundPlayer();
                play.SoundLocation = "music\\5.wav";
                play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            an = 4;
            tm = 0;
            label16.Text = d[i];
            label17.Text = "סוס";
            label18.Text = "פר";
            label19.Text = "פרפר";
            label20.Text = "(תאו (בפאלו";


        }
        // ادا جواب اخضر بنتقل لسؤال اللي وراه ادا خطأ رساله  تري أجين 
        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            if (answer == true)
            {
                i++;
                tm++;
                switch (i)
                {
                    case 1:
                        label16.Text = d[i];
                        label17.Text = "חלבון";
                        label18.Text = "חלמון";
                        label19.Text = "אין לו שם";
                        label20.Text = "צהוב";
                        an = 2;
                        break;
                    case 2:
                        label16.Text = d[i];
                        label17.Text = "בית המשפט העליון";
                        label18.Text = "הקלפי";
                        label19.Text = "הכנסת";
                        label20.Text = "בית ספר";
                        an = 3;
                        break;
                    case 3:
                        label16.Text = d[i];
                        label17.Text = "אנקונדה";
                        label18.Text = "קוברה";
                        label19.Text = "צפע";
                        label20.Text = "חול";
                        an = 1;
                        break;
                    case 4:
                        label16.Text = d[i];
                        label17.Text = "ארמון המלך";
                        label18.Text = "   (בית השימוש (שירותים";
                        label19.Text = "מושב התינוק";
                        label20.Text = "מושב ";
                        an = 2;
                        break;
                    case 5:
                        label16.Text = d[i];
                        label17.Text = " ג'וק";
                        label18.Text = "תוכי";
                        label19.Text = "תוצאת תיקו";
                        label20.Text = "כלכלה";
                        an = 1;
                        break;
                    case 6:
                        label16.Text = d[i];
                        label17.Text = "כבשה נדירה בצבע שחור";
                        label18.Text = "חיה בעלת צבע עור שחור";
                        label19.Text = "כינוי למישהו חריג במשפחה/ בחברה";
                        label20.Text = "חיה בעלת צבע עור לבן";
                        an = 3;
                        break;
                    case 7:
                        label16.Text = d[i];
                        label17.Text = "עץ";
                        label18.Text = "אישור לדרך";
                        label19.Text = "נייר";
                        label20.Text = "מפל";
                        an = 4;
                        break;
                    case 8:
                        label16.Text = d[i];
                        label17.Text = "מוחה דמעה";
                        label18.Text = " בלנדר";
                        label19.Text = "מלמד התמחות";
                        label20.Text = "סופר";
                        an = 2;
                        break;
                    case 9:
                        label16.Text = d[i];
                        label17.Text = "תות שדה";
                        label18.Text = "דובדבן";
                        label19.Text = "עגבניה";
                        label20.Text = "בננה";
                        an = 3;
                        break;
                    case 10:
                        label16.Text = d[i];
                        label17.Text = "תפוז";
                        label18.Text = "בננה";
                        label19.Text = "אפרסק";
                        label20.Text = "אבטיח";
                        an = 1;
                        break;
                    case 11:
                        label16.Text = d[i];
                        label17.Text = "נחש";
                        label18.Text = "תנין";
                        label19.Text = "פיל";
                        label20.Text = "היפופוטם";
                        an = 2;
                        break;
                    case 12:
                        label16.Text = d[i];
                        label17.Text = "אדם שאינו יכול להריח";
                        label18.Text = "אדם שאינו יכול לשמוע";
                        label19.Text = "אדם שאוהב לשחק טטריס";
                        label20.Text = "אדם שאוכל רק אוכל טרי";
                        an = 1;
                        break;
                    case 13:
                        label16.Text = d[i];
                        label17.Text = "700 שנה";
                        label18.Text = "50 שנה";
                        label19.Text = " 5000 שנה";
                        label20.Text = "6000 שנה";
                        an = 3;
                        break;
                    case 14:
                        label16.Text = d[i];
                        label17.Text = "חרק תנכ'י שלא זוהה בבירור שקולו צפירה";
                        label18.Text = "'קאובוי', 'בוקר' ";
                        label19.Text = "תייש";
                        label20.Text = "שרקן";
                        an = 3;
                        break;
                    case 15:
                        label16.Text = "";label17.Text = "";label18.Text = "";label19.Text = "";label20.Text = "";
                        win = 1;
                        break;


                }

                timer1.Stop();
            }
            else
            {
                timer1.Stop();
                label21.Text = "איבדתי";
                DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    timer1.Stop();
                    million myNewForm = new million(s);

                    this.Hide();
                    myNewForm.ShowDialog();



                }
                else if (dialogResult == DialogResult.No)
                {
                    timer1.Stop();
                    this.Hide();
                    Form10 f1 = new Form10(0);
                    f1.Show();
                }
                //  MessageBox.Show("תשובה לא נכונה ");

            }
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;

           
        }
        // ادا اجابه صح بنلونها اخضر ادا خطا احمر بنلوها وبنشغل تايمر بعدها ويفحص احمر ولا اخضر جواب 
        private void label17_Click(object sender, EventArgs e)
        {
            if (an == 1)
            {
                timer1.Start();
                answer = true;
                label17.BackColor = Color.Green;
            }
            else
            {
                answer = false;
                label17.BackColor = Color.Red;
                timer1.Start();
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (an == 2)
            {
                timer1.Start();

                answer = true;
                label18.BackColor = Color.Green;
            }
            else
            {
                answer = false;
                label18.BackColor = Color.Red;
                timer1.Start();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (an == 3)
            {
                timer1.Start(); 
                answer = true;
                label19.BackColor = Color.Green;
            }
            else
            {
                answer = false;
                label19.BackColor = Color.Red;
                timer1.Start();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (an == 4)
            {
                timer1.Start();
                answer = true;
                label20.BackColor = Color.Green;
            }
            else
            {
                answer = false;
                label20.BackColor = Color.Red;
                timer1.Start();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (an == 1)
            {

                label18.Visible = false;
                label20.Visible = false;
            }
            if (an == 2)
            {
                label19.Visible = false;
                label17.Visible = false;
            }
            if (an == 3)
            {
                label17.Visible = false;
                label20.Visible = false;
            }
            if (an == 4)
            {
                label18.Visible = false;
                label19.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            if (x == 6) x = 1;
            if (win == 1)
            {

                label21.Text = "זה צבר 1,000,000 ברכות";
                x++;
                switch (x)
                {
                    case 1: label21.ForeColor = Color.White;
                        break;
                    case 2: label21.ForeColor = Color.Red;
                        break;
                    case 3: label21.ForeColor = Color.Gold;
                        break;
                    case 4: label21.ForeColor = Color.Green;
                        break;
                    case 5: label21.ForeColor = Color.Cyan;
                        break;
                }

                DialogResult dialogResult = MessageBox.Show("Try again", "Try again", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    timer1.Stop();
                    this.Hide();
                    million f1 = new million(s);
                    f1.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    timer1.Stop();
                    this.Hide();
                    Form10 f1 = new Form10(s);
                    f1.Show();
                }





            }

            switch (tm)
            {
                case 0:
                    label15.ForeColor = Color.Blue;
                    break;
                case 1:
                    label14.ForeColor = Color.Red;
                    break;
                case 2:
                    label13.ForeColor = Color.Green;
                    break;
                case 3:
                    label12.ForeColor = Color.Yellow;
                    break;
                case 4:
                    label11.ForeColor = Color.Orange;
                    break;
                case 5:
                    label1.ForeColor = Color.OliveDrab;
                    break;
                case 6:
                    label2.ForeColor = Color.OrangeRed;
                    break;
                case 7:
                    label3.ForeColor = Color.Brown;
                    break;
                case 8:
                    label4.ForeColor = Color.Gold;
                    break;
                case 9:
                    label5.ForeColor = Color.GhostWhite;
                    break;
                case 10:
                    label6.ForeColor = Color.Cyan;
                    break;
                case 11:
                    label7.ForeColor = Color.Coral;
                    break;
                case 12:
                    label8.ForeColor = Color.BlueViolet;
                    break;
                case 13:
                    label9.ForeColor = Color.DarkRed;
                    break;
                case 14:
                    label10.ForeColor = Color.White;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            this.Hide();
            Form10 f1 = new Form10(0);
            f1.Show();
        }

    }
}

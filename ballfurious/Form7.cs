using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ballfurious
{
    public partial class Form7 : Form
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

        #region Local Variables

        private bool[,] point; // Ground
        private Point headPoint = new Point();// نقاط الجسم ادا اكل يكبر جسمه
        private Point tailPoint = new Point();
        private Point tailBeforePointPrevious = new Point();
        private Point tailBeforePoint = new Point();
        private List<Point> points = new List<Point>(); // The snake points
        private int direction = 2;
        private Ground ground;
        private Food food;
        private Point recentFoodloc;// last created food item location
        private bool foodShouldCreate = false;
        private FoodType ft;
        private bool skipKeystroke = true;
        private bool shouldExpand = false;
        private Image iHead = null;
        private Image iBody = null;
        private Image iTail = null;
        private Image iTailtemp = null;
        private bool rotatedX1 = false;
        private bool rotatedX2 = false;
        private bool rotatedY1 = false;
        private bool rotatedY2 = false;
        private static int level = 1;
        private static int score = 0;

        #endregion

        #region Events

        private delegate void FoodAtedHandler();
        private event FoodAtedHandler FoodAted;

        private delegate void LevelCompletedHandler();
        private event LevelCompletedHandler LevelComplted;

        #endregion

        int s;
        public Form7(int _s)
        {
            this.s = _s;
            InitializeComponent();
            ground.Height = 15;
            ground.Width = 15;

            // Initiate food
            food = new Food(ground);
            recentFoodloc = food.GetFoodLocation();
            ft = food.GetFoodType();

            iHead = Image.FromFile("head.png");
            iBody = Image.FromFile("body.png");
            iTail = Image.FromFile("tail.png");

            // represents the ground area
            point = new bool[ground.Height, ground.Width];

            point[0, 0] = true;

            this.FoodAted += new FoodAtedHandler(frmSnake_FoodAted);
            this.LevelComplted += new LevelCompletedHandler(frmSnake_LevelComplted);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                System.Media.SoundPlayer play = new System.Media.SoundPlayer();
                play.SoundLocation = "music\\4.wav";
                play.Play();
            }
            this.TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pnlGround_Paint(object sender, PaintEventArgs e)
        {

            
                if (e == null || e.Graphics == null)
                    return;

                Graphics g = e.Graphics;
                int x = 0;
                int y = 0;

                while (y < ground.Height)
                {
                    bool skip = false;
                    if (point[x, y] == true)
                    {
                        /* Update GUI */
                        //g.FillRectangle(Brushes.GreenYellow, x * 32, y * 32, 32, 32);

                        if (x == headPoint.X && y == headPoint.Y) // This was head
                        {
                            g.DrawImage(this.GetRotatedImage(iHead), x * 32, y * 32, 32, 32);
                        }
                        else if (x == tailPoint.X && y == tailPoint.Y) // This was tail
                        {
                            g.DrawImage(this.GetTailRotatedImage(iTail), x * 32, y * 32, 32, 32);
                        }
                        else // Body
                        {
                            g.DrawImage(this.GetRotatedImage(iBody), x * 32, y * 32, 32, 32);
                        }

                        /* Create the food */
                        this.CreateFood(g);
                    }
                    if (x >= (ground.Width - 1))
                    {
                        x = 0;
                        y++;
                        skip = true;
                    }
                    if (x < (ground.Width - 1) && skip == false)
                    {
                        x++;
                    }
                }
            

        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {

                switch (e.KeyCode)
                {
                    case Keys.Up:
                        direction = 1;
                        break;
                    case Keys.Down:
                        direction = 2;
                        break;
                    case Keys.Left:
                        direction = 3;
                        break;
                    case Keys.Right:
                        direction = 4;
                        break;

                    default:
                        break;
                }
          
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented!");
            // Dispose everything here related to the game window                     
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                if (MessageBox.Show("Quit Y/N?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    Application.Exit();
                else
                { }
           
        }
        #region Helper Methods

        private void UpdateGUIPoints()
        {
            Point tempPoint = new Point();
            tempPoint = points[points.Count - 1];

            // Make the points come one after the other
            for (int i = 0; i < points.Count; i++)
            {
                if ((points.Count - (i + 2)) >= 0)
                {
                    points[points.Count - (i + 1)] = points[points.Count - (i + 2)];
                }
            }
            points[0] = headPoint;

            // If food was eaten
            if (shouldExpand)
            {
                points.Add(tempPoint);
                tailPoint = tempPoint;
                tailBeforePoint = points[points.Count - 2];
            }
            else
            {
                tailPoint = points[points.Count - 1];
                tailBeforePoint = points[points.Count - 2];
            }

            // Set the paintable points
            for (int k = 0; k < points.Count; k++)
            {
                point[points[k].X, points[k].Y] = true;
            }
        }

        /// Draws the food item

        private void CreateFood(Graphics g)
        {
            if (g == null)
                return;

            /* Get food item  */
            if (this.foodShouldCreate)
            {
                Point p = food.GetFoodLocation();

                while (points != null && points.Contains(p))
                    p = food.GetFoodLocation();

                ft = food.GetFoodType();
                g.DrawImage(food.GetImageForFoodItem(ft), p.X * 32, p.Y * 32, 32, 32);

                // Created a food just now
                foodShouldCreate = false;
                // Keep the food location in memory
                recentFoodloc = p;
            }
            else
            {
                g.DrawImage(food.GetImageForFoodItem(ft), recentFoodloc.X * 32, recentFoodloc.Y * 32, 32, 32);
            }
        }

       
        /// Rotate the head image accordingly to the direction
 
        private Image GetRotatedImage(Image pI)
        {
            if (pI == null)
                return null;

            if (direction == 1)
                return pI;
            else if (direction == 2)
                return Util.RotateImage(pI, 180);
            else if (direction == 3)
                return Util.RotateImage(pI, 270);
            else if (direction == 4)
                return Util.RotateImage(pI, 90);
            else
            { }

            return null;
        }


        private Image GetTailRotatedImage(Image pI)
        {
            //if (tailBeforePointPrevious == tailBeforePoint)
            //    return iTail;

            if (tailBeforePoint.X > tailBeforePointPrevious.X && (!rotatedX1))
            {
                // ->
                tailBeforePointPrevious = tailBeforePoint;
                iTailtemp = Util.RotateImage(iTail, 90);
                rotatedX1 = true; rotatedX2 = false; rotatedY1 = false; rotatedY2 = false;
            }
            if (tailBeforePoint.X < tailBeforePointPrevious.X && (!rotatedX2))
            {
                tailBeforePointPrevious = tailBeforePoint;
                iTailtemp = Util.RotateImage(iTail, 270);
                rotatedX1 = false; rotatedX2 = true; rotatedY1 = false; rotatedY2 = false;
            }
            if (tailBeforePoint.Y > tailBeforePointPrevious.Y && (!rotatedY1))
            {
                // Down
                tailBeforePointPrevious = tailBeforePoint;
                iTailtemp = Util.RotateImage(iTail, 180);
                rotatedX1 = false; rotatedX2 = false; rotatedY1 = true; rotatedY2 = false;
            }
            if (tailBeforePoint.Y < tailBeforePointPrevious.Y && (!rotatedY2))
            {
                // ^
                tailBeforePointPrevious = tailBeforePoint;
                iTailtemp = Util.RotateImage(iTail, 0);
                rotatedX1 = false; rotatedX2 = false; rotatedY1 = false; rotatedY2 = true;
            }

            return iTailtemp;
        }

        private void ResetLocalVariables()
        {
            direction = 2;
            Array.Clear(point, 0, point.Length);
            headPoint = new Point();
            tailPoint = new Point();
            tailBeforePointPrevious = new Point();
            tailBeforePoint = new Point();
            points.Clear();

            //this.Invalidate();
        }

        private void frmSnake_FoodAted()
        {
            // Update the Score
            score += 100;
            lblScore.Text = score.ToString();

            if ((score % 1000) == 0)
            {
             //   Interlocked.CompareExchange(ref LevelComplted, null, null);
                if (this.LevelComplted != null)
                    this.LevelComplted();
            }
        }
        /// Triggers when each level completes
    
        private void frmSnake_LevelComplted()
        {
            level += 1;
            tmrSnake.Interval -= 100;
            this.lblLevel.Text = level.ToString();
        }
        #endregion

        private void tmrSnake_Tick(object sender, EventArgs e)
        {
            // Stops the timer
            tmrSnake.Stop();

            try
            {
                int x = 0; int y = 0;
                while (y < ground.Height)
                {
                    bool skip = false;

                    if (direction == 1) // Up
                    {
                        Array.Clear(point, 0, point.Length);
                        point[headPoint.X, headPoint.Y] = false;

                        headPoint = new Point(headPoint.X, headPoint.Y - 1);
                        if (points != null && points.Contains(headPoint))
                            throw new GameOverException(GameOverException.INVALID_HEAD_POINT);

                        if (headPoint == recentFoodloc)
                        {
                            foodShouldCreate = true;
                            shouldExpand = true;

                       //     Interlocked.CompareExchange(ref FoodAted, null, null);
                            if (FoodAted != null)
                            {
                                FoodAted();
                            }
                        }

                        UpdateGUIPoints();
                        shouldExpand = false;
                        break;
                    }

                    if (direction == 2) // Down
                    {
                        if (point[x, y] == true && skipKeystroke == true)
                        {
                            point[x, y] = false;
                            point[x, y + 1] = true;
                            point[x, y + 2] = true;
                            point[x, y + 3] = true;
                            headPoint = new Point(x, y + 3);

                            points.Clear();
                            points.Add(new Point(x, y + 1));
                            points.Add(new Point(x, y + 2));
                            points.Add(new Point(x, y + 3));
                            break;
                        }
                        if (!skipKeystroke)
                        {
                            Array.Clear(point, 0, point.Length);
                            point[headPoint.X, headPoint.Y] = false;

                            headPoint = new Point(headPoint.X, headPoint.Y + 1);
                            if (points != null && points.Contains(headPoint))
                                throw new GameOverException(GameOverException.INVALID_HEAD_POINT);

                            if (headPoint == recentFoodloc)
                            {
                                foodShouldCreate = true;
                                shouldExpand = true;

                                //Interlocked.CompareExchange(ref FoodAted, null, null);
                                if (FoodAted != null)
                                {
                                    FoodAted();
                                }
                            }

                            UpdateGUIPoints();
                            shouldExpand = false;
                            break;
                        }
                    }

                    if (direction == 3) // Left
                    {
                        Array.Clear(point, 0, point.Length);
                        point[headPoint.X, headPoint.Y] = false;

                        headPoint = new Point(headPoint.X - 1, headPoint.Y);
                        if (points != null && points.Contains(headPoint))
                            throw new GameOverException(GameOverException.INVALID_HEAD_POINT);

                        if (headPoint == recentFoodloc)
                        {
                            foodShouldCreate = true;
                            shouldExpand = true;

                           // Interlocked.CompareExchange(ref FoodAted, null, null);
                            if (FoodAted != null)
                            {
                                FoodAted();
                            }
                        }

                        UpdateGUIPoints();
                        shouldExpand = false;
                        break;
                    }

                    if (direction == 4) // Right
                    {
                        skipKeystroke = false;

                        Array.Clear(point, 0, point.Length);
                        point[headPoint.X, headPoint.Y] = false;
                        // Direct head point only
                        headPoint = new Point(headPoint.X + 1, headPoint.Y);
                        if (points != null && points.Contains(headPoint))
                            throw new GameOverException(GameOverException.INVALID_HEAD_POINT);

                        if (headPoint == recentFoodloc)
                        {
                            foodShouldCreate = true;
                            shouldExpand = true;

                            //Interlocked.CompareExchange(ref FoodAted, null, null);
                            if (FoodAted != null)
                            {
                                FoodAted();
                            }
                        }

                        // Let tail points come one after the other
                        UpdateGUIPoints();
                        shouldExpand = false;
                        break;
                    }

                    // cotinues going
                    if (x >= (ground.Width - 1))
                    {
                        x = 0; y++;
                        skip = true;
                    }
                    if (x < (ground.Width - 1) && skip == false)
                    {
                        x++;
                    }
                }

                pnlGround.Invalidate();
            }
            catch (GameOverException)
            {
                MessageBox.Show("Game Over!");
                tmrSnake.Stop();
                return;
            }
            catch
            {
                MessageBox.Show("Game Over!");
                tmrSnake.Stop();
                return;
            }

            // Start the timer again
            tmrSnake.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tmrSnake.Stop();
            this.Hide();
            game f1 = new game(s);
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbx_Click(object sender, EventArgs e)
        {

        }


         
    }
}

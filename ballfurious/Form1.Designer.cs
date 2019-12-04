namespace ballfurious
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.p15 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.player = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.p3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.p5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.p4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.p2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.p1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.p15,
            this.player,
            this.p3,
            this.p5,
            this.p4,
            this.p2,
            this.p1});
            this.shapeContainer1.Size = new System.Drawing.Size(1284, 741);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // p15
            // 
            this.p15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.p15.BorderColor = System.Drawing.Color.Yellow;
            this.p15.FillColor = System.Drawing.Color.Gold;
            this.p15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.p15.Location = new System.Drawing.Point(897, 488);
            this.p15.Name = "p15";
            this.p15.Size = new System.Drawing.Size(31, 57);
            // 
            // player
            // 
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.player.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.player.Location = new System.Drawing.Point(482, 41);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(15, 15);
            this.player.Click += new System.EventHandler(this.player_Click_1);
            // 
            // p3
            // 
            this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p3.BackgroundImage")));
            this.p3.Location = new System.Drawing.Point(99, 294);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(828, 190);
            // 
            // p5
            // 
            this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p5.BackgroundImage")));
            this.p5.Location = new System.Drawing.Point(51, 548);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(876, 71);
            // 
            // p4
            // 
            this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p4.BackgroundImage")));
            this.p4.Location = new System.Drawing.Point(32, 239);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(21, 382);
            // 
            // p2
            // 
            this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p2.BackgroundImage")));
            this.p2.Location = new System.Drawing.Point(519, 26);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(408, 287);
            // 
            // p1
            // 
            this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p1.BackgroundImage")));
            this.p1.Location = new System.Drawing.Point(32, 27);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(425, 213);
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p6.Image = ((System.Drawing.Image)(resources.GetObject("p6.Image")));
            this.p6.Location = new System.Drawing.Point(492, 485);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(25, 66);
            this.p6.TabIndex = 2;
            this.p6.TabStop = false;
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p7.Image = ((System.Drawing.Image)(resources.GetObject("p7.Image")));
            this.p7.Location = new System.Drawing.Point(472, 548);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(67, 74);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p7.TabIndex = 3;
            this.p7.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1010, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 118);
            this.label1.TabIndex = 4;
            this.label1.Text = "          ";
         
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(0, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "חזרה";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 658);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 83);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape p1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape p3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape p5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape p4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape p2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape player;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape p15;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
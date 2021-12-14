namespace Santa_Claus_is_Coming_To_Town
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.Moon = new System.Windows.Forms.PictureBox();
            this.Hut = new System.Windows.Forms.PictureBox();
            this.SnowFlake = new System.Windows.Forms.PictureBox();
            this.Santa = new System.Windows.Forms.PictureBox();
            this.Tree = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(1, 432);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(798, 94);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // Moon
            // 
            this.Moon.Image = ((System.Drawing.Image)(resources.GetObject("Moon.Image")));
            this.Moon.Location = new System.Drawing.Point(12, 12);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(100, 89);
            this.Moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Moon.TabIndex = 1;
            this.Moon.TabStop = false;
            // 
            // Hut
            // 
            this.Hut.Image = ((System.Drawing.Image)(resources.GetObject("Hut.Image")));
            this.Hut.Location = new System.Drawing.Point(614, 280);
            this.Hut.Name = "Hut";
            this.Hut.Size = new System.Drawing.Size(147, 159);
            this.Hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hut.TabIndex = 2;
            this.Hut.TabStop = false;
            // 
            // SnowFlake
            // 
            this.SnowFlake.Image = ((System.Drawing.Image)(resources.GetObject("SnowFlake.Image")));
            this.SnowFlake.Location = new System.Drawing.Point(472, 20);
            this.SnowFlake.Name = "SnowFlake";
            this.SnowFlake.Size = new System.Drawing.Size(100, 81);
            this.SnowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SnowFlake.TabIndex = 3;
            this.SnowFlake.TabStop = false;
            // 
            // Santa
            // 
            this.Santa.Image = ((System.Drawing.Image)(resources.GetObject("Santa.Image")));
            this.Santa.Location = new System.Drawing.Point(37, 230);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(161, 90);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Santa.TabIndex = 4;
            this.Santa.TabStop = false;
            this.Santa.Click += new System.EventHandler(this.Santa_Click);
            // 
            // Tree
            // 
            this.Tree.Image = ((System.Drawing.Image)(resources.GetObject("Tree.Image")));
            this.Tree.Location = new System.Drawing.Point(339, 280);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(100, 169);
            this.Tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree.TabIndex = 6;
            this.Tree.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(69, 121);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(151, 33);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "score: 0";
            // 
            // playAgain
            // 
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(339, 105);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(127, 79);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "PLAY AGAIN";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(811, 538);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.SnowFlake);
            this.Controls.Add(this.Hut);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox Moon;
        private System.Windows.Forms.PictureBox Hut;
        private System.Windows.Forms.PictureBox SnowFlake;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.PictureBox Tree;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button playAgain;
    }
}


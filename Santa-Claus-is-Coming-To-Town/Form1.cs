using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_Claus_is_Coming_To_Town
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int score = 0;
        int backroundSpeed = 3;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer_Click(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            SnowFlake.Left -= pipeSpeed;
            Tree.Left -= pipeSpeed;
            Moon.Left -= backroundSpeed;
            Hut.Left -= backroundSpeed;
            scoreLabel.Text = $"score: {score}";

            if (SnowFlake.Left < -100)
            {
                SnowFlake.Left = 1000;
            }
            if (Tree.Left < -100)
            {
                Tree.Left = 900;
                score++;
            }
            if (Moon.Left < -100)
            {
                Moon.Left = 800;
            }
            if (Hut.Left < -100)
            {
                Hut.Left = 900;
            }
            if (Santa.Top < -25)
            {
                gameover();
            }
            if (Santa.Bounds.IntersectsWith(SnowFlake.Bounds) || Santa.Bounds.IntersectsWith(Tree.Bounds) || Santa.Bounds.IntersectsWith(ground.Bounds))
            {
                gameover();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void Santa_Click(object sender, EventArgs e)
        {

        }
        private void gameover()
        {
            timer1.Stop();
            scoreLabel.Text = $"Game Over";
            playAgain.Visible = true; 
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird2
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEventt(object sender, EventArgs e)
        {
            Flappybird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score;

            if(pipeDown.Left < -150)
            {
                pipeDown.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if(Flappybird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                Flappybird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Flappybird.Bounds.IntersectsWith(Ground.Bounds) || Flappybird.Top < -25
                )
            {
                endGame();
            }
            if(score > 5)
            {
                pipeSpeed = 15;
            }
          
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
            
        }

        private void gameheyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text += "Game Over!";
        }

        private void ScoreText_Click(object sender, EventArgs e)
        {

        }
    }
}

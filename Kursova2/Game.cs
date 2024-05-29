using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Kursova2
{
    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();

        }
        int Ball_x = 4;
        int Ball_y = 4;
        int score = 0;


        private void Game_Load(object sender, EventArgs e)
        {
            lbl_score.Text = $"Hi {Data.datUsername}, press space to start";
            SetGameLevel(Data.mode);
            SetBallPicture(Data.imageName);
        }

        private void SetBallPicture(string picture)
        {
            switch (picture)
            {
                case "red_triangle":
                    ball.Image = Properties.Resources._red_triangle;
                    break;
                case "green_triangle":
                    ball.Image = Properties.Resources._green_triangle;
                    break;
                case "blue_triangle":
                    ball.Image = Properties.Resources._blue_triangle;
                    break;
                case "red_circle":
                    ball.Image = Properties.Resources._red_circle;
                    break;
                case "green_circle":
                    ball.Image = Properties.Resources._green_circle;
                    break;
                case "blue_circle":
                    ball.Image = Properties.Resources._blue_circle;
                    break;
                case "red_square":
                    ball.Image = Properties.Resources._red_square;
                    break;
                case "green_square":
                    ball.Image = Properties.Resources._green_square;
                    break;
                case "blue_square":
                    ball.Image = Properties.Resources._blue_square;
                    break;
            }
        }

        private void SetGameLevel(string lvl)
        {
            switch (lvl)
            {
                case "Easy":
                    timer.Interval = 25;
                    break;
                case "Normal":
                    timer.Interval = 10;
                    break;
                case "Hard":
                    timer.Interval = 3;
                    break;
            }
        }
        private void Ball_Moving()
        {
            ball.Left += Ball_x;
            ball.Top += Ball_y;

            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                Ball_x = -Ball_x;
            }
            if (ball.Top < 0 || ball.Bounds.IntersectsWith(slider.Bounds))
            {
                Ball_y = -Ball_y;
            }
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left && slider.Left > 0)
            {
                slider.Left -= 10;
            }
            if (e.KeyCode == Keys.Right && slider.Right < 680)
            {
                slider.Left += 10;
            }

        }



        private void Game_Over()
        {

            if (ball.Top + ball.Height > ClientSize.Height)
            {
                timer.Stop();
                var result = MessageBox.Show("Game Over", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            else if (score == 24)
            {
                timer.Stop();
                var result = MessageBox.Show("You win", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }

        }

        private void Get_Score()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        Ball_y = -Ball_y;
                        score++;
                        lbl_score.Text = Data.datUsername + "'s score: " + score;
                    }
                }
            }
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            Ball_Moving();
            Get_Score();
            Game_Over();
        }

        private bool isGameStarted = false;
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!isGameStarted)
                {
                    
                    lbl_score.Text = Data.datUsername + "'s score: 0 ";
                    timer.Start();
                    isGameStarted = true;
                }
                else
                {
                    if (timer.Enabled)
                    {
                        
                        timer.Stop();
                        MessageBox.Show("Game Paused. Press Space to continue playing");
                    }
                    else
                    {
                        
                        timer.Start();
                    }
                }
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


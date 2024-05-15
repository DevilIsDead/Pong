using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {

        bool goUp1;
        bool goDown1;
        bool goUp2;
        bool goDown2;
        int ballSpeedX = 6;
        int ballSpeedY = 4;
        int score1 = 0;
        int score2 = 0;
        int xStart1 = 450;
        int xStart2 = 820;
        int yStart = 360;
        int botSpeed = 5;

        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();
            pictureBox1.Controls.Add(P1);
            pictureBox1.Controls.Add(P2);
            pictureBox1.Controls.Add(ball);
            ball.BackgroundImage = null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Up:
                    if (this.P2.Location.Y > 0)
                        goUp1 = true;
                    break;
                case Keys.Down:
                    if (this.P2.Location.Y < 560)
                        goDown1 = true;
                    break;
                case Keys.W:
                    if (this.P1.Location.Y > 0)
                        goUp1 = true;
                    break;
                case Keys.S:
                    if (this.P1.Location.Y < 560)
                        goDown1 = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    goUp1 = false;
                    break;
                case Keys.Down:
                    goDown1 = false;
                    break;
                case Keys.W:
                    goUp1 = false;
                    break;
                case Keys.S:
                    goDown1 = false;
                    break;
            }
        }

        private void gameTimer(object sender, EventArgs e)
        {
            p1score.Text = "" + score1;
            p2score.Text = "" + score2;

            if (ball.Top < 0)
            {
                ballSpeedY = -ballSpeedY;
                ball.Top += 1;
                if (ballSpeedY > 5)
                    ballSpeedY -= 1;
                if (ballSpeedY < -5)
                    ballSpeedY += 1;
                if (ballSpeedX > 5)
                    ballSpeedX -= 1;
                if (ballSpeedX < -5)
                    ballSpeedX += 1;
            }
            if (ball.Top > 700)
            {
                ballSpeedY = -ballSpeedY;
                ball.Top -= 1;
                if (ballSpeedY > 5)
                    ballSpeedY -= 1;
                if (ballSpeedY < -5)
                    ballSpeedY += 1;
                if (ballSpeedX > 5)
                    ballSpeedX -= 1;
                if (ballSpeedX < -5)
                    ballSpeedX += 1;

            }
            if (ball.Left < 5)
            {
                ball.Location = new Point(xStart1, yStart);
                ballSpeedX = -8;
                ballSpeedY = -6;
                score2 += 1;
            }
            if (ball.Left > 1260)
            {
                ball.Location = new Point(xStart2, yStart);
                ballSpeedX = 8;
                ballSpeedY = -6;
                score1 += 1;
            }

            calcBot(P2, ref goUp2, ref goDown2);
            
            movePlayer(P1, goUp1, goDown1);
            
            if (ball.Left < 40) { }
                checkCollision(P1, ball, goUp1, goDown1);
            if (ball.Left > 1220)
                checkCollision(P2, ball, goUp2, goDown2);

            ball.Top -= ballSpeedY;
            ball.Left -= ballSpeedX;
        }

        private void movePlayer (PictureBox P, bool goUp, bool goDown)
        {
            if (goDown)
                if (P.Location.Y < 560)
                    P.Top += 10;
            if (goUp)
                if (P.Location.Y > 0)
                    P.Top -= 10;
            
        }

        private void calcBot (PictureBox P, ref bool goUp, ref bool goDown)
        {
            if ((P.Location.Y + 80) > ball.Location.Y) 
            {
                goDown = false;
                goUp = true;
            } else if ((P.Location.Y + 80) < ball.Location.Y)
            {
                goUp = false;
                goDown = true;
            } else
            {
                goUp = false;
                goDown = false;
            }
            if ((P.Location.X - ball.Location.X) > 800)
            {
                botSpeed = 2;
            } else if ((P.Location.X - ball.Location.X) < 800 && (P.Location.X - ball.Location.X) > 400) 
            {
                botSpeed = 4;
            } else
            {
                botSpeed = 6;
            }

            if (goDown)
                if (P.Location.Y < 560)
                    P.Top += botSpeed;
            if (goUp)
                if (P.Location.Y > 0)
                    P.Top -= botSpeed;

        }

        private void checkCollision(PictureBox pictureBox1, PictureBox pictureBox2, bool up, bool down)
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds)) {
                if (up && ballSpeedY > 0)
                {
                    if (ballSpeedY < 15)
                        ballSpeedY += 2;
                    if (ballSpeedX > 0 && ballSpeedX <= 20)
                        ballSpeedX += 2;
                    else if (ballSpeedX >= -10) ballSpeedX -=2;

                } else if (up && ballSpeedY <= 0)
                {
                    if (ballSpeedY > -15)
                        ballSpeedY += 1;
                    if (ballSpeedX > 0 && ballSpeedX >= 6)
                        ballSpeedX += 3;
                    else if (ballSpeedX <= -10) ballSpeedX -= 3;

                } else if (down && ballSpeedY < 0)
                {
                    if (ballSpeedY > -15)
                        ballSpeedY -= 2;
                    if (ballSpeedX > 0 && ballSpeedX <= 20)
                        ballSpeedX += 2;
                    else if (ballSpeedX >= -10) ballSpeedX -= 2;

                } else if (down && ballSpeedY >= 0)
                {
                    if (ballSpeedY < 15)
                        ballSpeedY += 1;
                    if (ballSpeedX > 0 && ballSpeedX >= 6)
                        ballSpeedX += 3;
                    else if (ballSpeedX <= -10) ballSpeedX -= 3;

                }
                ballSpeedX = -ballSpeedX;
                if (ball.Location.X < 633) {
                    ball.Left += 3;
                } else
                {
                    ball.Left -= 3;
                }
            }
        }
    }
}

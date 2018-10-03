using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINDEMO
{
    public partial class Form1 : Form
    {
        bool goLeft;
        bool goRight;
        bool isPressed;
        int speed = 5;
        int score = 0;
        int totEnemies = 12;
        int playSpeed = 5;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && (player.Left >= (this.Width - player.Width)))
            {
                goLeft = true;
            }
            //Dont want else if, need both conditions to be checked constantly
            if (e.KeyCode == Keys.Right && (player.Left <= (this.Width - player.Width)))
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
                makeBullet();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        { //Resetting stuff
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            //Dont want else if, need both conditions to be checked constantly
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                isPressed = false;
            }
        }

        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "bullet";
            bullet.Left = player.Left + player.Width / 2; //Centering the bullet on the player
            bullet.Top = player.Top - 20; //Centering it from our tank cannon
            this.Controls.Add(bullet);
            bullet.BringToFront();
        } 

        private void makeStars()
        {
            PictureBox star = new PictureBox();
            star.Image = Properties.Resources.star;
            star.Size = new Size(2, 2);
            star.Tag = "star";
            star.Top = this.Height - 500;
            star.Left = randGen.Next(1, 800);
            this.Controls.Add(star);
            star.BringToFront();

            PictureBox rareStar = new PictureBox();
            rareStar.Image = Properties.Resources.rareStar;
            rareStar.Size = new Size(3, 3);
            rareStar.Tag = "rareStar";
            rareStar.Top = this.Height - 500;
            rareStar.Left = randGen.Next(1, 800);
            this.Controls.Add(rareStar);
            rareStar.BringToFront();

            PictureBox redStar = new PictureBox();
            redStar.Image = Properties.Resources.redStar;
            redStar.Size = new Size(4, 2);
            redStar.Tag = "redStar";
            redStar.Top = this.Height - 500;
            redStar.Left = randGen.Next(200, 600);
            this.Controls.Add(redStar);
            redStar.BringToFront();
        }

        //Essentially our game loop/heartbeat below
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 0;//Proper reset for things
            invaders.Image = Properties.Resources.invaders;//Reset to ensure out invaders stay in default position/reset to it
            makeStars();
            foreach (Control q in this.Controls)
            {
                if (q is PictureBox && q.Tag == "star")
                {
                    q.Top += randGen.Next(1, 40);
                    if (((PictureBox)q).Top > this.Height)
                    {
                        this.Controls.Remove(q);
                    }
                }
            }//End star finding
            foreach (Control qs in this.Controls)
            {
                if (qs is PictureBox && qs.Tag == "rareStar" || qs is PictureBox && qs.Tag == "redStar")
                {
                    qs.Top += randGen.Next(20, 60);
                    if (((PictureBox)qs).Top > this.Height)
                    {
                        this.Controls.Remove(qs);
                    }
                }
            }//End star finding
            if (goLeft)
            {
                player.Left -= playSpeed;
            } else if (goRight)
            {
                player.Left += playSpeed; //THis is abckwards and goofy
            }

            if (timer1.Interval > 1000)
            {
                //Change invader sprite on the fly for animation
                invaders.Image = Properties.Resources.UpAnim;
            }

            //x is the enemy invader We use x in order to keep things...condensed
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "invaders")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver();
                    }
                    ((PictureBox)x).Left += speed;
                    if (((PictureBox)x).Left > 720)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 10; //Moves them down
                        ((PictureBox)x).Left = -50; //Resets them off screen a bit to the left
                    }
                }
            }//ENd foreach getting invaders
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "bullet")
                {
                    y.Top -= 20;
                    if (((PictureBox)y).Top < this.Height - 490)
                    {
                        this.Controls.Remove(y);//Bullet is off screen so kill it
                    }
                }
            }//End bullet finding
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "invaders")
                    {
                        if (j is PictureBox && j.Tag == "bullet")
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                totEnemies--;
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                            }
                        }
                    }
                }//End inner foreach
            }//end outer foreach
            label1.Text = "Score:  " + score;
            if (totEnemies <= 0)
            {
                gameOver();//Winning state
            }
        }

        private void gameOver()
        {
            label1.Top = this.Height / 2;
            label1.Left = this.Height / 2;
            label1.Text = "Game Over\nPress ESC to play again";
            /*if (e.KeyCode == Keys.Escape)
            {
                //Code to reset game
            }*/
        }
    }
}

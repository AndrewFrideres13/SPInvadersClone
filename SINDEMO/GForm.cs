using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace SINDEMO
{
  public partial class GForm : Form
  {
    bool goLeft;
    bool goRight;
    bool restart;
    bool isFiring;
    int speed = 6;
    int score = 0;
    const int totEnemies = 12;//Dont need this to change
    const int playSpeed = 6;
    int randValue = 0;
    Random randGen = new Random();
    Stars starMaker = new Stars();
    public GForm() { InitializeComponent(); }
    private void keyisdown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        restart = true;
      }
      if (e.KeyCode == Keys.Left)
      {
        goLeft = true;
      }
      //Dont want else if, need both conditions to be checked constantly
      if (e.KeyCode == Keys.Right)
      {
        goRight = true;
      }
      if (e.KeyCode == Keys.Space && !isFiring) //Just need to check if bullet is alive
      {
        isFiring = true;
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
   
    //Essentially our game loop/heartbeat below
    private void gameLoop_Tick(object sender, EventArgs e)
    {
      randValue = randGen.Next(1, 50);
      //invaders.Image = Properties.Resources.invaders;//Reset to ensure out invaders stay in default position/reset to it
      starMaker.makeStars(this.Height, this);
      starMaker.getGroup(this);
      if (goLeft && !(player.Left < 10)) //Setting left movement and left bound
      {
        player.Left -= playSpeed;
      }
      else if (goRight && !(player.Left > 630))//Right bound and movement
      {
        player.Left += playSpeed; //THis is abckwards and goofy
      }
      if (restart) //Continue game code
      {
        Application.Restart();
      }

      //x is the whatever object we grab in the control
      foreach (Control x in this.Controls)
      {
        if (x is PictureBox && x.Tag == "invaders")
        {
          if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
          {
            gameOver();
            this.Controls.Remove(player);
          }
            ((PictureBox)x).Left += speed;
          if (((PictureBox)x).Left > 720)
          {
            ((PictureBox)x).Top += ((PictureBox)x).Height + 10; //Moves them down
            ((PictureBox)x).Left = -50; //Resets them off screen a bit to the left
          }

          if (randValue % 4 == 1) {
            //Change invader sprite on the fly for animation
            ((PictureBox)x).Image = Properties.Resources.UpAnim; 
          }
          else
          {
            ((PictureBox)x).Image = Properties.Resources.invaders;
          }
        }//End invader logic
        if (x is PictureBox && x.Tag == "bullet")
        {
          x.Top -= 21;
          if (((PictureBox)x).Top < this.Height - 490)
          {
            this.Controls.Remove(x);//Bullet is off screen so kill it
            isFiring = false;
          }
        }//End bullet segment
        foreach (Control j in this.Controls) //Collision between bullet and enemies below
        {
          if (x is PictureBox && x.Tag == "invaders")
          {
            if (j is PictureBox && j.Tag == "bullet")
            {
              if (x.Bounds.IntersectsWith(j.Bounds))
              {
                this.Controls.Remove(x);
                this.Controls.Remove(j);
                score++;
                isFiring = false;
              }
            }
          }
        }//End inner foreach
      }//ENd foreach 
      stateLabel.Text = "Score:  " + score;
      if (score >= totEnemies*0.5) //Score greater or equal half the enemies
      {
        speed = 11;
      }
      if (score >= totEnemies-1) //Down to last enemy
      {
        speed = 16;
      }
      if (score == totEnemies)
      {
        gameOver();//Winning state
      }
    }

    private void gameOver()
    {
      stateLabel.Top = (this.Height / 2)-25;
      stateLabel.Left = (this.Height / 2)-30;
      stateLabel.Text = "Press Esc to play again!";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      

    }
  }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SINDEMO
{
  public partial class Stars
  {
    private Random randGen = new Random();
    public void makeStars(int height, Control mForm)
    {
      PictureBox star = new PictureBox();
      star.Image = Properties.Resources.star;
      star.Size = new Size(2, 2);
      star.Tag = "star";
      star.Top = height - 500;
      star.Left = randGen.Next(1, 800);
      mForm.Controls.Add(star);
      star.BringToFront();

      PictureBox rareStar = new PictureBox();
      rareStar.Image = Properties.Resources.rareStar;
      rareStar.Size = new Size(3, 3);
      rareStar.Tag = "rareStar";
      rareStar.Top = height - 500;
      rareStar.Left = randGen.Next(100, 800);
      mForm.Controls.Add(rareStar);
      rareStar.BringToFront();

      PictureBox redStar = new PictureBox();
      redStar.Image = Properties.Resources.redStar;
      redStar.Size = new Size(4, 2);
      redStar.Tag = "redStar";
      redStar.Top = height - 500;
      redStar.Left = randGen.Next(200, 600);
      mForm.Controls.Add(redStar);
      redStar.BringToFront();
    }//End star creation

    public void getGroup(Form mainForm)
    {
      foreach (Control actor in mainForm.Controls)
      {
        if (actor is PictureBox && actor.Tag == "star")
        {
          actor.Top += randGen.Next(1, 40);
          if (((PictureBox)actor).Top > mainForm.Height)
          {
            mainForm.Controls.Remove(actor);
          }
        }
        if (actor is PictureBox && actor.Tag == "rareStar" || actor is PictureBox && actor.Tag == "redStar")
        {
          actor.Top += randGen.Next(20, 60);
          if (((PictureBox)actor).Top > mainForm.Height)
          {
            mainForm.Controls.Remove(actor);
          }
        }//End rarer star stuff
      }//end foreach
    }//End getgroup
  }//End part class
}//end namespace

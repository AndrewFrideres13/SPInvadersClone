namespace SINDEMO
{
    partial class GForm
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
      this.stateLabel = new System.Windows.Forms.Label();
      this.gameLoop = new System.Windows.Forms.Timer(this.components);
      this.pictureBox11 = new System.Windows.Forms.PictureBox();
      this.pictureBox10 = new System.Windows.Forms.PictureBox();
      this.pictureBox9 = new System.Windows.Forms.PictureBox();
      this.pictureBox8 = new System.Windows.Forms.PictureBox();
      this.pictureBox7 = new System.Windows.Forms.PictureBox();
      this.pictureBox6 = new System.Windows.Forms.PictureBox();
      this.pictureBox5 = new System.Windows.Forms.PictureBox();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.invaders = new System.Windows.Forms.PictureBox();
      this.player = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.invaders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
      this.SuspendLayout();
      // 
      // stateLabel
      // 
      this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
      this.stateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.stateLabel.Location = new System.Drawing.Point(-3, -1);
      this.stateLabel.Name = "stateLabel";
      this.stateLabel.Size = new System.Drawing.Size(250, 25);
      this.stateLabel.TabIndex = 0;
      this.stateLabel.Text = "Score: 00";
      // 
      // gameLoop
      // 
      this.gameLoop.Enabled = true;
      this.gameLoop.Interval = 20;
      this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
      // 
      // pictureBox11
      // 
      this.pictureBox11.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox11.Location = new System.Drawing.Point(286, 18);
      this.pictureBox11.Name = "pictureBox11";
      this.pictureBox11.Size = new System.Drawing.Size(50, 50);
      this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox11.TabIndex = 12;
      this.pictureBox11.TabStop = false;
      this.pictureBox11.Tag = "invaders";
      // 
      // pictureBox10
      // 
      this.pictureBox10.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox10.Location = new System.Drawing.Point(454, 18);
      this.pictureBox10.Name = "pictureBox10";
      this.pictureBox10.Size = new System.Drawing.Size(50, 50);
      this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox10.TabIndex = 11;
      this.pictureBox10.TabStop = false;
      this.pictureBox10.Tag = "invaders";
      // 
      // pictureBox9
      // 
      this.pictureBox9.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox9.Location = new System.Drawing.Point(2, 18);
      this.pictureBox9.Name = "pictureBox9";
      this.pictureBox9.Size = new System.Drawing.Size(50, 50);
      this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox9.TabIndex = 10;
      this.pictureBox9.TabStop = false;
      this.pictureBox9.Tag = "invaders";
      // 
      // pictureBox8
      // 
      this.pictureBox8.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox8.Location = new System.Drawing.Point(58, 18);
      this.pictureBox8.Name = "pictureBox8";
      this.pictureBox8.Size = new System.Drawing.Size(50, 50);
      this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox8.TabIndex = 9;
      this.pictureBox8.TabStop = false;
      this.pictureBox8.Tag = "invaders";
      // 
      // pictureBox7
      // 
      this.pictureBox7.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox7.Location = new System.Drawing.Point(114, 18);
      this.pictureBox7.Name = "pictureBox7";
      this.pictureBox7.Size = new System.Drawing.Size(50, 50);
      this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox7.TabIndex = 8;
      this.pictureBox7.TabStop = false;
      this.pictureBox7.Tag = "invaders";
      // 
      // pictureBox6
      // 
      this.pictureBox6.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox6.Location = new System.Drawing.Point(173, 18);
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.Size = new System.Drawing.Size(50, 50);
      this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox6.TabIndex = 7;
      this.pictureBox6.TabStop = false;
      this.pictureBox6.Tag = "invaders";
      // 
      // pictureBox5
      // 
      this.pictureBox5.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox5.Location = new System.Drawing.Point(232, 18);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new System.Drawing.Size(50, 50);
      this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox5.TabIndex = 6;
      this.pictureBox5.TabStop = false;
      this.pictureBox5.Tag = "invaders";
      // 
      // pictureBox4
      // 
      this.pictureBox4.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox4.Location = new System.Drawing.Point(342, 18);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(50, 50);
      this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox4.TabIndex = 5;
      this.pictureBox4.TabStop = false;
      this.pictureBox4.Tag = "invaders";
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox3.Location = new System.Drawing.Point(398, 18);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(50, 50);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox3.TabIndex = 4;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Tag = "invaders";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox2.Location = new System.Drawing.Point(510, 18);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(50, 50);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Tag = "invaders";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::SINDEMO.Properties.Resources.invaders;
      this.pictureBox1.Location = new System.Drawing.Point(566, 18);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(50, 50);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Tag = "invaders";
      // 
      // invaders
      // 
      this.invaders.Image = global::SINDEMO.Properties.Resources.invaders;
      this.invaders.Location = new System.Drawing.Point(622, 18);
      this.invaders.Name = "invaders";
      this.invaders.Size = new System.Drawing.Size(50, 50);
      this.invaders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.invaders.TabIndex = 1;
      this.invaders.TabStop = false;
      this.invaders.Tag = "invaders";
      // 
      // player
      // 
      this.player.Image = global::SINDEMO.Properties.Resources.ship;
      this.player.Location = new System.Drawing.Point(298, 416);
      this.player.Name = "player";
      this.player.Size = new System.Drawing.Size(50, 50);
      this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.player.TabIndex = 20;
      this.player.TabStop = false;
      // 
      // GForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(684, 471);
      this.Controls.Add(this.stateLabel);
      this.Controls.Add(this.pictureBox11);
      this.Controls.Add(this.pictureBox10);
      this.Controls.Add(this.pictureBox9);
      this.Controls.Add(this.pictureBox8);
      this.Controls.Add(this.pictureBox7);
      this.Controls.Add(this.pictureBox6);
      this.Controls.Add(this.pictureBox5);
      this.Controls.Add(this.pictureBox4);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.invaders);
      this.Controls.Add(this.player);
      this.Name = "GForm";
      this.Text = "Space Invaders Clone";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.invaders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox invaders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Timer gameLoop;
    }
}


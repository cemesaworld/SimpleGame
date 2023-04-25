using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame_Cemesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameTimer.Enabled = true;

        }

        bool goLeft, goRight, goJump, hasKey;
        int jumpSpeed = 10;
        int force = 0;
        int score = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 8;

        private void AssetsDirections( string direction)
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string) x.Tag == "Platform" || x is PictureBox && (string) x.Tag == "Coin" || x is PictureBox && (string)x.Tag == "key")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }

                    if (direction == "forward")
                    {
                        x.Left -= backgroundSpeed;
                    }
                }
            }
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void Platform_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Background_Click_1(object sender, EventArgs e)
        {

        }

        private void Platform_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void NameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft == true && Player.Left > 40)
            {
                Player.Left = playerSpeed;
            }
            if (goRight == true && Player.Left + (Player.Width + 60) < this.ClientSize.Width)
            {
                Player.Left = playerSpeed;
            }
            //BACKGROUND MOVEMENT 
            if(goLeft == true && pictureBox1.Left < 0)
            {
                pictureBox1.Left = backgroundSpeed;
                AssetsDirections("back");
            }
            if (goRight == true && pictureBox1.Left > -1409)
                AssetsDirections("forward");
            {
                pictureBox1.Left = backgroundSpeed;
            }

            //Jumping movement
            Player.Top += jumpSpeed;
            if(goJump == true && Player.Top > 0)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Platform")
                {
                    if(Player.Bounds.IntersectsWith(x.Bounds) && goJump == false)
                    {
                        force = 8;
                        Player.Top = x.Top - Player.Height;
                        jumpSpeed = 0;
                    }

                    x.BringToFront();
                }

                if (x is PictureBox && (string)x.Tag == "Coin")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 1;
                        txt_score.Text = "Score: " + score;
                    }
                }
            }
        }

        private void Key_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (goJump == true)
            {
                goJump = false;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && goJump == false)
            {
                goJump = true;
            }
        }

        private void GameisClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

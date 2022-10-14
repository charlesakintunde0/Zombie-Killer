using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombies
{
    public partial class Form1 : Form
    {
        bool moveLeft, moveRight, moveUp, moveDown, gameOver;
        string direction = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int zombieSpeed = 3;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHealth_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else {
                gameOver = true;

            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;


            if (moveLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (moveRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (moveUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }

            if (moveDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
                direction = "left";
                player.Image = Properties.Resources.left;

            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
                direction = "right";
                player.Image = Properties.Resources.right;

            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
                direction = "up";
                player.Image = Properties.Resources.up;

            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
                direction = "down";
                player.Image = Properties.Resources.down;

            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
               
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
                

            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
               

            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;

            }

            if (e.KeyCode == Keys.Space) 
            {
                ShootBullet(direction);
            }
        }

        private void ShootBullet(string direction) 
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }
          
        private void makeZombies() 
        {

        }

        private void RestartGame() 
        {

        }
    }
}

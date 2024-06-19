using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace MafiasLane
{
    public partial class Level1 : Form
    {
        List<PictureBox> wallsList = new List<PictureBox>();
        List<PictureBox> hintsMenList = new List<PictureBox>();

        PictureBox player;
        ProgressBar playerHealth;
        List<PictureBox> playerFires = new List<PictureBox>();

        PictureBox enemyHorizontal;
        Random random = new Random();
        string horizontalEnemyDirection = "Right";
        Random randomFire = new Random();
        List<PictureBox> enemyFires = new List<PictureBox>();
        ProgressBar enemyHealth;

        PictureBox enemyVertical;
        Random random1 = new Random();
        string verticalEnemyDirection = "Up";

        bool verticalEnemyAlive = false;
        bool horizontalEnemyAlive = false;

        public Level1()
        {
            InitializeComponent();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            createPlayer();
            addWallsInList();
            addHintsMen();
            createEnemyHorizontal();
            createEnemyVertical();
        }

        private void addHintsMen()
        {
            hintsMenList.Add(hintman1);
            hintsMenList.Add(hintman2);
        }

        private void addWallsInList()
        {
            wallsList.Add(wall1);
            wallsList.Add(wall2);
            wallsList.Add(wall3);
            wallsList.Add(wall4);
            wallsList.Add(wall5);
            wallsList.Add(wall6);
            wallsList.Add(wall7);
            wallsList.Add(wall8);
            wallsList.Add(wall9);
            wallsList.Add(wall10);
            wallsList.Add(wall11);
            wallsList.Add(wall12);
            wallsList.Add(wall13);
            wallsList.Add(wall14);
            wallsList.Add(wall15);
            wallsList.Add(wall16);
            wallsList.Add(wall17);
            wallsList.Add(wall18);
            wallsList.Add(wall19);
            wallsList.Add(wall20);
            wallsList.Add(wall21);
            wallsList.Add(wall23);
            wallsList.Add(wall22);
            wallsList.Add(wall24);
            wallsList.Add(wall25);
            wallsList.Add(wall26);
            wallsList.Add(wall27);
            wallsList.Add(wall28);
            wallsList.Add(wall29);
            wallsList.Add(wall30);
            wallsList.Add(wall31);
            wallsList.Add(wall32);
            wallsList.Add(wall33);
        }

        private void createPlayer()
        {
            player = new PictureBox();
            playerHealth = new ProgressBar();
            Image img = MafiasLane.Properties.Resources.Icon1;
            player.Image = img;
            player.Width = img.Width;
            player.Height = img.Height;
            player.BackColor = Color.Transparent;
            player.Left = 550;
            player.Top = 450;
            playerHealth.Left =550;
            playerHealth.Top = 450 + player.Height;
            playerHealth.Value = 100;
            playerHealth.Width = 65;
            playerHealth.Height = 12;
            this.Controls.Add(player);
            this.Controls.Add(playerHealth);
        }

        private void createEnemyHorizontal()
        {
            enemyHorizontal = new PictureBox();
            enemyHealth = new ProgressBar();
            Image img = MafiasLane.Properties.Resources.Icon27;
            enemyHorizontal.Image = img;
            enemyHorizontal.Width = img.Width;
            enemyHorizontal.Height = img.Height;
            enemyHorizontal.BackColor = Color.Transparent;
            enemyHorizontal.Left = random.Next(0, this.Width - img.Width);
            enemyHorizontal.Top = 45;
            enemyHealth.Left = enemyHorizontal.Left;
            enemyHealth.Top = 45 + enemyHorizontal.Height;
            enemyHealth.Value = 100;
            enemyHealth.Width = 65;
            enemyHealth.Height = 12;
            this.Controls.Add(enemyHorizontal);
            this.Controls.Add(enemyHealth);
        }

        private void createEnemyVertical()
        {
            enemyVertical = new PictureBox();
            Image img = MafiasLane.Properties.Resources.Icon45;
            enemyVertical.Image = img;
            enemyVertical.Width = img.Width;
            enemyVertical.Height = img.Height;
            enemyVertical.BackColor = Color.Transparent;
            enemyVertical.Left = 950;
            enemyVertical.Top = this.Height / 2;
            this.Controls.Add(enemyVertical);
        }

        private void GameTImer_Tick(object sender, EventArgs e)
        {
            //Players movements 
            if(Keyboard.IsKeyPressed(Key.RightArrow))
            {
                bool flag = false;
                foreach(PictureBox p in wallsList)
                {
                    if(player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds)  || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds))
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    player.Left = player.Left  - 20;
                    playerHealth.Left = player.Left;
                }
                else if (flag == false)
                {
                    player.Left = player.Left + 10;
                    playerHealth.Left = player.Left;
                }
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                bool flag = false;
                foreach (PictureBox p in wallsList)
                {
                    if (player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds)  || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds))
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    player.Left = player.Left + 20;
                    playerHealth.Left = player.Left;
                }
                else if (flag == false)
                {
                    player.Left = player.Left - 10;
                    playerHealth.Left = player.Left;
                }
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                bool flag = false;
                foreach (PictureBox p in wallsList)
                {
                    if (player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds)  || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds))
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    player.Top = player.Top + 20;
                    playerHealth.Top = player.Top + player.Height;
                }
                else if (flag == false)
                {
                    player.Top = player.Top - 10;
                    playerHealth.Top = player.Top + player.Height;
                }
                
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                bool flag = false;
                foreach (PictureBox p in wallsList)
                {
                    if (player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds)  || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds))
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    player.Top = player.Top - 20;
                    playerHealth.Top = player.Top + player.Height;
                }
                else if (flag == false)
                {
                    player.Top = player.Top + 10;
                    playerHealth.Top = player.Top + player.Height;
                }
            }

            // Horizontal enemys movements 
            if(horizontalEnemyDirection == "Right")
            {
                enemyHorizontal.Left = enemyHorizontal.Left + 5;
                enemyHealth.Left = enemyHorizontal.Left;
            }
            if (enemyHorizontal.Left + enemyHorizontal.Width >= this.Width)
            {
                horizontalEnemyDirection ="Left";
            }
            if (horizontalEnemyDirection == "Left")
            {
                enemyHorizontal.Left = enemyHorizontal.Left - 5;
                enemyHealth.Left = enemyHorizontal.Left;
            }
            if (enemyHorizontal.Left <= 0)
            {
                horizontalEnemyDirection = "Right";
            }

            // Vertical enemys movements 
            if (verticalEnemyDirection == "Up")
            {
                enemyVertical.Top = enemyVertical.Top - 5;
            }
            if (enemyVertical.Top <= 0)
            {
                verticalEnemyDirection = "Down";
            }
            if (verticalEnemyDirection == "Down")
            {
                enemyVertical.Top = enemyVertical.Top + 5;
            }
            if (enemyVertical.Top + enemyVertical.Height >= this.Height)
            {
                verticalEnemyDirection = "Up";
            }

            //Player Fire 
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                PictureBox playerFire = new PictureBox();
                Image img = MafiasLane.Properties.Resources.playerweapon;
                playerFire.Image = img;
                playerFire.Width = img.Width;
                playerFire.Height = img.Height;
                playerFire.BackColor = Color.Transparent;
                System.Drawing.Point fireLocation = new System.Drawing.Point();
                fireLocation.X = player.Left + player.Width;
                fireLocation.Y = player.Top + (player.Height / 2) - 5;
                playerFire.Location = fireLocation;
                playerFires.Add(playerFire);
                this.Controls.Add(playerFire);
            }

            //Moving Player Fires
            foreach(PictureBox p in playerFires)
            {
                p.Left = p.Left + 30;
            }

            //Removing Player fires from List
            for(int x = 0; x < playerFires.Count; x++)
            {
                if (playerFires[x].Left > this.Width)
                {
                    playerFires.Remove(playerFires[x]);
                }
            }

            //Horizontal Enemy Fire 
            int num = randomFire.Next(1, 100);
            if (num % 25 == 0)
            {
                PictureBox enemyFire = new PictureBox();
                Image img = MafiasLane.Properties.Resources.greenweapon;
                enemyFire.Image = img;
                enemyFire.Width = img.Width;
                enemyFire.Height = img.Height;
                enemyFire.BackColor = Color.Transparent;
                System.Drawing.Point fireLocation = new System.Drawing.Point();
                fireLocation.X = enemyHorizontal.Left + (enemyHorizontal.Width / 2) - 5;
                fireLocation.Y = enemyHorizontal.Top + (enemyHorizontal.Height / 2);
                enemyFire.Location = fireLocation;
                enemyFires.Add(enemyFire);
                this.Controls.Add(enemyFire);
            }

            //Moving Enemy Fires
            foreach (PictureBox p in enemyFires)
            {
                p.Top = p.Top + 20;
            }

            //Removing Enemy fires from List
            for (int x = 0; x < enemyFires.Count; x++)
            {
                if (enemyFires[x].Top > this.Height)
                {
                    enemyFires.Remove(enemyFires[x]);
                }
            }

            //Colisions
            if (player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds))
            {
                if (playerHealth.Value < 100)
                {
                    playerHealth.Value = playerHealth.Value + 10;
                }
            }
            for (int x = 0; x < enemyFires.Count; x++)
            {
                if (enemyFires[x].Bounds.IntersectsWith(player.Bounds))
                {
                    enemyFires[x].Hide();
                    enemyFires.Remove(enemyFires[x]);
                    calculatePlayerHealth();
                }
            }
            for (int x = 0; x < playerFires.Count; x++)
            {
                if (playerFires[x].Bounds.IntersectsWith(enemyVertical.Bounds))
                {
                    playerFires[x].Hide();
                    playerFires.Remove(playerFires[x]);

                    this.Controls.Remove(enemyVertical);
                    this.Controls.Remove(enemyHealth);
                    verticalEnemyAlive = true;
                    calculteScore();
                }
            }
            
            for (int x = 0; x < playerFires.Count; x++)
            {
                if (playerFires[x].Bounds.IntersectsWith(enemyHorizontal.Bounds) )
                {
                    playerFires[x].Hide();
                    playerFires.Remove(playerFires[x]);
                    calculateEnemyHealth();
                    calculteScore();
                }
            }
            if (horizontalEnemyAlive == true)
            {
                for (int x = 0; x < enemyFires.Count; x++)
                {
                    enemyFires[x].Hide();
                }
            }

            //Level 1 won
            if (verticalEnemyAlive == true && horizontalEnemyAlive == true)
            {
                this.Close();
                NextLevelForm form = new NextLevelForm();
                form.Show();
            }

            //Level 1 Lost
            if (lblHealthNo.Text == "0")
            {
                this.Close();
                ResumeLevel1Form form = new ResumeLevel1Form();
                form.Show();
            }

        }

        private void calculatePlayerHealth()
        {
            if (lblHealthNo.Text == "1")
            {
                if (playerHealth.Value > 0)
                {
                    playerHealth.Value = playerHealth.Value - 20;
                }
                if (playerHealth.Value == 0)
                {
                    lblHealthNo.Text = "0";
                    this.Controls.Remove(player);
                    this.Controls.Remove(playerHealth);
                    //gameover form
                }
            }
            else if (lblHealthNo.Text == "2")
            {
                if (playerHealth.Value > 0)
                {
                    playerHealth.Value = playerHealth.Value - 20;
                }
                if (playerHealth.Value == 0)
                {
                    playerHealth.Value = 100;
                    lblHealthNo.Text = "1";
                }
            }
        }

        private void calculateEnemyHealth()
        {
            if(enemyHealth.Value > 0)
            {
                enemyHealth.Value = enemyHealth.Value - 10;
            }
            if(enemyHealth.Value == 0)
            {
                enemyHorizontal.Hide();
                enemyHealth.Hide();
                this.Controls.Remove(enemyHorizontal);
                horizontalEnemyAlive = true;
            }
        }

        private void calculteScore()
        {
            int score = int.Parse(lblScoreNo.Text);
            score = score + 50;
            lblScoreNo.Text = score.ToString();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

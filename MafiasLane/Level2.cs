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
    public partial class Level2 : Form
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

        PictureBox enemyVerticalFiring;
        Random random2 = new Random();
        string verticalFiringEnemyDirection = "Up";
        Random randomVerticalFire = new Random();
        List<PictureBox> enemyVerticalFires = new List<PictureBox>();
        ProgressBar enemyVerticalHealth;

        bool verticalEnemyAlive = false;
        bool horizontalEnemyAlive = false;
        bool vertcialFiringEnemyALive = false;


        public Level2()
        {
            InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            createPlayer();
            addWallsInList();
            addHintsMen();
            createEnemyHorizontal();
            createEnemyVertical();
            createEnemyVerticalFiring();
        }

        private void addHintsMen()
        {
            hintsMenList.Add(hintman1);
            hintsMenList.Add(hintman2);
            hintsMenList.Add(hintman3);
        }

        private void addWallsInList()
        {
            wallsList.Add(wall1);
            wallsList.Add(wall2);
            wallsList.Add(wall3);
            wallsList.Add(wall4);
            wallsList.Add(wall5);
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
            wallsList.Add(wall34);
            wallsList.Add(wall35);
            wallsList.Add(wall36);
            wallsList.Add(wall37);
            wallsList.Add(wall38);
            wallsList.Add(wall39);
            wallsList.Add(wall40);
            wallsList.Add(wall41);
            wallsList.Add(wall42);
            wallsList.Add(wall43);
            wallsList.Add(wall44);
            wallsList.Add(wall45);
            wallsList.Add(wall46);
            wallsList.Add(wall47);
            wallsList.Add(wall48);
            wallsList.Add(wall49);
            wallsList.Add(wall50);
            wallsList.Add(wall51);
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
            playerHealth.Left = 550;
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
            Image img = MafiasLane.Properties.Resources.Icon23;
            enemyHorizontal.Image = img;
            enemyHorizontal.Width = img.Width;
            enemyHorizontal.Height = img.Height;
            enemyHorizontal.BackColor = Color.Transparent;
            enemyHorizontal.Left = random.Next(0, this.Width - img.Width);
            enemyHorizontal.Top = 200;
            enemyHealth.Left = enemyHorizontal.Left;
            enemyHealth.Top = enemyHorizontal.Top + enemyHorizontal.Height;
            enemyHealth.Value = 100;
            enemyHealth.Width = 65;
            enemyHealth.Height = 12;
            this.Controls.Add(enemyHorizontal);
            this.Controls.Add(enemyHealth);
        }

        private void createEnemyVertical()
        {
            enemyVertical = new PictureBox();
            Image img = MafiasLane.Properties.Resources.Icon29;
            enemyVertical.Image = img;
            enemyVertical.Width = img.Width;
            enemyVertical.Height = img.Height;
            enemyVertical.BackColor = Color.Transparent;
            enemyVertical.Left = 1000;
            enemyVertical.Top = this.Height / 2;
            this.Controls.Add(enemyVertical);
        }

        private void createEnemyVerticalFiring()
        {
            enemyVerticalFiring = new PictureBox();
            enemyVerticalHealth = new ProgressBar();
            Image img = MafiasLane.Properties.Resources.Icon33;
            enemyVerticalFiring.Image = img;
            enemyVerticalFiring.Width = img.Width;
            enemyVerticalFiring.Height = img.Height;
            enemyVerticalFiring.BackColor = Color.Transparent;
            enemyVerticalFiring.Left = 150;
            enemyVerticalFiring.Top = 0;
            enemyVerticalHealth.Left = enemyVerticalFiring.Left;
            enemyVerticalHealth.Top = enemyVerticalFiring.Top + enemyVerticalFiring.Height;
            enemyVerticalHealth.Value = 100;
            enemyVerticalHealth.Width = 65;
            enemyVerticalHealth.Height = 12;
            this.Controls.Add(enemyVerticalFiring);
            this.Controls.Add(enemyVerticalHealth);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                bool flag = false;
                foreach (PictureBox p in wallsList)
                {
                    if (player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds) || player.Bounds.IntersectsWith(mineral3.Bounds) || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds) || player.Bounds.IntersectsWith(book1.Bounds) || player.Bounds.IntersectsWith(hintman3.Bounds))
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    player.Left = player.Left - 20;
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
                    if (player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds) || player.Bounds.IntersectsWith(mineral3.Bounds) || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds) || player.Bounds.IntersectsWith(book1.Bounds) || player.Bounds.IntersectsWith(hintman3.Bounds))
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
                    if (player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds) || player.Bounds.IntersectsWith(mineral3.Bounds) || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds) || player.Bounds.IntersectsWith(book1.Bounds) || player.Bounds.IntersectsWith(hintman3.Bounds))
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
                    if (player.Bounds.IntersectsWith(p.Bounds) || player.Bounds.IntersectsWith(mineral1.Bounds) || player.Bounds.IntersectsWith(mineral2.Bounds) || player.Bounds.IntersectsWith(mineral3.Bounds) || player.Bounds.IntersectsWith(hintman1.Bounds) || player.Bounds.IntersectsWith(hintman2.Bounds) || player.Bounds.IntersectsWith(book1.Bounds) || player.Bounds.IntersectsWith(hintman3.Bounds))
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
            if (player.Bounds.IntersectsWith(hintman1.Bounds))
            {
                MessageBox.Show("HINT 1 : First think of a person who lives in diguise" +
                    "Who deals in secrets and tells naught lies.");
            }
            if (player.Bounds.IntersectsWith(hintman2.Bounds))
            {
                MessageBox.Show("HINT 2 : Next, tell me whats always the last thing to mend," +
                    "The middle of middle and the end of end.");
            }
            if (player.Bounds.IntersectsWith(hintman3.Bounds))
            {
                MessageBox.Show("HINT 3 : And finally give me the sound often heard." +
                    "During the search for a hard-to-find word.");
            }



            //Player Fires 
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                PictureBox playerFire = new PictureBox();
                Image img = MafiasLane.Properties.Resources.playerweapon2;
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
            foreach (PictureBox p in playerFires)
            {
                p.Left = p.Left + 30;
            }

            //Removing Player fires from List
            for (int x = 0; x < playerFires.Count; x++)
            {
                if (playerFires[x].Left > this.Width)
                {
                    playerFires.Remove(playerFires[x]);
                }
            }

            // Horizontal enemys movements 
            if (horizontalEnemyDirection == "Right")
            {
                enemyHorizontal.Left = enemyHorizontal.Left + 5;
                enemyHealth.Left = enemyHorizontal.Left;
            }
            if (enemyHorizontal.Left + enemyHorizontal.Width >= this.Width - 200)
            {
                horizontalEnemyDirection = "Left";
            }
            if (horizontalEnemyDirection == "Left")
            {
                enemyHorizontal.Left = enemyHorizontal.Left - 5;
                enemyHealth.Left = enemyHorizontal.Left;
            }
            if (enemyHorizontal.Left <= 270)
            {
                horizontalEnemyDirection = "Right";
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

            //Horizontal Moving Enemy Fires
            foreach (PictureBox p in enemyFires)
            {
                p.Top = p.Top + 20;
            }

            //horizontal Removing Enemy fires from List
            for (int x = 0; x < enemyFires.Count; x++)
            {
                if (enemyFires[x].Top > this.Height)
                {
                    enemyFires.Remove(enemyFires[x]);
                }
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

            // Vertical Firing Movement
            if (verticalFiringEnemyDirection == "Up")
            {
                enemyVerticalFiring.Top = enemyVerticalFiring.Top - 5;
                enemyVerticalHealth.Top = enemyVerticalFiring.Top + enemyVerticalFiring.Height;
            }
            if (enemyVerticalFiring.Top <= 0)
            {
                verticalFiringEnemyDirection = "Down";
            }
            if (verticalFiringEnemyDirection == "Down")
            {
                enemyVerticalFiring.Top = enemyVerticalFiring.Top + 5;
                enemyVerticalHealth.Top = enemyVerticalFiring.Top + enemyVerticalFiring.Height;
            }
            if (enemyVerticalFiring.Top + enemyVerticalFiring.Height >= 430)
            {
                verticalFiringEnemyDirection = "Up";
            }

            //VerticalFiring Enemy Fires
            int num2 = random2.Next(1, 100);
            if (num2 % 25 == 0)
            {
                PictureBox vertcialEnemyFire = new PictureBox();
                Image img = MafiasLane.Properties.Resources.brownwepaon;
                vertcialEnemyFire.Image = img;
                vertcialEnemyFire.Width = img.Width;
                vertcialEnemyFire.Height = img.Height;
                vertcialEnemyFire.BackColor = Color.Transparent;
                System.Drawing.Point fireLocation = new System.Drawing.Point();
                fireLocation.X = enemyVerticalFiring.Left + enemyVerticalFiring.Width;
                fireLocation.Y = enemyVerticalFiring.Top + (enemyVerticalFiring.Height / 2) - 5;
                vertcialEnemyFire.Location = fireLocation;
                enemyVerticalFires.Add(vertcialEnemyFire);
                this.Controls.Add(vertcialEnemyFire);
            }

            //Moving VerticalFiring Enenmy Fires
            foreach (PictureBox p in enemyVerticalFires)
            {
                p.Left = p.Left + 30;
            }

            //Removing Vertical Firing Enemy fires from List
            for (int x = 0; x < enemyVerticalFires.Count; x++)
            {
                if (enemyVerticalFires[x].Left > this.Width)
                {
                    enemyVerticalFires.Remove(enemyVerticalFires[x]);
                }
            }

            //Colisions
            //if collides with any mineral
            if (player.Bounds.IntersectsWith(mineral1.Bounds) )
            {
                mineral1.Hide();
                if (playerHealth.Value < 100)
                {
                    playerHealth.Value = playerHealth.Value + 20;
                }
            }
            if (player.Bounds.IntersectsWith(mineral2.Bounds))
            {
                mineral2.Hide();
                if (playerHealth.Value < 100)
                {
                    playerHealth.Value = playerHealth.Value + 10;
                }
            }
            if (player.Bounds.IntersectsWith(mineral3.Bounds))
            {
                mineral3.Hide();
                if (playerHealth.Value < 100)
                {
                    playerHealth.Value = playerHealth.Value + 40;
                }
            }

            //if collides with horizontal firing enemy fires
            for (int x = 0; x < enemyFires.Count; x++)
            {
                if (enemyFires[x].Bounds.IntersectsWith(player.Bounds))
                {
                    enemyFires[x].Hide();
                    enemyFires.Remove(enemyFires[x]);
                    calculatePlayerHealth();
                }
            }
            //if collides with the vertical fifirng enemy fires
            for (int x = 0; x < enemyVerticalFires.Count; x++)
            {
                if (enemyVerticalFires[x].Bounds.IntersectsWith(player.Bounds))
                {
                    enemyVerticalFires[x].Hide();
                    enemyFires.Remove(enemyVerticalFires[x]);
                    calculatePlayerHealth();
                }
            }
            //collisons with players fires 
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
                if (playerFires[x].Bounds.IntersectsWith(enemyHorizontal.Bounds))
                {
                    playerFires[x].Hide();
                    playerFires.Remove(playerFires[x]);
                    calculateHorizontalEnemyHealth();
                    calculteScore(); 
                }
            }
            for (int x = 0; x < playerFires.Count; x++)
            {
                if (playerFires[x].Bounds.IntersectsWith(enemyVerticalFiring.Bounds))
                {
                    playerFires[x].Hide();
                    playerFires.Remove(playerFires[x]);
                    calculateVerticalEnemyHealth();
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
            if (vertcialFiringEnemyALive == true)
            {
                for (int x = 0; x < enemyVerticalFires.Count; x++)
                {
                    enemyVerticalFires[x].Hide();
                }
            }

            //if Level 2 won
            if (verticalEnemyAlive == true && horizontalEnemyAlive == true && vertcialFiringEnemyALive == true)
            {
                this.Close();
                GameEndForm form = new GameEndForm();
                form.Show();
            }

            //if Lost
            if (lblHealthNo.Text == "0")
            {
                this.Close();
                ResumeLevel2Form form = new ResumeLevel2Form();
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
            else if (int.Parse(lblHealthNo.Text) > 1)
            {
                if (playerHealth.Value > 0)
                {
                    playerHealth.Value = playerHealth.Value - 20;
                }
                if (playerHealth.Value == 0)
                {
                    playerHealth.Value = 100;
                    lblHealthNo.Text = (int.Parse(lblHealthNo.Text) - 1).ToString();

                }
            }
        }

        private void calculateHorizontalEnemyHealth()
        {
            if (enemyHealth.Value > 0)
            {
                enemyHealth.Value = enemyHealth.Value - 10;
            }
            if (enemyHealth.Value == 0)
            {
                enemyHorizontal.Hide();
                enemyHealth.Hide();
                this.Controls.Remove(enemyHorizontal);
                horizontalEnemyAlive = true;
            }
        }

        private void calculateVerticalEnemyHealth()
        {
            if (enemyVerticalHealth.Value > 0)
            {
                enemyVerticalHealth.Value = enemyVerticalHealth.Value - 10;
            }
            if (enemyVerticalHealth.Value == 0)
            {
                enemyVerticalFiring.Hide();
                enemyVerticalHealth.Hide();
                this.Controls.Remove(enemyVertical);
                vertcialFiringEnemyALive = true;
            }
        }

        private void calculteScore()
        {
            int score = int.Parse(lblScoreNo.Text);
            score = score + 50;
            lblScoreNo.Text = score.ToString();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        
    }
}


namespace MafiasLane
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(696, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAFIAS LANE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartGame.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnStartGame.Location = new System.Drawing.Point(903, 506);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(274, 58);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Bisque;
            this.btnExit.Location = new System.Drawing.Point(903, 689);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(274, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(931, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "2D GAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRules.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRules.Location = new System.Drawing.Point(822, 594);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(445, 58);
            this.btnRules.TabIndex = 6;
            this.btnRules.Text = "RULES OF THE GAME";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MafiasLane.Properties.Resources.postapocalypse42;
            this.ClientSize = new System.Drawing.Size(1695, 819);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRules;
    }
}


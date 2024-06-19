
namespace MafiasLane
{
    partial class ResumeLevel2Form
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResumeLevel2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Bisque;
            this.btnExit.Location = new System.Drawing.Point(914, 577);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(274, 58);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT ";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(921, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 49);
            this.label2.TabIndex = 16;
            this.label2.Text = "YOU LOST!\r\n";
            // 
            // btnResumeLevel2
            // 
            this.btnResumeLevel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResumeLevel2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeLevel2.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnResumeLevel2.Location = new System.Drawing.Point(914, 488);
            this.btnResumeLevel2.Name = "btnResumeLevel2";
            this.btnResumeLevel2.Size = new System.Drawing.Size(274, 58);
            this.btnResumeLevel2.TabIndex = 15;
            this.btnResumeLevel2.Text = "RESUME LEVEL 2";
            this.btnResumeLevel2.UseVisualStyleBackColor = false;
            this.btnResumeLevel2.Click += new System.EventHandler(this.btnResumeLevel2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(707, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 106);
            this.label1.TabIndex = 14;
            this.label1.Text = "MAFIAS LANE";
            // 
            // ResumeLevel2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MafiasLane.Properties.Resources.postapocalypse42;
            this.ClientSize = new System.Drawing.Size(1695, 819);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResumeLevel2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ResumeLevel2Form";
            this.Text = "ResumeLevel2Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResumeLevel2;
        private System.Windows.Forms.Label label1;
    }
}

namespace MafiasLane
{
    partial class ResumeLevel1Form
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
            this.btnResumeLevel1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Bisque;
            this.btnExit.Location = new System.Drawing.Point(879, 668);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(274, 58);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "EXIT ";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(886, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 49);
            this.label2.TabIndex = 12;
            this.label2.Text = "YOU LOST!\r\n";
            // 
            // btnResumeLevel1
            // 
            this.btnResumeLevel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResumeLevel1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeLevel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnResumeLevel1.Location = new System.Drawing.Point(879, 579);
            this.btnResumeLevel1.Name = "btnResumeLevel1";
            this.btnResumeLevel1.Size = new System.Drawing.Size(274, 58);
            this.btnResumeLevel1.TabIndex = 11;
            this.btnResumeLevel1.Text = "RESUME LEVEL 1";
            this.btnResumeLevel1.UseVisualStyleBackColor = false;
            this.btnResumeLevel1.Click += new System.EventHandler(this.btnResumeLevel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(672, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 106);
            this.label1.TabIndex = 10;
            this.label1.Text = "MAFIAS LANE";
            // 
            // ResumeLevel1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MafiasLane.Properties.Resources.postapocalypse42;
            this.ClientSize = new System.Drawing.Size(1695, 819);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResumeLevel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ResumeLevel1Form";
            this.Text = "ResumeLevel1Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResumeLevel1;
        private System.Windows.Forms.Label label1;
    }
}
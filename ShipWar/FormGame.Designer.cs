namespace ShipWar
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pnlSea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblComputerShipsCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerShipsCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSea
            // 
            this.pnlSea.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSea.Location = new System.Drawing.Point(17, 32);
            this.pnlSea.Name = "pnlSea";
            this.pnlSea.Size = new System.Drawing.Size(506, 505);
            this.pnlSea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilgisayar";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.BackColor = System.Drawing.Color.Black;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.White;
            this.lblComputerScore.Location = new System.Drawing.Point(0, 75);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(182, 30);
            this.lblComputerScore.TabIndex = 1;
            this.lblComputerScore.Text = "0";
            this.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblComputerShipsCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblComputerScore);
            this.panel2.Location = new System.Drawing.Point(529, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 199);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gemi sayisi";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Skor";
            // 
            // lblComputerShipsCount
            // 
            this.lblComputerShipsCount.BackColor = System.Drawing.Color.Black;
            this.lblComputerShipsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblComputerShipsCount.ForeColor = System.Drawing.Color.White;
            this.lblComputerShipsCount.Location = new System.Drawing.Point(0, 147);
            this.lblComputerShipsCount.Name = "lblComputerShipsCount";
            this.lblComputerShipsCount.Size = new System.Drawing.Size(183, 30);
            this.lblComputerShipsCount.TabIndex = 1;
            this.lblComputerShipsCount.Text = "0";
            this.lblComputerShipsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblPlayerShipsCount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblPlayerScore);
            this.panel3.Location = new System.Drawing.Point(529, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 199);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gemi sayisi";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Skor";
            // 
            // lblPlayerShipsCount
            // 
            this.lblPlayerShipsCount.BackColor = System.Drawing.Color.Black;
            this.lblPlayerShipsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPlayerShipsCount.ForeColor = System.Drawing.Color.White;
            this.lblPlayerShipsCount.Location = new System.Drawing.Point(0, 147);
            this.lblPlayerShipsCount.Name = "lblPlayerShipsCount";
            this.lblPlayerShipsCount.Size = new System.Drawing.Size(183, 30);
            this.lblPlayerShipsCount.TabIndex = 1;
            this.lblPlayerShipsCount.Text = "0";
            this.lblPlayerShipsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Oyuncu";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.Color.Black;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(0, 75);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(182, 30);
            this.lblPlayerScore.TabIndex = 1;
            this.lblPlayerScore.Text = "0";
            this.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Location = new System.Drawing.Point(17, 549);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(692, 67);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Bu oyunda bilgisayarla oyuncu dusmana karsi savasmakta. Hangisi daha cok gemi vur" +
                "ursa o kazanir. Her Vurusta puan alinir. Tum gemiyi batirdiginizda ekstra puan a" +
                "lirsiniz";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 26);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            this.oyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame});
            this.oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            this.oyunToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.oyunToolStripMenuItem.Text = "Oyun";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuNewGame.Size = new System.Drawing.Size(128, 22);
            this.mnuNewGame.Text = "Yeni";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 632);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSea);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.Text = "GemiSavasi";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblComputerShipsCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerShipsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
    }
}


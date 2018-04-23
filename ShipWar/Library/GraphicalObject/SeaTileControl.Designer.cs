namespace ShipWar.Library.GraphicalObject
{
    partial class SeaTileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCover
            // 
            this.btnCover.BackColor = System.Drawing.Color.Silver;
            this.btnCover.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCover.Location = new System.Drawing.Point(0, 0);
            this.btnCover.Name = "btnCover";
            this.btnCover.Size = new System.Drawing.Size(50, 50);
            this.btnCover.TabIndex = 0;
            this.btnCover.UseVisualStyleBackColor = false;
            this.btnCover.Click += new System.EventHandler(this.btnCover_Click);
            this.btnCover.MouseLeave += new System.EventHandler(this.btnCover_MouseLeave);
            this.btnCover.MouseHover += new System.EventHandler(this.btnCover_MouseHover);
            this.btnCover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCover_MouseMove);
            // 
            // SeaTileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCover);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SeaTileControl";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCover;
    }
}

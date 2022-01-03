
namespace XOGame
{
    partial class WinForm
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
            this.winLabel = new System.Windows.Forms.Label();
            this.winPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.winLabel.Location = new System.Drawing.Point(338, 101);
            this.winLabel.Name = "winLabel";
            this.winLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.winLabel.Size = new System.Drawing.Size(126, 45);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "label1";
            // 
            // winPictureBox
            // 
            this.winPictureBox.Location = new System.Drawing.Point(165, 149);
            this.winPictureBox.Name = "winPictureBox";
            this.winPictureBox.Size = new System.Drawing.Size(461, 275);
            this.winPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winPictureBox.TabIndex = 1;
            this.winPictureBox.TabStop = false;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winPictureBox);
            this.Controls.Add(this.winLabel);
            this.Name = "WinForm";
            this.Text = "XO Game - Adi Rotman And Eilon Klein";
            this.Load += new System.EventHandler(this.WinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.PictureBox winPictureBox;
    }
}
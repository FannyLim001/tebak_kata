
namespace Tebak_Kata
{
    partial class CorrectAns
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
            this.Benar = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Benar
            // 
            this.Benar.AutoSize = true;
            this.Benar.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Benar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.Benar.Location = new System.Drawing.Point(119, 128);
            this.Benar.Name = "Benar";
            this.Benar.Size = new System.Drawing.Size(149, 53);
            this.Benar.TabIndex = 4;
            this.Benar.Text = "Benar";
            // 
            // NextButton
            // 
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Image = global::Tebak_Kata.Properties.Resources.Group_5_1;
            this.NextButton.Location = new System.Drawing.Point(116, 207);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(168, 71);
            this.NextButton.TabIndex = 5;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tebak_Kata.Properties.Resources.check_1;
            this.pictureBox1.Location = new System.Drawing.Point(150, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CorrectAns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(382, 329);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.Benar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "CorrectAns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CorrectAns";
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Benar;
        private System.Windows.Forms.PictureBox NextButton;
    }
}
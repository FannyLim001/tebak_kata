
namespace Tebak_Kata.Hint
{
    partial class hint2
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
            this.JudulLevel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JudulLevel
            // 
            this.JudulLevel.AutoSize = true;
            this.JudulLevel.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.JudulLevel.Location = new System.Drawing.Point(278, 22);
            this.JudulLevel.Name = "JudulLevel";
            this.JudulLevel.Size = new System.Drawing.Size(112, 53);
            this.JudulLevel.TabIndex = 4;
            this.JudulLevel.Text = "Hint";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tebak_Kata.Properties.Resources.majemuk2;
            this.pictureBox1.Location = new System.Drawing.Point(51, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 187);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // hint2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(688, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JudulLevel);
            this.MaximizeBox = false;
            this.Name = "hint2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hint1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JudulLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
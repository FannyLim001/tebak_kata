
namespace Tebak_Kata
{
    partial class GameMode
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
            this.JudulGameMode = new System.Windows.Forms.Label();
            this.ModeSusah = new System.Windows.Forms.PictureBox();
            this.ModeNormal = new System.Windows.Forms.PictureBox();
            this.ModeSantai = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ModeSusah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeSantai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // JudulGameMode
            // 
            this.JudulGameMode.AutoSize = true;
            this.JudulGameMode.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulGameMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.JudulGameMode.Location = new System.Drawing.Point(288, 37);
            this.JudulGameMode.Name = "JudulGameMode";
            this.JudulGameMode.Size = new System.Drawing.Size(268, 53);
            this.JudulGameMode.TabIndex = 1;
            this.JudulGameMode.Text = "Mode Game";
            // 
            // ModeSusah
            // 
            this.ModeSusah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModeSusah.Image = global::Tebak_Kata.Properties.Resources.Group_10;
            this.ModeSusah.Location = new System.Drawing.Point(510, 70);
            this.ModeSusah.Name = "ModeSusah";
            this.ModeSusah.Size = new System.Drawing.Size(254, 321);
            this.ModeSusah.TabIndex = 4;
            this.ModeSusah.TabStop = false;
            // 
            // ModeNormal
            // 
            this.ModeNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModeNormal.Image = global::Tebak_Kata.Properties.Resources.Group_9;
            this.ModeNormal.Location = new System.Drawing.Point(297, 121);
            this.ModeNormal.Name = "ModeNormal";
            this.ModeNormal.Size = new System.Drawing.Size(237, 268);
            this.ModeNormal.TabIndex = 3;
            this.ModeNormal.TabStop = false;
            // 
            // ModeSantai
            // 
            this.ModeSantai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModeSantai.Image = global::Tebak_Kata.Properties.Resources.Group_8;
            this.ModeSantai.Location = new System.Drawing.Point(30, 112);
            this.ModeSantai.Name = "ModeSantai";
            this.ModeSantai.Size = new System.Drawing.Size(231, 277);
            this.ModeSantai.TabIndex = 2;
            this.ModeSantai.TabStop = false;
            this.ModeSantai.Click += new System.EventHandler(this.ModeSantai_Click);
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::Tebak_Kata.Properties.Resources.previous_1;
            this.BackButton.Location = new System.Drawing.Point(40, 26);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 80);
            this.BackButton.TabIndex = 7;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.JudulGameMode);
            this.Controls.Add(this.ModeSusah);
            this.Controls.Add(this.ModeNormal);
            this.Controls.Add(this.ModeSantai);
            this.MaximizeBox = false;
            this.Name = "GameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMode";
            ((System.ComponentModel.ISupportInitialize)(this.ModeSusah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeSantai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JudulGameMode;
        private System.Windows.Forms.PictureBox ModeSantai;
        private System.Windows.Forms.PictureBox ModeNormal;
        private System.Windows.Forms.PictureBox ModeSusah;
        private System.Windows.Forms.PictureBox BackButton;
    }
}

namespace Tebak_Kata
{
    partial class StartMenu
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
            this.Username = new System.Windows.Forms.TextBox();
            this.JudulLevel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.PictureBox();
            this.Judul = new System.Windows.Forms.Label();
            this.GambarMainMenu = new System.Windows.Forms.PictureBox();
            this.Kelompok1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambarMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kelompok1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Font = new System.Drawing.Font("Fredoka One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.Username.Location = new System.Drawing.Point(438, 193);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(240, 36);
            this.Username.TabIndex = 23;
            // 
            // JudulLevel
            // 
            this.JudulLevel.AutoSize = true;
            this.JudulLevel.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.JudulLevel.Location = new System.Drawing.Point(429, 122);
            this.JudulLevel.Name = "JudulLevel";
            this.JudulLevel.Size = new System.Drawing.Size(236, 53);
            this.JudulLevel.TabIndex = 24;
            this.JudulLevel.Text = "Username";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Image = global::Tebak_Kata.Properties.Resources.Group_12;
            this.SubmitButton.Location = new System.Drawing.Point(438, 263);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(250, 60);
            this.SubmitButton.TabIndex = 25;
            this.SubmitButton.TabStop = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.Judul.Location = new System.Drawing.Point(63, 40);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(260, 53);
            this.Judul.TabIndex = 26;
            this.Judul.Text = "Tebak Kata";
            // 
            // GambarMainMenu
            // 
            this.GambarMainMenu.Image = global::Tebak_Kata.Properties.Resources.Computer_login_bro_1;
            this.GambarMainMenu.Location = new System.Drawing.Point(54, 105);
            this.GambarMainMenu.Name = "GambarMainMenu";
            this.GambarMainMenu.Size = new System.Drawing.Size(358, 333);
            this.GambarMainMenu.TabIndex = 27;
            this.GambarMainMenu.TabStop = false;
            // 
            // Kelompok1
            // 
            this.Kelompok1.Image = global::Tebak_Kata.Properties.Resources.Group_1;
            this.Kelompok1.Location = new System.Drawing.Point(0, 387);
            this.Kelompok1.Name = "Kelompok1";
            this.Kelompok1.Size = new System.Drawing.Size(272, 63);
            this.Kelompok1.TabIndex = 28;
            this.Kelompok1.TabStop = false;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kelompok1);
            this.Controls.Add(this.GambarMainMenu);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.JudulLevel);
            this.Controls.Add(this.Username);
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMenu";
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambarMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kelompok1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label JudulLevel;
        private System.Windows.Forms.PictureBox SubmitButton;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.PictureBox GambarMainMenu;
        private System.Windows.Forms.PictureBox Kelompok1;
    }
}
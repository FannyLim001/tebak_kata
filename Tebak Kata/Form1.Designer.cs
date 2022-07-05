
namespace Tebak_Kata
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
            this.Judul = new System.Windows.Forms.Label();
            this.CaraMain = new System.Windows.Forms.PictureBox();
            this.Mainkan = new System.Windows.Forms.PictureBox();
            this.Kelompok1 = new System.Windows.Forms.PictureBox();
            this.GambarMainMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CaraMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainkan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kelompok1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambarMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.Judul.Location = new System.Drawing.Point(462, 102);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(260, 53);
            this.Judul.TabIndex = 0;
            this.Judul.Text = "Tebak Kata";
            // 
            // CaraMain
            // 
            this.CaraMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaraMain.Image = global::Tebak_Kata.Properties.Resources.Group_7;
            this.CaraMain.Location = new System.Drawing.Point(458, 289);
            this.CaraMain.Name = "CaraMain";
            this.CaraMain.Size = new System.Drawing.Size(303, 80);
            this.CaraMain.TabIndex = 4;
            this.CaraMain.TabStop = false;
            this.CaraMain.Click += new System.EventHandler(this.CaraMain_Click);
            // 
            // Mainkan
            // 
            this.Mainkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mainkan.Image = global::Tebak_Kata.Properties.Resources.Group_5;
            this.Mainkan.Location = new System.Drawing.Point(458, 191);
            this.Mainkan.Name = "Mainkan";
            this.Mainkan.Size = new System.Drawing.Size(303, 80);
            this.Mainkan.TabIndex = 3;
            this.Mainkan.TabStop = false;
            this.Mainkan.Click += new System.EventHandler(this.Mainkan_Click);
            // 
            // Kelompok1
            // 
            this.Kelompok1.Image = global::Tebak_Kata.Properties.Resources.Group_1;
            this.Kelompok1.Location = new System.Drawing.Point(-2, 389);
            this.Kelompok1.Name = "Kelompok1";
            this.Kelompok1.Size = new System.Drawing.Size(272, 63);
            this.Kelompok1.TabIndex = 2;
            this.Kelompok1.TabStop = false;
            // 
            // GambarMainMenu
            // 
            this.GambarMainMenu.Image = global::Tebak_Kata.Properties.Resources.Logic_bro_1;
            this.GambarMainMenu.Location = new System.Drawing.Point(49, 36);
            this.GambarMainMenu.Name = "GambarMainMenu";
            this.GambarMainMenu.Size = new System.Drawing.Size(358, 333);
            this.GambarMainMenu.TabIndex = 1;
            this.GambarMainMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(431, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaraMain);
            this.Controls.Add(this.Mainkan);
            this.Controls.Add(this.Kelompok1);
            this.Controls.Add(this.GambarMainMenu);
            this.Controls.Add(this.Judul);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tebak Kata";
            ((System.ComponentModel.ISupportInitialize)(this.CaraMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainkan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kelompok1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambarMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.PictureBox GambarMainMenu;
        private System.Windows.Forms.PictureBox Kelompok1;
        private System.Windows.Forms.PictureBox Mainkan;
        private System.Windows.Forms.PictureBox CaraMain;
        private System.Windows.Forms.Label label1;
    }
}


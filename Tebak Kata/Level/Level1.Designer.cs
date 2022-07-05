
namespace Tebak_Kata.Level
{
    partial class Level1
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
            this.components = new System.ComponentModel.Container();
            this.JudulLevel = new System.Windows.Forms.Label();
            this.Jawaban = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.PictureBox();
            this.GambarKata = new System.Windows.Forms.PictureBox();
            this.HelpButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambarKata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // JudulLevel
            // 
            this.JudulLevel.AutoSize = true;
            this.JudulLevel.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.JudulLevel.Location = new System.Drawing.Point(323, 47);
            this.JudulLevel.Name = "JudulLevel";
            this.JudulLevel.Size = new System.Drawing.Size(166, 53);
            this.JudulLevel.TabIndex = 3;
            this.JudulLevel.Text = "Level 1";
            // 
            // Jawaban
            // 
            this.Jawaban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.Jawaban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Jawaban.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jawaban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.Jawaban.Location = new System.Drawing.Point(254, 306);
            this.Jawaban.Multiline = true;
            this.Jawaban.Name = "Jawaban";
            this.Jawaban.Size = new System.Drawing.Size(295, 36);
            this.Jawaban.TabIndex = 22;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Image = global::Tebak_Kata.Properties.Resources.Group_12;
            this.SubmitButton.Location = new System.Drawing.Point(290, 362);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(250, 60);
            this.SubmitButton.TabIndex = 23;
            this.SubmitButton.TabStop = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // GambarKata
            // 
            this.GambarKata.Image = global::Tebak_Kata.Properties.Resources.Group_26;
            this.GambarKata.Location = new System.Drawing.Point(144, 133);
            this.GambarKata.Name = "GambarKata";
            this.GambarKata.Size = new System.Drawing.Size(567, 157);
            this.GambarKata.TabIndex = 21;
            this.GambarKata.TabStop = false;
            // 
            // HelpButton
            // 
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.Image = global::Tebak_Kata.Properties.Resources.help_web_button_1;
            this.HelpButton.Location = new System.Drawing.Point(653, 47);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(85, 80);
            this.HelpButton.TabIndex = 20;
            this.HelpButton.TabStop = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::Tebak_Kata.Properties.Resources.previous_1;
            this.BackButton.Location = new System.Drawing.Point(63, 47);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 80);
            this.BackButton.TabIndex = 19;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Fredoka One", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.Timer.Location = new System.Drawing.Point(154, 47);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(132, 53);
            this.Timer.TabIndex = 24;
            this.Timer.Text = "01:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Jawaban);
            this.Controls.Add(this.GambarKata);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.JudulLevel);
            this.MaximizeBox = false;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1";
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GambarKata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JudulLevel;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox HelpButton;
        private System.Windows.Forms.PictureBox GambarKata;
        private System.Windows.Forms.TextBox Jawaban;
        private System.Windows.Forms.PictureBox SubmitButton;
        private System.Windows.Forms.Label Timer;
        public static System.Windows.Forms.Timer timer1;
    }
}
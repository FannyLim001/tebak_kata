using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Tebak_Kata
{
    public partial class StartMenu : Form
    {
        Thread th;
        public static string nama;
        public StartMenu()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\fanny\OneDrive\Documents\Fanny_TID\Matkul\Semester 4\BAD\Project\Tebak Kata\Tebak Kata\Tebak Kata\Resources\Apoxode_-_jamming_ft._Admiral_Bob_1.wav");
            simpleSound.PlayLooping();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            nama = Username.Text;
            if (nama == "")
            {
                MessageBox.Show("Inputkan Username Kamu Terlebih Dahulu");
            } else
            {
                this.Close();
                th = new Thread(OpenForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void OpenForm(object obj)
        {
            Application.Run(new Form1(nama));
        }
    }
}

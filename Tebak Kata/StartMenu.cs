using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

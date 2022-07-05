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
    public partial class Form1 : Form
    {
        Thread th;
        public Form1(string nama)
        {
            InitializeComponent();
            string username = nama;
            Judul.Text = username.ToString();
        }

        private void Mainkan_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenForm(object obj)
        {
            Application.Run(new GameMode());
        }

        private void CaraMain_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenForm2(object obj)
        {
            Application.Run(new CaraMain());
        }
    }
}

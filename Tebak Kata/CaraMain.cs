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
    public partial class CaraMain : Form
    {
        Thread th;
        public CaraMain()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenForm(object obj)
        {
            Application.Run(new Form1(StartMenu.nama));
        }
    }
}

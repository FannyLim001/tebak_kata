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
    public partial class SantaiMode : Form
    {
        Thread th;
        public SantaiMode()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(BackForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BackForm(object obj)
        {
            Application.Run(new GameMode());
        }

        private void Level1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Level);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Level(object obj)
        {
            Application.Run(new Level.Level1());
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Level_2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Level_2(object obj)
        {
            Application.Run(new Level.Level2());
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Level_3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Level_3(object obj)
        {
            Application.Run(new Level.Level3());
        }
    }
}

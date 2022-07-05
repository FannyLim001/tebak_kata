﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tebak_Kata.Level;

namespace Tebak_Kata
{
    public partial class CorrectAns : Form
    {
        Thread th;
        public CorrectAns()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Level1 obj = (Level1)Application.OpenForms["Level1"];
            obj.Close();
            this.Close();
            th = new Thread(Level);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Level(object obj)
        {
            Application.Run(new Level.Level2());
        }
    }
}

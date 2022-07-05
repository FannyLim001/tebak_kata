using System;
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
    public partial class IncorrectAns2 : Form
    {
        Thread th;
        public IncorrectAns2()
        {
            InitializeComponent();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Level2.timeleft = TimeSpan.FromMinutes(1);
            Level2.timer1.Start();

        }
    }
}

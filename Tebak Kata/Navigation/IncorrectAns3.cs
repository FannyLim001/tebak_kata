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
    public partial class IncorrectAns3 : Form
    {
        Thread th;
        public IncorrectAns3()
        {
            InitializeComponent();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Level3.timeleft = TimeSpan.FromMinutes(1);
            Level3.timer1.Start();
        }
    }
}

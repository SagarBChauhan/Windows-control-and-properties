using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical3
{
    public partial class Random : Form
    {
        public Random()
        {
            InitializeComponent();
        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            
          //  Random rnd = new Random();
            System.Random ran = new System.Random();
          //  LblNum1.Text=rnd.GetNextControl();
            
            LblNum1.Text = ran.Next(10).ToString();
            LblNum2.Text = ran.Next(10).ToString();
            LblNum3.Text = ran.Next(10).ToString();
        }
    }
}

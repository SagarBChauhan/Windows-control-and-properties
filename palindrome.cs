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
    public partial class palindrome : Form
    {
        public palindrome()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string value,rev="";
            value = TxtValue.Text;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                rev += value[i].ToString();
            }
            if (rev == value)
            {
                LblDisplay.Text = value.ToString()+"="+rev.ToString();
                MessageBox.Show("String::" + rev + "\nis palindrome");
            }
            else
            {
                LblDisplay.Text = value.ToString() + "!=" + rev.ToString();
                MessageBox.Show("String::" + rev + "\n is not palindrome");  
            }
        }
    }
}

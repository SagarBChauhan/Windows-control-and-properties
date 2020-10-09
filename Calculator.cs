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
    public partial class FormCalculator : Form
    {
        float answer, value1, value2=0;
        string oprator=null;
        public FormCalculator()
        {

            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            GroupPhysical.Show();
            GroupVirtualCal.Hide();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += 0;
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (oprator != null)
            {
                TxtDisplay.Text += 1;
                LblVal2.Text += "1";
            }
            else
            {
                TxtDisplay.Text += 1;
                LblVal1.Text += "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (oprator != null)
            {
                TxtDisplay.Text += 2;
                LblVal2.Text += "2";
            }
            else
            {
                TxtDisplay.Text += 2;
                LblVal1.Text += "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += 4;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text +=6;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text +=8;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text +=9;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text +=7;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TxtDisplay.Text);
           // TxtDisplay.Clear();
            TxtDisplay.Text += "+";
            oprator = "+";
          //  TxtDisplay.Clear();
            answer = (answer + value1)+value2;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += " - ";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += " x ";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += " ÷ ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
        //    TxtDisplay.Text += " = ";
            if (oprator == "+")
            {
                answer = Convert.ToInt32(LblVal1.Text) + Convert.ToInt32(LblVal2.Text);
            //   LblAnsDis.Text = Convert.ToString(value1) + Convert.ToString(oprator) + Convert.ToString(value2) + " = " + Convert.ToString(answer);
                LblAnsDis.Text = LblVal1.Text+" + "+LblVal2.Text+" = "+answer.ToString();
            }
            else if(oprator == "-")
            {
                answer = Convert.ToInt32(LblVal1.Text) - Convert.ToInt32(LblVal2.Text);
                LblAnsDis.Text = LblVal1.Text+" - "+LblVal2.Text+" = "+answer.ToString();
            }
            else if(oprator == "/")
            {
                answer = Convert.ToInt32(LblVal1.Text) / Convert.ToInt32(LblVal2.Text);
                LblAnsDis.Text = LblVal1.Text+"  "+LblVal2.Text+" = "+answer.ToString();
            }
           // LblAnsDis.Text = Convert.ToString(answer);

        }

        private void BtnComa_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += ".";
        }

  /*     private void BtnBack_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = " ";
        }
*/
        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay.ResetText();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {

        }
 
        private void BtnPer_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = " % ";
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = " √ ";
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn1byx_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlusMin_Click(object sender, EventArgs e)
        {

        }

        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioMorden_CheckedChanged(object sender, EventArgs e)
        {     
            GroupPhysical.Show(); 
            GroupVirtualCal.Hide();
        }

        private void RadioVirtual_CheckedChanged(object sender, EventArgs e)
        {
            
            GroupVirtualCal.Show();
            GroupPhysical.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt32(Txtvalue1.Text);
            int val2 = Convert.ToInt32(TxtValue2.Text);
            if(RadioAdd.Checked)
            {
                answer = val1 + val2;
            }
            else if(RadioSub.Checked)
            {
                answer = val1 - val2;
            }
            else if(RadioMul.Checked)
            {
                answer = val1 * val2;
            }
            else if(RadioDiv.Checked)
            {
                answer = val1 / val2;
            }
            LblDisAnsPhy.Text = Convert.ToString(answer);
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void n_click(object sender, EventArgs e)
        {
            if ((resultTextbox.Text == "0") || (isOperationPerformed == true))
                resultTextbox.Clear();
            
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!resultTextbox.Text.Contains("."))
                {
                    resultTextbox.Text = resultTextbox.Text + button.Text;
                }
            }
            else
            {
                resultTextbox.Text = resultTextbox.Text + button.Text;
            }
            
        }
    
        private void ArithmeticOperation_click(object sender, EventArgs e)
        {
            Button button= (Button)sender;

            if (resultValue != 0)
            {
                equalButton.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperaton.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(resultTextbox.Text);
                labelCurrentOperaton.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            resultTextbox.Text = "0";

        }

        private void C_Click(object sender, EventArgs e)
        {
            resultTextbox.Text = "0";
            labelCurrentOperaton.Text = "";
            resultValue = 0;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    resultTextbox.Text = (resultValue + double.Parse(resultTextbox.Text)).ToString();
                    break;
                case "-":
                    resultTextbox.Text = (resultValue - double.Parse(resultTextbox.Text)).ToString();
                    break;
                case "*":
                    resultTextbox.Text = (resultValue * double.Parse(resultTextbox.Text)).ToString();
                    break;
                case "/":
                    resultTextbox.Text = (resultValue / double.Parse(resultTextbox.Text)).ToString();
                    break;
                default:
                    break;

            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = int.Parse(resultTextbox.Text);
            num = num / 10;
            resultTextbox.Text = num.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int textboxNum = int.Parse(resultTextbox.Text);
            if (textboxNum >0) {
                int positiveNumber = System.Math.Abs(textboxNum) * (-1);
                resultTextbox.Text = positiveNumber.ToString();
            }
            if (textboxNum < 0)
            {
                int positiveNumber = System.Math.Abs(textboxNum) * (-1);
                resultTextbox.Text = positiveNumber.ToString();
            }

        }
    }
}

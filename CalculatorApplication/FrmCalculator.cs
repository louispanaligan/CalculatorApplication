using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private CalculatorClass cal;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            {
                double num1 = Convert.ToDouble(txtBoxInput1.Text);
                double num2 = Convert.ToDouble(txtBoxInput2.Text);

                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        cal.CalculateEvent += new Information<double>(cal.GetSum);
                        lblDisplayTotal.Text = cal.info(num1, num2).ToString();
                        cal.CalculateEvent -= new Information<double>(cal.GetSum);
                        break;

                    case "-":
                        cal.CalculateEvent += new Information<double>(cal.GetDifference);
                        lblDisplayTotal.Text = cal.info(num1, num2).ToString();
                        cal.CalculateEvent -= new Information<double>(cal.GetDifference);
                        break;

                    case "*":
                        cal.CalculateEvent += new Information<double>(cal.GetProduct);
                        lblDisplayTotal.Text = cal.info(num1, num2).ToString();
                        cal.CalculateEvent -= new Information<double>(cal.GetProduct);
                        break;

                    case "/":
                        if (num2 != 0)
                        {
                            cal.CalculateEvent += new Information<double>(cal.GetQuotient);
                            lblDisplayTotal.Text = cal.info(num1, num2).ToString();
                            cal.CalculateEvent -= new Information<double>(cal.GetQuotient);
                        }
                        else
                        {
                            lblDisplayTotal.Text = "Cannot divide by zero!";
                        }
                        break;

                    default:
                        lblDisplayTotal.Text = "Select an operator!";
                        break;
                }
            }
        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayTotal_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
      
            txtBoxInput1.Clear();
            txtBoxInput2.Clear();
            lblDisplayTotal.Text = string.Empty; 
            cbOperator.SelectedIndex = -1;
        }
    }
}

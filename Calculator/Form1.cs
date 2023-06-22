using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        Double Result = 0;
        String Operation = "";
        bool OperationPause;
        public Calculator()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalculationTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if((CalculationTxt.Text=="0") || (OperationPause ==true))
            {
                CalculationTxt.Clear();
            }
            OperationPause = false;
            Button button=(Button)sender;
            if(button.Text==".")
            {
                if (!CalculationTxt.Text.Contains("."))
                {
                    CalculationTxt.Text = CalculationTxt.Text + button.Text;
                }
            }
                else
                {
                    CalculationTxt.Text = CalculationTxt.Text + button.Text;
                }
           // CalculationTxt.Text = CalculationTxt.Text + button.Text;
            History.Text = Result + " " + Operation;
        }


        private void OperatorClick(object sender, EventArgs e)
        {
           
            Button button = (Button)sender;

            if (!OperationPause == true)
            {
                if (Result != 0)
                {
                    EqualBtn.PerformClick();

                    Operation = button.Text;
                    //   Result = double.Parse(CalculationTxt.Text);
                    History.Text = Result + " " + Operation;
                    OperationPause = true;
                }
                else

                {

                    Operation = button.Text;
                    Result = double.Parse(CalculationTxt.Text);
                    History.Text = Result + " " + Operation;
                    OperationPause = true;
                }
            }
              else
              {
                    button.Text = button.Text;
                   
                    Operation = button.Text;
                    Result = double.Parse(CalculationTxt.Text);
                    History.Text = Result + " " + Operation;
                    OperationPause = true;
            }      
        }

        private void Equals_Click(object sender, EventArgs e)
        {

            OperationPause = false;
            switch (Operation)
            {
                case "+":
                    {
                        CalculationTxt.Text = (Result + double.Parse(CalculationTxt.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        CalculationTxt.Text = (Result - double.Parse(CalculationTxt.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        CalculationTxt.Text = (Result * double.Parse(CalculationTxt.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        CalculationTxt.Text = (Result / double.Parse(CalculationTxt.Text)).ToString();
                        break;
                    }
                default:
                    break;
            }

            

            Result = Double.Parse(CalculationTxt.Text);
            History.Text = ">";
        }

    

        private void History_Click(object sender, EventArgs e)
        {

        }

        private void ClearAll_Click_1(object sender, EventArgs e)
        {
            OperationPause = false;
            CalculationTxt.Clear();
            Result = Double.Parse("0");
           
            
         
        }

        private void CalculationTxt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

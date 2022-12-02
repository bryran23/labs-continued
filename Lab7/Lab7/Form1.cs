using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {

            {
                if (double.TryParse(futureTxt.Text, out double f))//checks to see if a value is entered
                {
                    if (double.TryParse(annualTxt.Text, out double r))//checks to see if a rate is entered
                    {
                        if (int.TryParse(yearTxt.Text, out int y))//checks  if a number of years has been entered
                        {
                            if (f >= 0 && r >= 0 && r < 1 && y >= 0)//determines if the number entered is positive
                            {
                                double value = PresentValue(f, r, y);//connects the variables to the present value
                                outputLbl.Text = $"{value:C}";//outputs the present value
                            }
                            else
                                MessageBox.Show("Enter a valid number");//shows a message if the number is negative
                        }
                        else
                            MessageBox.Show("Enter a valid number for years");//show a message if the years input is invalid
                    }
                    else
                        MessageBox.Show("Enter a valid annual rate");//shows a message if the interest rate is invalid
                }
                else
                    MessageBox.Show("Enter a valid future value");//shows a message if the future value is invalid
                }
                double PresentValue(double future, double rate, int years)//present value
                {
                double denominator;//denominator varible declared
                denominator = Math.Pow(1+rate, years);//solves the denominator
                double present;//variable for the present value
                present = future / denominator;//solves the equation
                return present;//returns the answer

                }
        }
    }
}

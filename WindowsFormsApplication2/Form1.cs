using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        string resultOne = ""; // declares a string variable "resultOne"

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double monInc = Convert.ToDouble(txtMonthlyIncome.Text); // takes the input from the user on the form
                                                                     // "Monthly Income" box and converts it to double
            double monHouExp = Convert.ToDouble(txtMonthlyHousingExpense.Text); // takes the user input from text box
                                                                              //"Monthly housing Income" and converts it
                                                                              // to double
            double grossInc1 = monInc * .28; // declares a new variable that holds the value of 28% of gross income
            double grossInc2 = monInc * .20; // declares a new variable that holds the value of 20% of gross income

            if (monHouExp >= grossInc1) // this "if statement" states if variable monHouInc is true
            {                           // it will assign the string "Not affordable" to variable resultOne
                resultOne = "Not Affordable"; 
            }
            else if (monHouExp >= grossInc2 && monHouExp < grossInc1) // this "else if" statement states if variable 
            {                                                  // is true it will assign the string "Affordable" to 
                resultOne = "Affordable";                       // variable resultOne
            }
            else if (monHouExp < grossInc1) // this "else if" statement states that if variable monHouExp is less than
            {                               // variable grossInc1 then it will assing string "Very Affordable" to resultOne
                resultOne = "Very Affordable";
            }

            txtAnswer.Text = resultOne.ToString(); // after above code is executed this code converts text box Ansewer
                                                    // to string type and assings it variable resultOne to display

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // this code states that when Exit button is clicked on form the form will close.
        }

        private void txtMonthlyHousingExpense_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // THE COMMENTS EXPLAIN TO ME WHAT EACH LINE OF CODE DOES SO I CAN REVIEW IT LATER AND STUDY FOR CLASS mis 15
        int numberOfImpacts = 0; // This code assigns the data type "int" to declared variable "numberOfImpacts" 
        double totalAmountOfForce = 0; // declares variable "totalAmountOfForce" and assigns it a data type
        double averageUnitOfForce = 0; // declares variable "averaageUnitOfForce" and assigns it a data type

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double unitOfForce = Convert.ToDouble(txtEnterUnitOfForce.Text); // converts the "txtEnterUnitOfForce" to a deouble
            double adjustedPercent = 0; // declares variable and data type and assings it a value

            if (unitOfForce >= 1000) // if statement, if variable is > 1000 then code below gets executed
            {                        
                adjustedPercent = 0.25;
            }
            else if (unitOfForce >= 500 && unitOfForce < 1000) // "else if" statement
            {
                adjustedPercent = 0.25;
            }
            else if (unitOfForce >= 250 && unitOfForce < 500) // same as above "else if" statement
            {
                adjustedPercent = 0.15;
            }
            else if (unitOfForce >= 50 && unitOfForce < 250)
            {
                adjustedPercent =  0.10;
            }
            else if (unitOfForce >= 0 && unitOfForce < 50)
            {
                adjustedPercent = 0.05;
            }

            double adjustedPercentTotal = Math.Round(unitOfForce * adjustedPercent); // declares the data type and variable that is
            double adjustedValueOfForce = unitOfForce - adjustedPercentTotal; // obtained from "Math.Round" ; the second line
                                                                                // declares the data type and variable and sets it equal to 
            txtUnitOfForce.Text = unitOfForce.ToString() + " lbs"; // code takes "txtUnitOfForce.Text" and converts it back to string & adds " lbs"
            txtAdjustedPercent.Text = adjustedPercent.ToString("p1"); //  this code takes txtAdjustedPercent.Text nd converts it back to string; "p1" assings
            txtAdjustedValueOfForce.Text = adjustedValueOfForce.ToString() +" lbs"; // a % sign at the end for this string.
            txtTotal.Text = adjustedValueOfForce.ToString() + " lbs";

            numberOfImpacts++; // code takes the number of impacts and increments one every time user enters a number
            totalAmountOfForce += adjustedValueOfForce; // this code takes variable "totalAmountOfForce and sets it equal to itself + adjsutedValueOfForce
            averageUnitOfForce = totalAmountOfForce / numberOfImpacts; // this code does math to obtain averageUnitOfForce through use of previous variables

            txtNumberOfImpacts.Text = numberOfImpacts.ToString(); // this code converts "numberOfImpacts" double data type to string and
            txtTotalAmountOfForce.Text = totalAmountOfForce.ToString() + " lbs"; // assigns it to "txtNumberOfImpacts.Text" as just a number
            txtAverageAmountOfForce.Text = averageUnitOfForce.ToString() + " lbs";

            txtEnterUnitOfForce.Text = ""; // this code clears the "enter Unit Of Force" text box after each entry so the
            txtEnterUnitOfForce.Focus(); // user can enter a new number and the ".Focus" code returns the text entry blinker to the "EnterUniOfForce" box
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // this code dictates that when user presses escape or clicks Exit Button the program will close the window.
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            numberOfImpacts = 0; // this code in this section clears all the data on the numberOfImpacts, totalAmountOfForce, and 
            totalAmountOfForce = 0; // averageUnitOfForce variables defined above
            averageUnitOfForce = 0;

            txtNumberOfImpacts.Text = ""; // this code runs when the user presses the Clear Totals Button, it also clears the 
            txtTotalAmountOfForce.Text = ""; // "number Of Impacts", "Total Amount Of Force", and " average amount of force" text boxes
            txtAverageAmountOfForce.Text = "";

            txtEnterUnitOfForce.Focus(); // after doing the above code this code returns the text input line back to the
        }                               // "Enter Unit Of Force" box so the user can restart with a new set of data input.
    }
}

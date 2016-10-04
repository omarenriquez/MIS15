using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // this code closes the program when the button Exit is clicked
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double factorial = Convert.ToDouble(txtNumber.Text); // this code takes the number the user entered and
                                                                 //converts it into a double
            double startingNumber = 1; // this code declares a variable and sets it equal to 1

            while (factorial > 0) // this code activates the "while" code
            {
                startingNumber = factorial * startingNumber; // this code sets the variable startingNumber and * by
                factorial--;                                    // factorial, then the code underneath subtracts 1
            }                                                   // from factorial every time until factorial reaches 0

            txtFactorial.Text = startingNumber.ToString("n0"); // this code takes the result from startingNumber
                                                            // and converts it into text and assigns it back into the 
        }                                                     // textbox Factorial on the Windows Form
    }
}

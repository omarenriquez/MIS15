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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numberOfChange = Convert.ToInt32(txtAmountOfChangeDue.Text);
            int numberOfQuarters = 0;
            int numberOfDimes = 0;
            int numberOfNickels = 0;
            int numberOfPennies = 0;
            int changeFromQuarters = 0;
            int changeFromDimes = 0;
            int changeFromNickels = 0;

            if (numberOfChange > 0) ;
            {
                numberOfQuarters = numberOfChange / 25;
                changeFromQuarters = numberOfChange % 25;
            }

            if (changeFromQuarters > 0) ;
            {
                numberOfDimes = changeFromQuarters / 10;
                changeFromDimes = changeFromQuarters % 10;
            }

            if (changeFromDimes > 0) ;
            {
                numberOfNickels = changeFromDimes / 5;
                changeFromNickels = changeFromDimes % 5;
            }

            if (changeFromNickels > 0) ;
            {
                numberOfPennies = changeFromNickels / 1;
            }

            txtQuarters.Text = numberOfQuarters.ToString();
            txtDimes.Text = numberOfDimes.ToString();
            txtNickels.Text = numberOfNickels.ToString();
            txtPennies.Text = numberOfPennies.ToString();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

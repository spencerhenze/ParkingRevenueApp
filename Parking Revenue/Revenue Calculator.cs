using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Spencer Henze
 ITM 225
 Kit Scott
 9/12/16
 */

namespace Parking_Revenue
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void calculateRevButton_Click(object sender, EventArgs e)
        {
            try // this tries to run this code by default, but if the user enters something that makes this not work, run the catch code below
            {  //Declare all variables we'll need to use. Use decimals for all because we are dealing with money ultimately.
                decimal wPermits, ePermits, sPermits;
                decimal wRevenue, eRevenue, sRevenue, tRevenue;
                //Declare all constant values: Prices
                const decimal wCPrice = 140m;
                const decimal eCPrice = 118m;
                const decimal sCPrice = 118m;

                //When the user enters the number it will be a string. Need to convert it to decimal to use it in calculations. Use the Parse method.
                wPermits = decimal.Parse(westCommuterTextBox.Text);
                ePermits = decimal.Parse(eastCommuterTextBox.Text);
                sPermits = decimal.Parse(southCommuterTextBox.Text);

                // Assign the variables to the math equations that define them.
                wRevenue = wPermits * wCPrice;
                eRevenue = ePermits * eCPrice;
                sRevenue = sPermits * sCPrice;
                tRevenue = wRevenue + eRevenue + sRevenue;

                // To display the numbers in the label boxes, we need to convert them back to the string data type. Ust the ToString method and specify currency formatting by putting ' "C" ' in as a perameter for To.String
                wRevenueLabel.Text = wRevenue.ToString("C");
                eRevenueLabel.Text = eRevenue.ToString("C");
                sRevenueLabel.Text = sRevenue.ToString("C");
                tRevenueLabel.Text = tRevenue.ToString("C");
            }
            catch // Runs this code to show an error box if the user enters an incompatible data.
            {
                MessageBox.Show("Please enter numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //End Click Calculate Revenue Button
     

        private void clearButton_Click(object sender, EventArgs e) // specify what the program should do when the "Clear" button is clicked
        { // set all labels and text fields to empty, denoted by "" 
            westCommuterTextBox.Text = "";
            eastCommuterTextBox.Text = "";
            southCommuterTextBox.Text = ""; 

            wRevenueLabel.Text = "";
            eRevenueLabel.Text = "";
            sRevenueLabel.Text = "";
            tRevenueLabel.Text = "";
        } //End Clear Button Click

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close the program when the Exit button is clicked.
        } // End Exit Button Click
    }
}

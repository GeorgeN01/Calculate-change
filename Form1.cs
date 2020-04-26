using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
            //George Njubi
            //4/26/2020
            //Exercise 5-2 Calculate change
        {
            int AmountChange;
            bool AmountEntered;

            //using tryparse check if amount entered is valid
            AmountEntered = Int32.TryParse(txtAmountChange.Text.Trim(), out AmountChange);
            if (AmountEntered)

                if (AmountChange < 0 || AmountChange > 99)
                {
                    MessageBox.Show("Please enter 0 and 99, Thank you");
                }
                else
                {
                    decimal Quarters;
                    decimal Dimes;
                    decimal Nickels;
                    decimal Pennies;

                    //calculate number of quaters
                    Quarters = AmountChange / 25;
                    //reduce the amount entered by assigning it to the value of AmountChange Mod 25
                    AmountChange = AmountChange % 25;
                    //calculate number of dimes
                    Dimes = AmountChange / 10;
                    //reduce the amount entered by assigning it to the value of AmountChange Mod 10
                    AmountChange = AmountChange % 10;
                    //calculate number of nickels
                    Nickels = AmountChange / 5;
                    //reduce the amount entered by assigning it to the value of AmountChange Mod 5
                    AmountChange = AmountChange % 5;
                    //calculate number of pennies
                    Pennies = AmountChange;

                    //display results
                    txtQuarters.Text = Math.Floor(Quarters).ToString();
                    txtNickles.Text = Math.Floor(Nickels).ToString();
                    txtDimes.Text = Math.Floor(Dimes).ToString();
                    txtPennies.Text = Math.Floor(Pennies).ToString();
                }
        }
    }

}  


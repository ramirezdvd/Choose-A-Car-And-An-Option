using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIControlsAndMultiLine_DavidRamirez_II
    //Author: David Ramirez
    // Purpose of program is to add together the vehicle cost and the optinal features
    // To list the vehicle and options purchased
{
    public partial class Form1 : Form
    {
        // To create the ammounts for the constants for the vehicle options

        const decimal MySunRoof = 1000;
        const decimal MyDVDPlayer = 500;
        const decimal MyGasTank = 100;
        public Form1()
        {
            InitializeComponent();
        }

        
        // Calculate Button

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // To create the total ammount number

            decimal MyLblTotalCost = 0;

            // FinalOrder calculates based on which radio button is selected, || (if, or)
            // calculates based on one or all checkboxes selected


            String FinalOrder = "";
            if (radioButtonChevVolt.Checked || radioButtonFordPinto.Checked)
            {
                if (radioButtonChevVolt.Checked)
                {
                    MyLblTotalCost += 50000;
                    FinalOrder = FinalOrder + "Chevorlet Volt" + "\n";
                }


                else
                {
                    MyLblTotalCost += 1000;
                    FinalOrder = FinalOrder + "Ford Pinto" + "\n";
                }

                if (checkBoxSunRf.Checked)
                {
                    MyLblTotalCost += MySunRoof;
                    FinalOrder = FinalOrder + "Sun Roof" + "\n";
                }
                if (checkBoxDVDPl.Checked)
                { MyLblTotalCost += MyDVDPlayer;
                    FinalOrder = FinalOrder + "DVD Player" + "\n";
                }
                if (checkBoxGasTnk.Checked)
                { MyLblTotalCost += MyGasTank;
                    FinalOrder = FinalOrder + "Non-exploding Gas Tank" + "\n";
                }
            }
            else
            //to show error message if no choice is made
            { MessageBox.Show("Please Select A Vehicle"); }
            
            //To Show the numbers in the text field
            //and to show the list

            LblTotalCost.Text = MyLblTotalCost.ToString("c");
            LblFinalOrder.Text = FinalOrder;
        }

        private void LblTCOC_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            //To clear the text in the text field

            LblTotalCost.Text = " ";
            LblFinalOrder.Text = " ";
            checkBoxGasTnk.Checked = false;
            checkBoxSunRf.Checked = false;
            checkBoxDVDPl.Checked = false;
            radioButtonChevVolt.Checked = false;
            radioButtonFordPinto.Checked = false;
        }

        private void checkBoxDVDPl_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

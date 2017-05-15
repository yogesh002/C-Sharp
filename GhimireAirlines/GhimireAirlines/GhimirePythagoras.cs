using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Yogesh Ghimire
 * 700643983*/
namespace GhimireAirlines
{
    public partial class GhimirePythagoras : Form
    {
        public GhimirePythagoras()
        {
            InitializeComponent();
        }

        //This method closes the form on click of Exit button in the form
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FindThirdSideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double firstSide = double.Parse(FirstSideTextBox.Text); //converting user input first side string to double
                double secondSide = double.Parse(SecondSideTextBox.Text);//converting user input second side string to double.

                double longestSide = 0.0; //initializing the variable
                if (firstSide < 0 || secondSide < 0)
                {
                    errorProvider1.SetError(FirstSideTextBox, "The sides cannot be negative. Please enter again"); //Side cannot be negative
                    errorProvider1.SetError(SecondSideTextBox, "The sides cannot be negative. Please enter again"); //Side cannot be negative
                    MessageBox.Show("The sides cannot be negative");
                }
                else if (firstSide == 0 || secondSide == 0)
                {
                    errorProvider1.SetError(FirstSideTextBox, "Side cannot be zero"); //side cannot be zero
                    MessageBox.Show("Side cannot be zero");
                    //throw new ArgumentException("Side cannot be zero");
                }

                else
                { //Input is correct. So calculating the hypotenuse
                    if (YesRadioBtn.Checked)
                    {
                        if (firstSide == secondSide)
                        {
                            errorProvider1.SetError(FirstSideTextBox, "Two sides cannot be equal. Please try again"); //Side cannot be negative
                            MessageBox.Show("Two sides cannot be equal. Please try again");
                          //  throw new ArgumentException("Two sides cannot be equal");
                        }
                        Pythogoras hypotenuse = new Hypotenuse(firstSide, secondSide);
                        longestSide = hypotenuse.CalculateThirdSide();
                    }

                    else if (NoRadioBtn.Checked)
                    {
                        Pythogoras hypotenuse = new Pythogoras();
                        hypotenuse.FirstSide = firstSide;
                        hypotenuse.SecondSide = secondSide;

                        longestSide = hypotenuse.CalculateThirdSide();
                    }

                    else
                    {
                        throw new ArgumentException("Select atleast one radio button");
                    }

                    ResultTextArea.Text = string.Format("Third side of a right angled triangle with sides {0} and {1} is: {2} ", firstSide, secondSide, longestSide); //Printing result in the textArea

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Two sides cannot be equal. ", ex.Message); //display error message

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Two numbers cannot be same when hypotenuse is already known ", ex.Message, MessageBoxButtons.OK); //display error message
            }
        }

        private void YesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}

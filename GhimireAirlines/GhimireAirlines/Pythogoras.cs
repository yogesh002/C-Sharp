using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Yogesh Ghimire
 * 700643983*/
namespace GhimireAirlines
{
    //This is the implementation class for IPythogoras interface
    class Pythogoras : IPythogoras
    {
        //private fields
        private double firstSideDouble;
        private double secondSideDouble;
        public const int POWER_TO_RAISE = 2;

        //public properties with get and set
        public double FirstSide
        {
            get
            {
                return firstSideDouble;
            }
            set
            {
                firstSideDouble = value;
            }
        }

        public double SecondSide
        {
            get
            {
                return secondSideDouble;
            }
            set
            {
                secondSideDouble = value;

            }

        }

        //Constructor
        public Pythogoras()
        {

        }


        //This method can be overriden by derived classes. 
        //User clicks No scenario in the form
        public virtual double CalculateThirdSide()
        {
            double squaredFirstSide = Math.Pow(firstSideDouble, POWER_TO_RAISE); //Squaring the first side by. The first parameter represents firstside and the second parameter is the power to which to raise. Square means power of 2.
            double squaredSecondSide = Math.Pow(secondSideDouble, POWER_TO_RAISE); //Squaring the second side by. The first parameter represents secondside and the second parameter is the power to which to raise. Square means power of 2.
            double addedTwoSides = squaredFirstSide + squaredSecondSide; //Adding two calculated sides
            return Math.Sqrt(addedTwoSides); // Taking the square root now.
        }


    }
}

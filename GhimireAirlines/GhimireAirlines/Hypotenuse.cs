using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Yogesh Ghimire
 * 700643983*/
namespace GhimireAirlines
{
    //This is the derived class. Base class is Pythagoras
    class Hypotenuse : Pythogoras
    {
        private double firstSideDouble;
        private double secondSideDouble;

        //Parameterized constructors taking two parameters - firstside and secondside
        public Hypotenuse(double firstSide, double secondSide)
            : base()
        {
            this.firstSideDouble = firstSide;
            this.secondSideDouble = secondSide;
        }

        //User says he entered hypotenuse in the form so hypotenuse must be the longest of the two fields he entered
        //Calculates the third side
        public override double CalculateThirdSide()
        {
            double thirdSide = 0.0; //intializing the variable
            double longerSide = 0.0;

            if ((firstSideDouble - secondSideDouble) > 0) //From the two sides user entered, the first side is greater than second side. Thus, first side is hypotenuse
            {
                longerSide = firstSideDouble;

            }
            else if ((firstSideDouble - secondSideDouble) < 0)//From the two sides user entered, the second side is greater than first side. Thus, second side is hypotenuse
            {
                longerSide = secondSideDouble;
            }
            thirdSide = calculateThirdSide(longerSide);
            return thirdSide;
        }

        private double calculateThirdSide(double longerSide)
        {
            double squaredLongerSide = Math.Pow(longerSide, POWER_TO_RAISE); //Squaring the longer side. The first parameter represents longer side/hypotenuse and the second parameter is the power to which to raise. Square means power of 2.
            double squaredOtherSide = Math.Pow(firstSideDouble, POWER_TO_RAISE); //Squaring the first side as second side is hypotenuse. The second parameter represents longer side/hypotenuse and the first parameter is the power to which to raise. Square means power of 2.
            double addedTwoSides = squaredLongerSide + squaredOtherSide; //sides squared and added
            double thirdSide = Math.Sqrt(addedTwoSides); //Taking square root to find the third side
            return thirdSide;
        }
    }
}

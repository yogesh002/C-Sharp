using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yogesh Ghimire
namespace Events
{
    //The same customEventArgs class that the publisher can publish where as consumer can listen to.

    class CustomEventArgs : EventArgs
    {
        public string Car
        {
            get;
            private set;
        }

        public CustomEventArgs(string carString)
        {
            this.Car = carString;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yogesh Ghimire
namespace Events
{
    //Publisher Class
    class Publisher
    {
        //1. Declare an event
        public event EventHandler<CustomEventArgs> NewCarInfoPublishEvent;

        //2. Raise the event - the method declaration is important.
        protected virtual void RaisePublishingEventInfo(string carString)
        {
            EventHandler<CustomEventArgs> publishNewCarInfoEventHelper = NewCarInfoPublishEvent;

            //check if an event is present
            if (publishNewCarInfoEventHelper != null)
            {
                //publish the event by calling the delegate
                publishNewCarInfoEventHelper(this, new CustomEventArgs(carString));
            }
        }

        public void NewCar(string carName)
        {
            Console.WriteLine("Publisher publishing new car: {0}", carName);
            //Calling the above declared method that raises the event
            RaisePublishingEventInfo(carName);
        }
    }
}

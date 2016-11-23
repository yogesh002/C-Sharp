using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yogesh Ghimire
namespace Events
{
    class Subscriber
    {
        private string consumerName;

        public Subscriber(string consumerName)
        {
            this.consumerName = consumerName;
        }

        //Subscriber has same method signature as publisher
        public void ConsumeNewCarInformationFromPublisher(object obj, CustomEventArgs eventArgs)
        {
            Console.WriteLine("Subscriber {0} found this car from publisher: {1}", consumerName, eventArgs.Car);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yogesh Ghimire
namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber subscriberHonda = new Subscriber("HondaSubscriber");
            Subscriber subscriberToyota = new Subscriber("ToyotaSubscriber");
           
            publisher.NewCarInfoPublishEvent += subscriberHonda.ConsumeNewCarInformationFromPublisher;
            publisher.NewCar("Publisher-Honda");
          
            Console.WriteLine("*********************************");
            Console.WriteLine();

            //This subscriber wants to subscribe toyota but not honda
            publisher.NewCarInfoPublishEvent += subscriberToyota.ConsumeNewCarInformationFromPublisher;
            publisher.NewCarInfoPublishEvent -= subscriberHonda.ConsumeNewCarInformationFromPublisher;
            publisher.NewCar("Publisher-Toyota RAV-4");

            Console.ReadKey();
        }
    }
}

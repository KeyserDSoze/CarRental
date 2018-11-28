using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Library.Core;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            //similar Decorator
            ASubscription subcription = new Occasional(new Electric(20, 3));
            Console.WriteLine($"Subscription Rental Eur {subcription.Calculate()}");
            //Factory from Model base for MVC
            ASubscription subscriptionFromFactory = SubscriptionFactory.Create(new Library.Core.Models.Data()
            {
                Car = "Large",
                Subscription = "Frequent",
                Kilometers = 100,
                Hours = 5
            });
            Console.WriteLine($"Subscription Rental from Factory Eur {subscriptionFromFactory.Calculate()}");
            Console.ReadLine();
        }
    }
}

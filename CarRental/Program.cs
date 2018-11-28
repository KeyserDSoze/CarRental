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
            Console.ReadLine();
        }
    }
}

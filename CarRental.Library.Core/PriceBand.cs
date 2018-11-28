using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRental.Library.Core.SubscriptionPrice;

namespace CarRental.Library.Core
{
    internal class SubscriptionPrice
    {
        public string Label { get; set; }
        public List<PriceBand> priceBands { get; set; }
        internal class PriceBand
        {
            public string Label { get; set; }
            public decimal PerHours { get; set; }
            public decimal PerKilometers { get; set; }
        }
    }
    
    public static class Database
    {
        private static List<SubscriptionPrice> subscriptionPrices;
        private static object trafficLight = new object();
        public static (decimal PerHour, decimal PerKilometer) Instance(string car, string subscription)
        {
            //Singleton to call DB only one time, a static configuration need a static flow. Remember this one.
            if (subscriptionPrices == null)
            {
                lock (trafficLight)
                {
                    if (subscriptionPrices == null)
                    {
                        string json = "[{\"Label\":\"Occasional\",\"priceBands\":[{\"Label\":\"Small\",\"PerHours\":6,\"PerKilometers\":0.34},{\"Label\":\"Large\",\"PerHours\":7.50,\"PerKilometers\":0.39},{\"Label\":\"Electric\",\"PerHours\":11,\"PerKilometers\":0.20}]},{\"Label\":\"Regular\",\"priceBands\":[{\"Label\":\"Small\",\"PerHours\":4,\"PerKilometers\":0.29},{\"Label\":\"Large\",\"PerHours\":5.50,\"PerKilometers\":0.34},{\"Label\":\"Electric\",\"PerHours\":9,\"PerKilometers\":0.15}]},{\"Label\":\"Frequent\",\"priceBands\":[{\"Label\":\"Small\",\"PerHours\":3,\"PerKilometers\":0.24},{\"Label\":\"Large\",\"PerHours\":4.50,\"PerKilometers\":0.29},{\"Label\":\"Electric\",\"PerHours\":8,\"PerKilometers\":0.12}]}]";
                        subscriptionPrices = JsonConvert.DeserializeObject<List<SubscriptionPrice>>(json);
                    }
                }
            }
            PriceBand priceBand = subscriptionPrices.Find(ø => ø.Label.Equals(subscription)).priceBands.Find(ƒ => ƒ.Label.Equals(car));
            return (priceBand.PerHours, priceBand.PerKilometers);
        }
    }
}

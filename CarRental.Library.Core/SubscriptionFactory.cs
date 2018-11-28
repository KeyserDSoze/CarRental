using CarRental.Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Library.Core
{
    public static class SubscriptionFactory
    {
        private static string myNameSpace { get { return typeof(SubscriptionFactory).FullName.Replace(typeof(SubscriptionFactory).Name, ""); } }
        public static ASubscription Create(Data data)
        {
            //myNameSpace + data.Car => get the full name of class with its namespace. This factory must be in the same namespace of the ACar and ASubscription
            return Activator.CreateInstance(Type.GetType(myNameSpace + data.Subscription), new object[1] { Activator.CreateInstance(Type.GetType(myNameSpace + data.Car), new object[2] { data.Kilometers, data.Hours }) }) as ASubscription;
        }
    }
}

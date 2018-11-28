using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Library.Core
{
    public abstract class ASubscription
    {
        private protected readonly ACar car;
        public ASubscription(ACar car)
        {
            this.car = car;
        }

        public virtual decimal Calculate()
        {
            (decimal perHours, decimal perKilometers) = SubscriptionPrice.Value(this.car.GetType().Name, this.GetType().Name);
            return (perKilometers * this.car.Kilometers) + (perHours * this.car.Hours);
        }
    }
    public class Occasional : ASubscription
    {
        public Occasional(ACar car) : base(car)
        {
        }
    }
    public class Regular : ASubscription
    {
        public Regular(ACar car) : base(car)
        {
        }
    }
    public class Frequent : ASubscription
    {
        public Frequent(ACar car) : base(car)
        {
        }
    }
}

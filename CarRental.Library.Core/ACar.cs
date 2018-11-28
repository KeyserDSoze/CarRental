using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Library.Core
{
    public abstract class ACar
    {
        public int Kilometers { get; set; }
        public int Hours { get; set; }
        public ACar(int kilometers, int hours)
        {
            this.Kilometers = kilometers;
            this.Hours = hours;
        }
    }

    public class Small : ACar
    {
        public Small(int kilometers, int hours) : base(kilometers, hours)
        {
        }
    }
    public class Large : ACar
    {
        public Large(int kilometers, int hours) : base(kilometers, hours)
        {
        }
    }
    public class Electric : ACar
    {
        public Electric(int kilometers, int hours) : base(kilometers, hours)
        {
        }
    }
}

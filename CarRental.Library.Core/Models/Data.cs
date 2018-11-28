using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Library.Core.Models
{
    //Model base for MVC
    public class Data
    {
        public string Car { get; set; }
        public string Subscription { get; set; }
        public int Kilometers { get; set; }
        public int Hours { get; set; }
    }
}

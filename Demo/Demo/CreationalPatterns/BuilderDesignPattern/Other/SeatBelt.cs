using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.BuilderDesignPattern.Other
{
    public class SeatBelt
    {
        public SeatBelt(string brand)
        {
            Brand = brand;
        }

        public string Brand { get; set; }
    }
}

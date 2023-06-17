using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BehavioralPatterns.StrategyDesignPattern
{
    class NoDisCount : IPromote
    {
        public double DoDisCount(double price)
        {
            return price;
        }
    }
}

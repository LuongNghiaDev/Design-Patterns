using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BehavioralPatterns.StrategyDesignPattern
{
    class Ticket
    {
        private IPromote promote;
        private double price;
        private string name;

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double value)
        {
            price = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public IPromote GetPromote()
        {
            return promote;
        }

        public void SetPromoteStrategy(IPromote value)
        {
            promote = value;
        }

        public Ticket()
        {

        }

        public Ticket(IPromote value)
        {
            promote = value;
        }

        public double GetPromotePrice()
        {
            return promote.DoDisCount(price);
        }
    }
}

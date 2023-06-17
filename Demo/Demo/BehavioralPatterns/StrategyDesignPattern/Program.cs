using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BehavioralPatterns.StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start getting tickets!");

            var random = new Random();

            for (var i = 1; i <= 5; i++)
            {
                var ticket = new Ticket();
                ticket.SetName("Ticket " + i);
                ticket.SetPrice(50d * i);
                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);

                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);
            }
        }

        private static void LogTicketDetails(Ticket ticket)
        {
            Console.WriteLine(
                                "Promoted price of " +
                                ticket.GetName() +
                                " is " +
                                ticket.GetPromotePrice() +
                                " " +
                                ticket.GetPromote().GetType().Name +
                                "\n");
        }

        private static void GeneratePromoteStrategy(Random random, Ticket ticket)
        {
            var strategyIndex = random.Next(0, 4);
            switch (strategyIndex)
            {
                case 0:
                    ticket.SetPromoteStrategy(new NoDisCount());
                    break;
                case 1:
                    ticket.SetPromoteStrategy(new QuarterDisCount());
                    break;
                case 2:
                    ticket.SetPromoteStrategy(new HalfDisCount());
                    break;
                default:
                    break;
            }
        }
    }
}

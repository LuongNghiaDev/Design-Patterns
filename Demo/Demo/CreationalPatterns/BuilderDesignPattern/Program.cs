using Demo.CreationalPatterns.BuilderDesignPattern.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var carByBuilder = new CarBuilder()
                                      .AddWheels(4)
                                      .AddSeatBelts(new SeatBelt("Seat Belt"))
                                      .AddWindscreen(new Windscreen("wind screen"))
                                      .AddEngine(new Engine("Foot"))
                                      .Paint("red")
                                      .Build();
            Console.WriteLine(carByBuilder.ToString());
        }
    }
}

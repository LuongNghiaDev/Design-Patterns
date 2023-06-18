using Demo.CreationalPatterns.BuilderDesignPattern.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.BuilderDesignPattern
{
    interface ICarBuilder
    {
        CarBuilder AddWheels(int numberOfWheels);
        CarBuilder AddSeatBelts(SeatBelt seatBelt);
        CarBuilder Paint(string color);
        CarBuilder AddWindscreen(Windscreen windscreen);
        CarBuilder AddEngine(Engine engine);
        Car Build();
    }
}

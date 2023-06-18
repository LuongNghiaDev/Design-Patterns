using Demo.CreationalPatterns.FactoryMethodDesignPattern.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.FactoryMethodDesignPattern.Factory
{
    interface IAnimalFactory
    {
        IAnimal CreateAnimal();

    }
}

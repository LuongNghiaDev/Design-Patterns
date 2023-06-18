using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.FactoryMethodDesignPattern.Animal
{
    class Dog : IAnimal
    {
        public string GetName()
        {
            return "I' am Dog";
        }
    }
}

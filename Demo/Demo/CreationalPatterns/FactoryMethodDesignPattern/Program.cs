using Demo.CreationalPatterns.FactoryMethodDesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if (type == 0)
            {
                factory = new RandomAnimalFactory();
            }
            else
            {
                factory = new BasicAnimalFactory();
            }

            Console.WriteLine(factory.CreateAnimal().GetName());
        }
    }
}

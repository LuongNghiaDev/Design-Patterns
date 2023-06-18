using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CreationalPatterns.BuilderDesignPattern.Other
{
    public class Windscreen
    {
        public Windscreen(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class ConcreteProductA1 : IChef
    {
        public string PrepareDinner()
        {
            return "I am preparing dinner!";
        }
    }
}

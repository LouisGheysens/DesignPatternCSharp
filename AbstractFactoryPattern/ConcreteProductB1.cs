using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class ConcreteProductB1 : ISousChef
    {
        public string CoockMeat()
        {
            return "I am coocking";
        }

        public string HelpChef(IChef chef)
        {
            var result = chef.PrepareDinner();

            return "The result of the B1 collaborating with the ({result})";
        }
    }
}

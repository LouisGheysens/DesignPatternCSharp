using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class ConcreteProductB2 : ISousChef
    {
        public string CoockMeat()
        {
            return "Coocking meat part two!";
        }

        public string HelpChef(IChef chef)
        {
            var result = chef.PrepareDinner();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}

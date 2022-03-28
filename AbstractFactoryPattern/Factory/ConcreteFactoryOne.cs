using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Factory
{
    public class ConcreteFactoryOne : IKitchen
    {
        public IChef CreateProductOne()
        {
            return new ConcreteProductA1();
        }

        public ISousChef CreateProductTwo()
        {
            return new ConcreteProductB1();
        }
    }
}

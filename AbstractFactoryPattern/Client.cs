using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactoryPattern.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IKitchen factory)
        {
            var productA = factory.CreateProductOne();
            var productB = factory.CreateProductTwo();

            Console.WriteLine(productB.CoockMeat());
            Console.WriteLine(productB.HelpChef(productA));
        }
    }
}

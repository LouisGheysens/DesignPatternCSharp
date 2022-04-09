using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //If car has Basic accessories, it has to deal with this class!
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar aCar) : base(aCar)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Basic Accessories Package";

        }

        public override double GetCost()
        {
            return base.GetCost() + 2000.0;
        }
    }
}

using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LuxuryCar : ICar
    {
        public double GetCost()
        {
            return 1000000.0;
        }

        public string GetDescription()
        {
            return "Luxury Car";
        }
    }
}

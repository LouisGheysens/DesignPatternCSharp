using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class EconomyCar : ICar
    {
        public double GetCost()
        {
            return 450000.0;
        }

        public string GetDescription()
        {
            return "Economy Car";
        }
    }
}

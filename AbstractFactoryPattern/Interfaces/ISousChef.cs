using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Interfaces
{
    public interface ISousChef
    {
        string CoockMeat();
        string HelpChef(IChef chef);
    }
}

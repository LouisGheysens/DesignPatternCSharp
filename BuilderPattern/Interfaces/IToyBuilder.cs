using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Interfaces
{
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void SetArms();
        void SetBody();
        void SetLegs();
        Toy GetToy();
    }
}

using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //SuperClass
    public class ToyCreator
    {
        private IToyBuilder _toyBuilder;

        public ToyCreator(IToyBuilder builder)
        {
            _toyBuilder = builder;
        }

        public void CreateToy()
        {
            _toyBuilder.SetModel();
            _toyBuilder.SetArms();
            _toyBuilder.SetLegs();
            _toyBuilder.SetModel();
            _toyBuilder.SetHead();
        }

        public Toy GetToy()
        {
            return _toyBuilder.GetToy();
        }
    }
}

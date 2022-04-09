using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ToyBBuilder: IToyBuilder
    {
        Toy toy = new();

        public Toy GetToy()
        {
            return toy;
        }

        public void SetArms()
        {
            toy.Arms = "9";
        }

        public void SetBody()
        {

            toy.Body = "LITTLE";
        }

        public void SetHead()
        {

            toy.Head = "NONE";
        }

        public void SetLegs()
        {

            toy.Legs = "SIXTEEN";
        }

        public void SetModel()
        {

            toy.Model = "PMMMSFFS33E";
        }
    }
}

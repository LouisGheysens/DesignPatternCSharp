
using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ToyABuilder : IToyBuilder
    {
        Toy toy = new();

        public Toy GetToy()
        {
            return toy;
        }

        public void SetArms()
        {
            toy.Arms = "NONE";
        }

        public void SetBody()
        {

            toy.Body = "BIG";
        }

        public void SetHead()
        {

            toy.Head = "Small";
        }

        public void SetLegs()
        {

            toy.Legs = "TWO";
        }

        public void SetModel()
        {

            toy.Model = "AB222441KO";
        }
    }
}

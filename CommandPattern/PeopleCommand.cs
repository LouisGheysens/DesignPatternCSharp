using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class PeopleCommand : ICommand
    {
        public string Name 
        {
            get
            {
                return "Animal";
            }
        }

        public void Execute()
        {
            Console.WriteLine("Start Peoples!!");
        }
    }
}

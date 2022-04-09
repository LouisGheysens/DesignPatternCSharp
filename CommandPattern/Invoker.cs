using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Invoker
    {
        //Method that will show the action that is choosen by the user
        ICommand cmd = null;
        public ICommand GetCommand(string action)
        {
            switch (action)
            {
                case "Animal":
                    cmd = new AnimalCommand();
                    break;
                case "People":
                    cmd = new PeopleCommand();
                    break;
                default:
                    break;
            }
            return cmd;
        }
    }
}

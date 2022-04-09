using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class WebService : IBridgeComponents
    {
        public void Send(string messageType)
        {
            Console.WriteLine("Sending " + messageType + " using webservice!");
        }
    }
}

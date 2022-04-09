using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //DataSender is used to send SMS, Email, Data etc...
    public abstract class DataSender
    {
        public IBridgeComponents _bridgeComponent;

        public abstract void Send();
    }
}

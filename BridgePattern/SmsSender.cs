using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Class to send SMS
    public class SmsSender : DataSender
    {
        public override void Send()
        {
            _bridgeComponent.Send("SMS");
        }
    }
}

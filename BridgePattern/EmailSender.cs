using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Class to send emails
    public class EmailSender : DataSender
    {
        public override void Send()
        {
            _bridgeComponent.Send("Email");
        }
    }
}

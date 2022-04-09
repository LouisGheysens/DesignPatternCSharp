using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Base
{
    public abstract class HandlerBase
    {
        public HandlerBase NextTeam { get; private set; }
        public ContextObject Question { get; private set;}

        public HandlerBase(HandlerBase nextHandler, ContextObject question)
        {
            this.NextTeam = nextHandler;
            this.Question = question;
        }

        public abstract void HandleRequest();
    }
}

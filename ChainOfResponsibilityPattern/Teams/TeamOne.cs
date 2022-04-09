using ChainOfResponsibilityPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Teams
{
    public class TeamOne : HandlerBase
    {
        public TeamOne(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question)
        {
        }

        public override void HandleRequest()
        {
            Console.WriteLine("Question : {0}", Question.Question.ToString());
            Console.WriteLine("*******************************************");

            Console.WriteLine("Wating for team one to respond");
            Thread.Sleep(10000);
            Console.WriteLine("\t no response from team one.....");

            NextTeam.HandleRequest();
        }
    }
}

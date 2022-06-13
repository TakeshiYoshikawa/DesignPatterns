using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class BaseChainHandler : IChainHandler
    {
        private IChainHandler next;

        public virtual object Handle(object obj)
        {
            if(next != null)
                return next.Handle(obj);
            else
                return null;
        }

        public IChainHandler SetNext(IChainHandler handler)
        {
            next = handler;

            return handler;
        }
    }
}

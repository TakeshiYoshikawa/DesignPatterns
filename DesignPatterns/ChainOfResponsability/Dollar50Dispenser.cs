using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Dollar50Dispenser : BaseChainHandler
    {
        public int DispatchedBills { get; set; }

        public override object Handle(object obj)
        {
            var currency = obj as Currency;

            if(currency.Amount >= 50)
            {
                int bills = currency.Amount / 50;
                int remainder = currency.Amount % 50;

                DispatchedBills = bills;
                Console.WriteLine($"Dispatching {bills} 50$ notes");

                if(remainder != 0)
                    return base.Handle(new Currency(remainder));
            }

            return base.Handle(currency);
        }
    }
}

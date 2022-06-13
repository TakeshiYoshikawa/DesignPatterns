namespace ChainOfResponsability
{
    public class Dollar20Dispenser : BaseChainHandler
    {
        public int DispatchedBills { get; set; }
        public override object Handle(object obj)
        {
            var currency = obj as Currency;

            if (currency.Amount >= 20)
            {
                int bills = currency.Amount / 20;
                int remainder = currency.Amount % 20;

                DispatchedBills = bills;
                Console.WriteLine($"Dispatching {bills} 20$ notes");

                if (remainder != 0)
                    return base.Handle(new Currency(remainder));
            }

            return base.Handle(currency);
        }
    }
}

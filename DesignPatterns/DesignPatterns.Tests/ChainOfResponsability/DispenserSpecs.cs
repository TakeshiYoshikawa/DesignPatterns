using ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.Tests.ChainOfResponsability
{
    public class DispenserSpecs
    {
        [Fact]
        public void should_something()
        {
            var d50Chain = new Dollar50Dispenser();
            var d20Chain = new Dollar20Dispenser();
            var d10Chain = new Dollar10Dispenser();

            d50Chain.SetNext(d20Chain).SetNext(d10Chain);

            d50Chain.Handle(new Currency(530));

            Assert.Equal(10, d50Chain.DispatchedBills);
            Assert.Equal(1, d20Chain.DispatchedBills);
            Assert.Equal(1, d10Chain.DispatchedBills);
        }
    }
}

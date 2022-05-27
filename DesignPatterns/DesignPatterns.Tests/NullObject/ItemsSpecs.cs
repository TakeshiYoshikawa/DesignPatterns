using NullObject;
using Xunit;

namespace DesignPatterns.Tests.NullObject
{
    public class ItemsSpecs
    {
        [Fact]
        public void Should_return_a_value_without_discount()
        {
            Item item = new Item("Tenis", 150.00);

            Assert.Equal(300.00, item.PriceQuantity(2));
            Assert.Equal("Tenis: R$150,00", item.ToString());
        }

        [Fact]
        public void Should_return_a_discount_value_by_some_percent()
        {
            Item item = new Item("Tenis", 150.00, new PercentualDiscount(10));

            Assert.Equal(270.0, item.PriceQuantity(2));
            Assert.Equal("Tenis: R$135,00", item.ToString());
        }

        [Fact]
        public void Should_return_an_absolute_discount_value()
        {
            Item item = new Item("Tenis", 150.00, new AbsoluteDiscount(10));

            Assert.Equal(280.0, item.PriceQuantity(2));
            Assert.Equal("Tenis: R$140,00", item.ToString());
        }
    }
}
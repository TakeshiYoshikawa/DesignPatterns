using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class Item
    {
        private string Name;
        private double Value;
        private IDiscount discount = new NullDiscount();

        public Item(string name, double value, IDiscount discount)
        {
            this.Name = name;
            this.Value = value;
            this.discount = discount;
        }

        public Item(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        {
            double finalValue = discount.ApplyDiscout(Value);
            return $"{Name}: R${finalValue:0.00}";
        }

        public double PriceQuantity(int quantity)
        {
            return discount.ApplyDiscout(this.Value) * quantity;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class AbsoluteDiscount : IDiscount
    {
        private double discountValue;

        public AbsoluteDiscount(double discountValue)
        {
            this.discountValue = discountValue;
        }

        public double ApplyDiscout(double originalValue)
        {
            return originalValue - discountValue;
        }
    }
}

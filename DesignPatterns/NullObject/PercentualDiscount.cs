using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class PercentualDiscount : IDiscount
    {
        private double percent;

        public PercentualDiscount(double percent)
        {
            this.percent = percent;
        }

        public double ApplyDiscout(double originalValue)
        {
            return (100.0 - percent) / 100 * originalValue;
        }
    }
}

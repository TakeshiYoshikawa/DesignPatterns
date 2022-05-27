using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public interface IDiscount
    {
        public double ApplyDiscout(double originalValue);
    }
}

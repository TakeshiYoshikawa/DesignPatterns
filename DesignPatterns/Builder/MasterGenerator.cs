using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MasterGenerator : NameGenerator
    {
        protected override string GetTreatment()
        {
            return "Master ";
        }
    }
}

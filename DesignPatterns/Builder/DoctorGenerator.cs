using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DoctorGenerator : NameGenerator
    {
        protected override string GetTreatment()
        {
            return "Doctor ";
        }
    }
}

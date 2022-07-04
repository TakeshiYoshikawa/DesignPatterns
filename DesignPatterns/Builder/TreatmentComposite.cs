using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TreatmentComposite : ITreatment
    {
        private ITreatment treatment1, treatment2;

        public TreatmentComposite(ITreatment treatment1, ITreatment treatment2)
        {
            this.treatment1 = treatment1;
            this.treatment2 = treatment2;
        }

        public string Treat()
        {
            return treatment1.Treat() + treatment2.Treat();
        }
    }
}

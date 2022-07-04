using Builder;
using System;

namespace Builder
{
    public class NameGeneratorBuilder
    {
        private NameGenerator ng;

        public NameGeneratorBuilder CreatePerson()
        {
            ng = new NameGenerator();
            return this;
        }

        public NameGeneratorBuilder CreateMaster()
        {
            ng = new MasterGenerator();
            return this;
        }

        public NameGeneratorBuilder CreateDoctor()
        {
            ng = new DoctorGenerator();
            return this;
        }

        public NameGeneratorBuilder CreateHighness()
        {
            insertNewTreatment(new HighnessGenerator());
            return this;
        }

        public NameGeneratorBuilder CreateMagnificent()
        {
            insertNewTreatment(new MagnificentGenerator());
            return this;
        }

        private void insertNewTreatment(ITreatment t)
        {
            {
                if (ng.GetTreatmentStrategy() is NullObjectTreatment)
                    ng.SetTreatment(t);
                else
                    ng.SetTreatment(new TreatmentComposite(ng.GetTreatmentStrategy(), t));
            }

        }

        public NameGenerator Generate()
        {
            return ng;
        }
    }
}
namespace Builder
{
    public class NameGenerator
    {
        private ITreatment treatment = new NullObjectTreatment();

        public void SetTreatment(ITreatment treatment)
        {
            this.treatment = treatment;
        }

        public ITreatment GetTreatmentStrategy()
        {
            return treatment;
        }

        public string GenerateName(string name)
        {
            return $"{treatment.Treat()}{GetTreatment()}{name}";
        }

        protected virtual string GetTreatment()
        {
            return "";
        }
    }
}
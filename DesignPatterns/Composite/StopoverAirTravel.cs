namespace Composite
{
    public class StopoverAirTravel : IAirTravel
    {
        private IAirTravel p1;
        private IAirTravel p2;

        public StopoverAirTravel(IAirTravel p1, IAirTravel p2)
        {
            if (!p1.GetDestiny().Equals(p2.GetSource()))
                throw new Exception("One of the fields does not exist");

            this.p1 = p1;
            this.p2 = p2;
        }

        public virtual int GetCost()
        {
            return p1.GetCost() + p2.GetCost();
        }

        public string GetDestiny()
        {
            return p2.GetDestiny();
        }

        public int GetDistance()
        {
            return p1.GetDistance() + p2.GetDistance();
        }

        public string GetSource()
        {
            return p1.GetSource();
        }
    }
}
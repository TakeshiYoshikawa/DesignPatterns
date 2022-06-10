namespace Composite
{
    public class ConnectionAirTravel : StopoverAirTravel
    {
        private int connectionFare;

        public ConnectionAirTravel(IAirTravel p1, IAirTravel p2, int connectionFare) : base(p1, p2)
        {
            this.connectionFare = connectionFare;
        }

        public override int GetCost()
        {
            return base.GetCost() + connectionFare;
        }
    }
}
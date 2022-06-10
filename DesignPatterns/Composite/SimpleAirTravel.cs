namespace Composite
{
    public class SimpleAirTravel : IAirTravel
    {
        private string source;
        private string destiny;
        private int cost;
        private int distance;

        public SimpleAirTravel(string source, string destiny, int cost, int distance)
        {
            this.source = source; 
            this.destiny = destiny; 
            this.cost = cost; 
            this.distance = distance; 
        }

        public int GetCost()
        {
            return cost;
        }

        public string GetDestiny()
        {
            return destiny;
        }

        public int GetDistance()
        {
            return distance;
        }

        public string GetSource()
        {
            return source;
        }
    }
}
using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.Tests.Composite
{
    public class CompositeAirTravel
    {
        [Fact]
        public void should_exist_trips_with_stopover()
        {
            IAirTravel t1 = new SimpleAirTravel("GRU", "FOR", 200, 400);
            IAirTravel t2 = new SimpleAirTravel("FOR", "NAT", 150, 200);

            IAirTravel stopover = new StopoverAirTravel(t1, t2);

            Assert.Equal("GRU", stopover.GetSource());
            Assert.Equal("NAT", stopover.GetDestiny());
            Assert.Equal(350, stopover.GetCost());
            Assert.Equal(600, stopover.GetDistance());
        }

        [Fact]
        public void should_exist_trips_with_stopover_and_different_airports()
        {
            IAirTravel t1 = new SimpleAirTravel("GRU", "BSB", 200, 400);
            IAirTravel t2 = new SimpleAirTravel("FOR", "NAT", 150, 200);

            Assert.Throws<Exception>(() => new StopoverAirTravel(t1, t2));
        }

        [Fact]
        public void should_exist_trips_with_multiple_stops()
        {
            IAirTravel t1 = new SimpleAirTravel("GRU", "FOR", 200, 400);
            IAirTravel t2 = new SimpleAirTravel("FOR", "NAT", 150, 200);

            IAirTravel stopover = new ConnectionAirTravel(t1, t2, 80);

            Assert.Equal("GRU", stopover.GetSource());
            Assert.Equal("NAT", stopover.GetDestiny());
            Assert.Equal(430, stopover.GetCost());
            Assert.Equal(600, stopover.GetDistance());
        }

        [Fact]
        public void should_account_trips_with_stopovers_and_connections()
        {
            IAirTravel t1 = new SimpleAirTravel("GRU", "FOR", 200, 400);
            IAirTravel t2 = new SimpleAirTravel("FOR", "NAT", 150, 200);
            IAirTravel t3 = new SimpleAirTravel("NAT", "BSB", 250, 300);

            IAirTravel stopover = new StopoverAirTravel(t1, t2);
            IAirTravel connection = new ConnectionAirTravel(stopover, t3, 50);

            Assert.Equal("GRU", connection.GetSource());
            Assert.Equal("BSB", connection.GetDestiny());
            Assert.Equal(650, connection.GetCost());
            Assert.Equal(900, connection.GetDistance());
        }
    }
}

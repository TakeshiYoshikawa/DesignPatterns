int seconds = 10;

TransportCreator carCreator = new CarCreator();
Console.WriteLine($"Car after {seconds} seconds: {carCreator.CalculateAcceleration(10)} m/s");

TransportCreator truckCreator = new TruckCreator();
Console.WriteLine($"Truck after {seconds} seconds: {truckCreator.CalculateAcceleration(10)} m/s");
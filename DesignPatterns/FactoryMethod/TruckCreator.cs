public class TruckCreator : TransportCreator
{
    public override ITransport FactoryMethod()
    {
        return new Truck();
    }
}
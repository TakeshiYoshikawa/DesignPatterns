public class CarCreator : TransportCreator
{
    public override ITransport FactoryMethod()
    {
        return new Car();
    }
}
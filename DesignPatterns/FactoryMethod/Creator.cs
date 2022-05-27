public abstract class TransportCreator
{
    public abstract ITransport FactoryMethod();

    public double CalculateAcceleration(int time)
    {
        ITransport transport = FactoryMethod();

        var acceleration = transport.Accelerate(time);

        return acceleration;
    }
}
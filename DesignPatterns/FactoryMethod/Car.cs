public class Car : ITransport
{
    private int velocity = 70;

    public double Accelerate(int time)
    {
        return velocity / time;
    }
}
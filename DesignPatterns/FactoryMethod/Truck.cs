internal class Truck : ITransport
{
    private double velocity = 120;
    public double Accelerate(int time)
    {
        return velocity / time;
    }
}
namespace NullObject
{
    public class NullDiscount : IDiscount
    {
        public double ApplyDiscout(double originalValue)
        {
            return originalValue;
        }
    }
}
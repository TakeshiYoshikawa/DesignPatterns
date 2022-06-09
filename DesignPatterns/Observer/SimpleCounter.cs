namespace Observer
{
    public class SimpleCounter : IWordCounter
    {
        private int quantity = 0;

        public void Count(string word)
        {
            quantity++;
        }

        public int counter()
        {
            return quantity;
        }
    }
}
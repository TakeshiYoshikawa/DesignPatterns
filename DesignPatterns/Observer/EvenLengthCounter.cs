namespace Observer
{
    public class EvenLengthCounter : IWordCounter
    {
        private int quantity = 0;

        public void Count(string word)
        {
            if(word.Length % 2 == 0)
                quantity++;
        }

        public int counter()
        {
            return quantity;
        }
    }
}
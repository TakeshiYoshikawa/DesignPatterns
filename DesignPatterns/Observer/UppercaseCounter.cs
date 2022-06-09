namespace Observer
{
    public class UppercaseCounter : IWordCounter
    {
        private int quantity = 0;

        public void Count(string word)
        {
            if (Char.IsUpper(word.ElementAt(0)))
            {
                quantity++;
            }
        }

        public int counter()
        {
            return quantity;
        }
    }
}
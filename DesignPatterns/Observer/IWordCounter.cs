namespace Observer
{
    public interface IWordCounter
    {
        void Count(string word);
        int counter();
    }
}
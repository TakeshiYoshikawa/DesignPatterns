namespace Observer
{
    public class WordSpliter
    {
        private Dictionary<String, IWordCounter> counters = new Dictionary<String, IWordCounter>();

        public string[] Split(string phrase)
        {
            string[] words = phrase.Split(" ");
            foreach(string word in words)
            {
                foreach(IWordCounter counter in counters.Values)
                {
                    counter.Count(word);
                }
            }

            return phrase.Split(" ");
        }


        public void AddCounter(string name, IWordCounter counter)
        {
            counters.Add(name, counter);
        }
        public int getCounter(string name)
        {
            return counters[name].counter();
        }
    }
}
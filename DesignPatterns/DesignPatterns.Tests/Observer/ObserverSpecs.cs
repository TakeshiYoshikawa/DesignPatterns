using Observer;
using Xunit;

namespace DesignPatterns.Tests.Observer
{
    public class ObserverSpecs
    {
        [Fact]
        public void check_word_spliter()
        {
            string phrase = "o rato roeu a roupa do rei";
            
            WordSpliter spliter = new WordSpliter();
            string[] words = spliter.Split(phrase);
            
            Assert.Equal(7, words.Length);
        }

        [Fact]
        public void Should_count_word()
        {
            string phrase = "o rato roeu a roupa do rei";
            
            WordSpliter spliter = new WordSpliter();
            spliter.AddCounter("SIMPLE", new SimpleCounter());
            spliter.Split(phrase);

            Assert.Equal(7, spliter.getCounter("SIMPLE"));
        }

        [Fact]
        public void Should_count_uppercase_words()
        {
            string phrase = "o Rato roeu a roupa do Rei";

            WordSpliter spliter = new WordSpliter();
            spliter.AddCounter("UPPERCASE", new UppercaseCounter());
            spliter.Split(phrase);

            Assert.Equal(2, spliter.getCounter("UPPERCASE"));
        }

        [Fact]
        public void Should_count_words_with_even_length()
        {
            string phrase = "o Rato roeu a roupa do Rei";

            WordSpliter spliter = new WordSpliter();
            spliter.AddCounter("EVEN", new EvenLengthCounter());
            spliter.Split(phrase);

            Assert.Equal(3, spliter.getCounter("EVEN"));
        }

        [Fact]
        public void Should_count_all_previous_type_of_words_()
        {
            string phrase = "o Rato roeu a roupa do Rei";

            WordSpliter spliter = new WordSpliter();
            spliter.AddCounter("SIMPLE", new SimpleCounter());
            spliter.AddCounter("UPPERCASE", new UppercaseCounter());
            spliter.AddCounter("EVEN", new EvenLengthCounter());
            spliter.Split(phrase);

            Assert.Equal(7, spliter.getCounter("SIMPLE"));
            Assert.Equal(2, spliter.getCounter("UPPERCASE"));
            Assert.Equal(3, spliter.getCounter("EVEN"));
        }
    }
}

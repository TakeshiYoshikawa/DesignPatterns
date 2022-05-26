using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFactoryMethod
{
    public class RandomIntGenerator
    {
        private Random random;

        public int min;
        public int max;

        private RandomIntGenerator(int min, int max)
        {
            random = new Random();

            this.min = random.Next(min, max);
            this.max = random.Next(min, max);
        }

        public static RandomIntGenerator LowerThan(int max)
        {
            return new RandomIntGenerator(1, max);
        }

        public static RandomIntGenerator Between(int min, int max)
        {
            return new RandomIntGenerator(min, max);
        }

        public static RandomIntGenerator HigherThan(int min)
        {
            return new RandomIntGenerator(min, int.MaxValue);
        }
    }
}

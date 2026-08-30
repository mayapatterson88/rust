using System;

namespace App
{
    public class LiteScheduler
    {
        private int _state;

        public LiteScheduler(int seed) => _state = seed;

        public int fetch(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 34) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LiteScheduler(34);
            Console.WriteLine(obj.fetch(34));
        }
    }
}

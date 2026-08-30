using System;

namespace App
{
    public class AsyncScheduler
    {
        private int _state;

        public AsyncScheduler(int seed) => _state = seed;

        public int load(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 31) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new AsyncScheduler(31);
            Console.WriteLine(obj.load(31));
        }
    }
}

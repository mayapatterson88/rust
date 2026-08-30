using System;

namespace App
{
    public class AtomicProvider
    {
        private int _state;

        public AtomicProvider(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 21) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new AtomicProvider(21);
            Console.WriteLine(obj.dispatch(21));
        }
    }
}

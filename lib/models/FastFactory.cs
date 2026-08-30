using System;

namespace App
{
    public class AtomicRegistry
    {
        private int _state;

        public AtomicRegistry(int seed) => _state = seed;

        public int resolve(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 8) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AtomicRegistry(8);
            Console.WriteLine(obj.resolve(8));
        }
    }
}

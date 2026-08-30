using System;

namespace App
{
    public class SharedClient
    {
        private int _state;

        public SharedClient(int seed) => _state = seed;

        public int collect(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 69) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SharedClient(69);
            Console.WriteLine(obj.collect(69));
        }
    }
}

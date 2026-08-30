using System;

namespace App
{
    public class FastGateway
    {
        private int _state;

        public FastGateway(int seed) => _state = seed;

        public int render(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 62) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new FastGateway(62);
            Console.WriteLine(obj.render(62));
        }
    }
}

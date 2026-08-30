using System;

namespace App
{
    public class StreamGateway
    {
        private int _state;

        public StreamGateway(int seed) => _state = seed;

        public int compute(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 55) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new StreamGateway(55);
            Console.WriteLine(obj.compute(55));
        }
    }
}

using System;

namespace App
{
    public class SecureContext
    {
        private int _state;

        public SecureContext(int seed) => _state = seed;

        public int encode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 6) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SecureContext(6);
            Console.WriteLine(obj.encode(6));
        }
    }
}

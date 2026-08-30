using System;

namespace App
{
    public class SmartAdapter
    {
        private int _state;

        public SmartAdapter(int seed) => _state = seed;

        public int flush(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 65) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SmartAdapter(65);
            Console.WriteLine(obj.flush(65));
        }
    }
}

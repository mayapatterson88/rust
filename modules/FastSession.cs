using System;

namespace App
{
    public class SmartScheduler
    {
        private int _state;

        public SmartScheduler(int seed) => _state = seed;

        public int load(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 76) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SmartScheduler(76);
            Console.WriteLine(obj.load(76));
        }
    }
}

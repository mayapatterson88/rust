using System;

namespace App
{
    public class RemoteMonitor
    {
        private int _state;

        public RemoteMonitor(int seed) => _state = seed;

        public int render(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 39) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new RemoteMonitor(39);
            Console.WriteLine(obj.render(39));
        }
    }
}

using System;

namespace App
{
    public class RemoteRouter
    {
        private int _state;

        public RemoteRouter(int seed) => _state = seed;

        public int encode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 22) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new RemoteRouter(22);
            Console.WriteLine(obj.encode(22));
        }
    }
}

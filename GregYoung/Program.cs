using System;

namespace GregYoung
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispatcher = Bootstrap.Configure();
            dispatcher.Dispatch(new AppendToLogCommand() { Id = 42});

            Console.ReadLine();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}

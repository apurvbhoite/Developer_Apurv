using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (var i = 0;i <= 100; i++)
            {
                if ((i % 3) == 0)
                    counter++;
            }
            Console.WriteLine(string.Format("{0} numbers", counter));
        }
    }
}

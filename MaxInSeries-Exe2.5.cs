using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Num= Console.ReadLine();
            var Numbers = Num.Split(',');
            var max = 0;
            foreach ( var i in Numbers)
            {
                var number = Convert.ToInt32(i);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("max is " + max);

        }
    }
}

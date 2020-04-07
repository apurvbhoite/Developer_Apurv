using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for(int i = 1;i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}",factorial);
        }
    }
}

using System;

namespace UdemyExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var SpeedLimit = Convert.ToInt32(Console.ReadLine());
            var SpeedOfCar = Convert.ToInt32(Console.ReadLine());
            int DemeritPoint = 0;
            if (SpeedOfCar <= SpeedLimit)
                Console.WriteLine("OK");
            else
            {
                while (SpeedOfCar > SpeedLimit)
                {
                    DemeritPoint++;
                    SpeedOfCar = SpeedOfCar - 5;
                }
                Console.WriteLine(string.Format(" {0} Demerit Point Received", DemeritPoint));
                if (DemeritPoint > 12)
                    Console.WriteLine("Licence Suspended");
            }
        }
    }
}

using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Random RandomNo = new Random();
            int RandomNumber = RandomNo.Next(1, 10);
            for(int i = 0;i < 4; i++)
            {
                var GussedNo = Convert.ToInt32(Console.ReadLine());
                if (GussedNo == RandomNumber)
                {
                    Console.WriteLine("you won");
                    break;
                }
                else
                    count++;
            }
            if(count == 4)
            {
                Console.WriteLine("you lost");
            }

        }
    }
}

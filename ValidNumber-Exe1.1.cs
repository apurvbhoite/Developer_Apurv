using System;

namespace UdemyExercise
{
    class ValidNumber
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            if (number <= 10 && number >= 0)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

        }
    }
}

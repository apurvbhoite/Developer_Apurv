using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>();
            for( int i = 0; i< 5; i++ )
            {
                var buffer = Convert.ToInt32(Console.ReadLine());
                if(Numbers.Contains(buffer))
                {
                    Console.WriteLine("Number exist in list, reenter another number");
                    i--;
                    continue;
                }
                else
                {
                    Numbers.Add(buffer);
                }
            }
            Numbers.Sort();
            foreach(var number in Numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}

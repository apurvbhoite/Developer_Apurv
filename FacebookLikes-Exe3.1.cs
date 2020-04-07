using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._1
{
    class Program
    {

        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                var a = String.IsNullOrWhiteSpace(input);
                if (a)
                {
                    break;
                }
                else
                {
                    names.Add(input);
                }
            }
            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others liked your post", names[0], names[1], names.Count - 2);
                Console.ReadKey();
            }
                   
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
                Console.ReadKey();
            }
                
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} liked your post.", names[0]);
                Console.ReadKey();
            }
                
            else
                    Console.WriteLine();

            }


        }
    }

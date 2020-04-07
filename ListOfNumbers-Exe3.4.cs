using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<int>();
            while(true)
            {
                var buffer = Console.ReadLine();
                if (buffer.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    if (inputs.Contains(Convert.ToInt32(buffer)))
                    {
                        continue;
                    }
                    else
                        inputs.Add(Convert.ToInt32(buffer));

                }

            }
            Console.WriteLine("numbers are");
            for (int i = 0; i < inputs.Count; i++)
                Console.WriteLine(inputs[i]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();

            var array = new char[Name.Length];
            for (var i = Name.Length; i > 0; i--)
                array[Name.Length - i] = Name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}

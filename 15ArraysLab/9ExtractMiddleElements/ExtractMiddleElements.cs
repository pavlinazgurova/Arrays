using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            var arrayIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var arrayLenth = arrayIntegers.Length;

            if (arrayLenth == 1)
            {
                Console.WriteLine($"{{ {arrayIntegers[0]} }}");
            }
            else if (arrayLenth % 2 == 0)
            {
                Console.Write($"{{ {arrayIntegers[arrayLenth / 2 - 1]}, ");
                Console.WriteLine($"{arrayIntegers[arrayLenth / 2]} }}");
            }
            else if (arrayLenth % 2 == 1)
            {
                Console.Write($"{{ {arrayIntegers[arrayLenth / 2 - 1]}, ");
                Console.Write($"{arrayIntegers[arrayLenth / 2]}, ");
                Console.WriteLine($"{arrayIntegers[arrayLenth / 2 + 1]} }}");
            }
        }
    }
}

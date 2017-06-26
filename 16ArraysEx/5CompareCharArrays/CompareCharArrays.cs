using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            var firstChars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondChars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var first = firstChars.Length;
            var second = secondChars.Length;

            var max = Math.Max(first, second);

            for (int i = 0; i < max; i++)
            {
                if (firstChars[i] != secondChars[i])
                {
                    if ((int)firstChars[i] < (int)secondChars[i])
                    {
                        Console.WriteLine(string.Join("", firstChars));
                        Console.WriteLine(string.Join("", secondChars));
                        return;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondChars));
                        Console.WriteLine(string.Join("", firstChars));
                        return;
                    }
                }
                else
                {
                    if (first < second)
                    {
                        Console.WriteLine(string.Join("", firstChars));
                        Console.WriteLine(string.Join("", secondChars));
                        return;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondChars));
                        Console.WriteLine(string.Join("", firstChars));
                        return;
                    }
                }
            }
            Console.WriteLine(string.Join("", secondChars));
            Console.WriteLine(string.Join("", firstChars));
        }
    }
}

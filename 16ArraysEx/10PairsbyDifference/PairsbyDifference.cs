using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PairsbyDifference
{
    class PairsbyDifference
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            var diff = 0;

            for (int i = 0; i < numbers.Length ; i++)
            {
                for (int k = i; k < numbers.Length; k++)
                {
                    var substraction = Math.Abs(numbers[i] - numbers[k]);

                    if (substraction == difference)
                    {
                        diff++;
                    }
                }
            }
            Console.WriteLine(diff);
        }
    }
}

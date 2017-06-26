using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7MaxSequenceofIncreasingElements
{
    class MaxSequenceofIncreasingElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var start = 0;
            var lenght = 0;

            var bestStart = 0;
            var bestLenght = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    lenght++;
                    start = i - lenght;
                    if (lenght > bestLenght)
                    {
                        bestStart = start;
                        bestLenght = lenght;
                    }
                }
                else
                {
                    lenght = 0;
                }
            }
            for (int i = bestStart; i <= bestLenght + bestStart; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var start = numbers[0];
            var lenght = 0;

            var bestStart = 0;
            var bestLenght = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == start)
                {
                    lenght++;

                    if (lenght > bestLenght)
                    {
                        bestStart = start;
                        bestLenght = lenght;
                    }
                }
                else
                {
                    if (lenght >= bestLenght)
                    {
                        start = numbers[i];
                    }
                    lenght = 1;
                }
            }
            Console.Write($"{bestStart} ");
        }
    }
}

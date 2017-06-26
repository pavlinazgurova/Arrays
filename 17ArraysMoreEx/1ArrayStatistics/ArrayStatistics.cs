using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            var min = int.MaxValue;
            var max = int.MinValue;
            var sum = 0;
            var average = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                sum += numbers[i];
                average = sum / (double)numbers.Length;
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}

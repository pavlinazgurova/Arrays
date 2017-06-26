using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5RoundingNumbersAwayfromZero
{
    class RoundingNumbersAwayfromZero
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var arrayIntegers = new int[nums.Length];

            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                arrayIntegers[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {arrayIntegers[i]}");
            }
            
        }
    }
}

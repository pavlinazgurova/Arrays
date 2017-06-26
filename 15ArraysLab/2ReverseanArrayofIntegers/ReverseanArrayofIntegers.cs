using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ReverseanArrayofIntegers
{
    class ReverseanArrayofIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
    }
}

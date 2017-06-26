using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var first = nums.Length;
            var second = nums1.Length;

            var max = Math.Max(first, second);

            var sum = new int[max];
            for (int i = 0; i < max; i++)
            {
                sum[i] = nums[i % first] + nums1[i % second];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

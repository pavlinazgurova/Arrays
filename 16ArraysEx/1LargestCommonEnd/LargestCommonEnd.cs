using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').ToArray();
            var second = Console.ReadLine().Split(' ').ToArray();

            var min = Math.Min(first.Length, second.Length);
            var max = Math.Max(first.Length, second.Length);

            var left = 0;
            var right = 0;

            for (int i = 0; i < min; i++)
            {
                if (first[i] == second[i])
                {
                    left++;
                }
            }

            for (int i = 0; i < min; i++)
            {
                if (first[first.Length - 1 - i] == second[second.Length - 1 - i])
                {
                    right++;
                }
            }
            

            if (left > right)
            {
                Console.WriteLine(left);
            }
            else
            {
                Console.WriteLine(right);
            }
        }
    }
}

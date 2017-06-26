using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var nums = new int[n];
            nums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                var sum = 0;

                for (int p = i - k; p <= i - 1; p++)
                {
                    if (p >= 0)
                    {
                        sum += nums[p];
                    }
                    nums[i] = sum;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

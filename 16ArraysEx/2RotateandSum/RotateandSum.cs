using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2RotateandSum
{
    class RotateandSum
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            var sum = new int[array.Length];
            int n = array.Length;

            var rotated = new int[array.Length];

            for (int i = 0; i < k; i++)
            {
                int lastDigit = array[array.Length - 1];
                for (int r = array.Length - 1; r > 0; r--)
                {
                    array[r] = array[r - 1];
                }
                array[0] = lastDigit;

                for (int p = 0; p < array.Length; p++)
                {
                    sum[p] += array[p];
                }
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}

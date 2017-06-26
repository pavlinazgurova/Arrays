using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FoldandSum
{
    class FoldandSum
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = array.Length / 4;

            var firstRow = new int[k];
            var secondRow = new int[k];
            var lastArray = new int[2 * k];
            var middleArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = array[i];
            }

            for (int i = 0; i < k; i++)
            {
                secondRow[i] = array[array.Length - 1 - i];
            }
            Array.Reverse(firstRow);
            

            for (int i = 0; i < k; i++)
            {
                lastArray[i] = firstRow[i];
                lastArray[i + k] = secondRow[i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                middleArray[i] = array[k + i];
            }

            var sum = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                sum[i] = lastArray[i] + middleArray[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

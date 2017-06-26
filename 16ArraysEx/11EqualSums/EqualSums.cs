using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }

                for (int p = i + 1; p < numbers.Length; p++)
                {
                    rightSum += numbers[p];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
                           
            Console.WriteLine("no");          
        }
    }
}

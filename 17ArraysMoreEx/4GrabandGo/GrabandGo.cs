using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GrabandGo
{
    class GrabandGo
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).ToArray();
            long n = long.Parse(Console.ReadLine());

            long index = 0;
            long sum = 0;
            bool found = false;

            for (long i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    index = i;
                    found = true;
                }
            }           

            for (long i = 0; i < index; i++)
            {
                sum += numbers[i];
                
            }
            if (found)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}

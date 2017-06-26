using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int p = i + 1; p < nums.Length; p++)
                {
                    var sum = nums[i] + nums[p];
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine($"{nums[i]} + {nums[p]} == {sum}");
                        found = true; 
                    }
                    
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            var sum = 0;

            var number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                
                if (i == 0 && i < array.Length)
                {
                    number = array[i];
                    sum += number;
                }
                else
                {
                    if (i < array.Length)
                    {
                        number = array[i];
                        sum += number;
                    }
                    else if ()
                    {

                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(number);
        }
    }
}

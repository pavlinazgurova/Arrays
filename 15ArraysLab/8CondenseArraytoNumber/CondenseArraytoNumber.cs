using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8CondenseArraytoNumber
{
    class CondenseArraytoNumber
    {
        static void Main(string[] args)
        {
            var arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

          


            while (arrayOfIntegers.Length > 1)
            {
                var condensed = new int[arrayOfIntegers.Length - 1];
                for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
                {
                    condensed[i] = arrayOfIntegers[i] + arrayOfIntegers[i + 1];
                    
                }
                arrayOfIntegers = condensed;
                
            }
            Console.WriteLine(arrayOfIntegers[0]);
            //for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
            //{
            //    while (lenght > 1)
            //    {
            //        condensed[i] = arrayOfIntegers[i] + arrayOfIntegers[i + 1];
            //        sum += condensed[i];
            //    }
            //    Console.WriteLine(sum);

        }
        }
    }


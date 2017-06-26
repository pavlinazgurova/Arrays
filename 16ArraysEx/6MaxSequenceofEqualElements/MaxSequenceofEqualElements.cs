using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6MaxSequenceofEqualElements
{
    class MaxSequenceofEqualElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var start = 0;
            var lenght = 1;

            var bestStart = 0;
            var bestLenght = 0;            

            for (int i = 1; i < numbers.Length; i++)
            {                
                if (numbers[i] == numbers[i - 1])
                {
                    lenght++;
                    if (lenght > bestLenght)
                    {
                        bestStart = numbers[i];
                        bestLenght = lenght;
                    }
                }                
                else
                {
                    start = numbers[i];                    
                    lenght = 1;                                      
                }          
            }
            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write($"{bestStart} ");
            }
            
        }
    }
}

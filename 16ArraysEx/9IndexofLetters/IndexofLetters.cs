using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9IndexofLetters
{
    class IndexofLetters
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine();//.Split(' ').Select(char.Parse).ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{letters[i]} -> {(int)letters[i] - 97}");
            }
        }
    }
}

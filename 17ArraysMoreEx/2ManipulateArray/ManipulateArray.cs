using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().
                Split(new[] { ' ', }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();

            int n = int.Parse(Console.ReadLine());
            string command = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                command = Console.ReadLine();

                if (command == "Reverse")
                {
                    Array.Reverse(array);
                }
                if (command == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command.Contains("Replace"))
                {
                    var newCommand = command.Split(' ').ToArray();
                    var index = int.Parse(newCommand[1]);
                    var replaceString = newCommand[2];
                    array[index] = replaceString;

                    array = array.Select(s => s.Replace(array[index], replaceString)).ToArray();

                   
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
       

        static void GetDistinct(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

            }
        }
    }
}

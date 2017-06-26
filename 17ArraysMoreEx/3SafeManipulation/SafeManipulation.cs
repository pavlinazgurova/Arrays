using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SafeManipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().
                Split(new[] { ' ', }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command.Contains("Replace"))
                {
                    try
                    {
                        var newCommand = command.Split(' ').ToArray();
                        var index = int.Parse(newCommand[1]);
                        var replaceString = newCommand[2];
                        array[index] = replaceString;

                        array = array.Select(s => s.Replace(array[index], replaceString)).ToArray();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));

        }


    }
}


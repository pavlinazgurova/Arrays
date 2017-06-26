using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
            int n = int.Parse(Console.ReadLine());
            var count = 0;
            var valid = string.Empty;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == n)
                {
                    count++;
                    valid += $"{ingredients[i]}, ";
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
                if (count >= 10)
                {
                    Console.WriteLine($"Made pizza with total of 10 ingredients.");
                    Console.WriteLine($"The ingredients are: {valid.Trim().Remove(valid.Length-2)}.");
                    return;
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");            
            Console.WriteLine($"The ingredients are: {valid.Trim().Remove(valid.Length - 2)}.");
        }
    }
}

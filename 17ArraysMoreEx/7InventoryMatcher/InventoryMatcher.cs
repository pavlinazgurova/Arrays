using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
            var quantities = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).
                ToArray();
            var prices = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(decimal.Parse).
                ToArray();
            var command = Console.ReadLine();

            while (command != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == command)
                    {
                        Console.WriteLine($"{products[i]} costs: {prices[Array.IndexOf(prices, prices[i])]}; Available quantity: {quantities[Array.IndexOf(quantities, quantities[i])]}");
                    }
                }
                command = Console.ReadLine(); 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
            var quantities = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(decimal.Parse).
                ToArray();
            var prices = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(decimal.Parse).
                ToArray();
            var command = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();


            //var product = command[0];
            decimal totalprice = 0;

            while (command[0] != "done")
            {

                for (int i = 0; i < command.Length; i++)
                {
                    decimal wantedQuantity = decimal.Parse(command[1]);
                    if (wantedQuantity < quantities[Array.IndexOf(quantities, quantities[i])])
                    {
                        Console.WriteLine($"We do not have enough {products[i]}");
                    }
                    else if (command[0] == products[0])
                    {

                        totalprice = wantedQuantity * prices[Array.IndexOf(prices, prices[i])];
                        quantities[Array.IndexOf(quantities, quantities[i])] = wantedQuantity;
                        Console.WriteLine($"{products[i]} x {wantedQuantity} costs {totalprice:f2}");

                    }
                }
                command = Console.ReadLine().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            var heists = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).                
                ToArray();

            var priceOfJewel = prices[0];
            var priceOfGold = prices[1];

            var countJewel = 0;
            var countGold = 0;
            var earnings = 0;
            var expences = 0;

            while (heists[0] != "Jail")
            {
                var text = heists[0];
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '%')
                    {
                        countJewel++;
                        expences += int.Parse(heists[1]);
                        earnings += countJewel * priceOfJewel;
                    }
                    if (text[i] == '$')
                    {
                        countGold++;
                        expences += int.Parse(heists[1]);
                        earnings += countJewel * priceOfGold;
                    }
                    
                }
                heists = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
                countJewel = 0;
                countGold = 0;
            }
            var diff = Math.Abs(earnings - expences);

            if (diff > 0)
            {
                
                Console.WriteLine($"Heists will continue. Total earnings: {diff}.");
            }
            else
            {
                 
                Console.WriteLine($"Have to find another job. Lost: {diff}.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressTheGirlfriend
{
    class ImpressTheGirlfriend
    {
        static void Main(string[] args)
        {
            decimal rubles = (decimal.Parse(Console.ReadLine()) / 100) * (decimal)3.5;
            decimal dollars = decimal.Parse(Console.ReadLine()) * (decimal)1.5;
            decimal euro = decimal.Parse(Console.ReadLine()) * (decimal)1.95; 
            decimal specialLeva = decimal.Parse(Console.ReadLine()) / 2;
            decimal leva = decimal.Parse(Console.ReadLine());

            
            List<decimal> price = new List<decimal>();
            price.Add(rubles);
            price.Add(dollars);
            price.Add(euro);
            price.Add(specialLeva);
            price.Add(leva);

            decimal maxPrice = Math.Ceiling(price.Max());

            Console.WriteLine("{0:F2}", maxPrice);

        }
    }
}

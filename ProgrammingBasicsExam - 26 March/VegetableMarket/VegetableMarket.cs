using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double vegetableSum = vegetablePrice * vegetableKg;
            double fruitSum = fruitPrice * fruitKg;

            double totalSum = vegetableSum + fruitSum;

            double euroSum = totalSum / 1.94;

            Console.WriteLine(euroSum);


        }
    }
}

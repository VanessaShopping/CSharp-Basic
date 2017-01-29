using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Hungry_Garfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
            decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
            decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

            decimal pizzaSum = (pizzaPrice / rate) * pizzaQuantity;
            decimal lasagnaSum = (lasagnaPrice / rate) * lasagnaQuantity;
            decimal sandwichSum = (sandwichPrice / rate) * sandwichQuantity;
            decimal totalSum = pizzaSum + lasagnaSum + sandwichSum;

            if (money - totalSum >= 0)
            {
                decimal moneyLeft = money - totalSum;
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", moneyLeft);
            }
            else
            {
                decimal moneyNeeded = totalSum - money;
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", moneyNeeded);
            }

        }
    }
}

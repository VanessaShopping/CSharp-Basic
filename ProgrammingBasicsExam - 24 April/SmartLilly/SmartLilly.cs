using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int giftSum = 10;
            int toyCount = 0;

            for (int age = 1; age <= ageLilly; age++)
            {
                if (age % 2 == 0)
                {
                    totalSum += giftSum;
                    giftSum += 10;
                    totalSum--;
                }
                else
                {
                    toyCount++;
                }
            }
            int moneyFromToy = toyCount * priceToy;
            int totalMoney = totalSum + moneyFromToy;
            if (totalMoney>=washingMachine)
            {
                double differenceInSum =(double)( totalMoney - washingMachine);
                Console.WriteLine($"Yes! {differenceInSum:F2}");
            }
            else
            {
                double differenceInSum = (double)(washingMachine - totalMoney);
                Console.WriteLine($"No! {differenceInSum:F2}");
            }
        }
    }
}

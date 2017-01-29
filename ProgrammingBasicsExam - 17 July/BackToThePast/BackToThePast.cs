using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double yearToLive = double.Parse(Console.ReadLine());
            double moneyForSpend = 0.0;
            double age = 19;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                    moneyForSpend += 12000;
                else
                {
                    moneyForSpend += 12000 + 50 * age;
                    age = age + 2;
                }
            }
            if (money >= moneyForSpend)
            {
                double n = money - moneyForSpend;
                Console.WriteLine($"Yes! He will live a carefree life and will have {n:F2} dollars left.");
            }
            else
            {
                double m = moneyForSpend - money;
                Console.WriteLine($"He will need {m:F2} dollars to survive.");
            }
        }
    }
}

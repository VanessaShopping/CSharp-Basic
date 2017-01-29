using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double vipValue = 499.99;
            double normalValue = 249.99;

            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            double people = double.Parse(Console.ReadLine());
            double transport = 0.0;
            double moneyForBillets = 0.0;

            // Определяне на бюджет

            if (people <= 4)
                transport = budget * 0.75;
            else if (people >= 5 && people <= 9)
                transport = budget * 0.60;
            else if (people >= 10 && people <= 24)
                transport = budget * 0.50;
            else if (people >= 25 && people <= 49)
                transport = budget * 0.40;
            else if (people >= 50)
                transport = budget * 0.25;

            // Пари за билети
            if (category == "vip")
                moneyForBillets = people * vipValue;
            else if (category == "normal")
            {
                moneyForBillets = people * normalValue;
            }

            double remainingМoney = budget - transport;

            if (remainingМoney >= moneyForBillets)
            {
                double resto = remainingМoney - moneyForBillets;
                Console.WriteLine($"Yes! You have {resto:F2} leva left.");
            }
            else
            {
                double enough = moneyForBillets - remainingМoney;
                Console.WriteLine($"Not enough money! You need {enough:F2} leva.");
            }
        }
    }
}

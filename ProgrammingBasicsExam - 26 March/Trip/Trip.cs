using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double moneyToSpend = 0;
            string trip = "Bulgaria";
            string typeTrip = "Hotel";

            if (budget <= 100 && season == "summer")
            {
                typeTrip = "Camp";
                moneyToSpend = budget * 0.3;
            }
            else if (budget <= 100 && season == "winter")
                moneyToSpend = budget * 0.7;

            else if (budget <= 1000 && season == "summer")
            {
                typeTrip = "Camp";
                trip = "Balkans";
                moneyToSpend = budget * 0.4;
            }
            else if (budget <= 1000 && season == "winter")
            {
                trip = "Balkans";
                moneyToSpend = budget * 0.8;
            }
            else
            {
                trip = "Europe";
                moneyToSpend = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {trip}");
            Console.WriteLine("{0} - {1:F2}", typeTrip, moneyToSpend);
        }
    }
}

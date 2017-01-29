using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {
            double cakesWants = double.Parse(Console.ReadLine());
            double kgFlourForOneCace = double.Parse(Console.ReadLine());
            double flourAvailable = double.Parse(Console.ReadLine());
            double trufflesAvailable = double.Parse(Console.ReadLine());
            double priceTruffle = double.Parse(Console.ReadLine()) * trufflesAvailable;


            double madeCakes = Math.Floor(flourAvailable / kgFlourForOneCace);
            if (madeCakes >= cakesWants)
            {
                double cakePrice = (priceTruffle / cakesWants) * 1.25;
                Console.WriteLine($"All products available, price of a cake: {cakePrice:F2}");
            }
            else
            {
                double neededFlour = (cakesWants * kgFlourForOneCace) - flourAvailable;
                Console.WriteLine($"Can make only {madeCakes:f0} cakes, need {neededFlour:F2} kg more flour");
            }
        }
    }
}

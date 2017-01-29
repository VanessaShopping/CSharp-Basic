using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            double vineyard = double.Parse(Console.ReadLine());
            double unitGrapes = double.Parse(Console.ReadLine());
            double neededlitersWine = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());


            double areaForWine = vineyard * 0.4;
            double totalGrapes = areaForWine * unitGrapes;
            double totalWine = totalGrapes / 2.5;

            if (totalWine >= neededlitersWine)
            {
                int wineFloor = (int)Math.Floor(totalWine);
                double remainingWine = Math.Ceiling(totalWine - neededlitersWine);
                double winePerWorker = Math.Ceiling(remainingWine / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {wineFloor} liters.");
                Console.WriteLine($"{remainingWine} liters left -> {winePerWorker} liters per person.");
            }
            else
            {
                int shortnessWine = (int)Math.Floor(neededlitersWine - totalWine);
                Console.WriteLine($"It will be a tough winter! More {shortnessWine} liters wine needed.");
            }
        }
    }
}

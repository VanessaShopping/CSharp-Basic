using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class PipesInPool
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1Flow = p1 * h;
            double p2Flow = p2 * h;
            double totalFlow = p1Flow + p2Flow;


            if (totalFlow <= poolVolume)
            {
                double fullPercent = (int)(totalFlow / poolVolume * 100);
                double p1Percent = (int)(p1Flow / totalFlow * 100);
                double p2Percent = (int)(p2Flow / totalFlow * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",fullPercent,p1Percent,p2Percent);
            }
            else
            {
                double overFlow = totalFlow - poolVolume;
                Console.WriteLine($"For {h} hours the pool overflows with {overFlow} liters.");
            }


        }
    }
}

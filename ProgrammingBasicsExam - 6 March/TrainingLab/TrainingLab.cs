using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double corridor = 100.0;

            double length = l * 100.0;
            double width = w * 100.0;

            int rows = (int)(length / 120);
            int cols = (int)((width - corridor) / 70);
            int numberOfPlaces = rows * cols - 3;
            Console.WriteLine(numberOfPlaces);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class RepairingTheTiles
    {
        static void Main(string[] args)
        {
            double square = double.Parse(Console.ReadLine());

            double widthTile = double.Parse(Console.ReadLine());
            double lenghtTile = double.Parse(Console.ReadLine());

            double widthBench = double.Parse(Console.ReadLine());
            double lenghtBench = double.Parse(Console.ReadLine());

            double time = 0.2;


            double sqrtArea = square * square;
            double bench = widthBench * lenghtBench;
            double tile = widthTile * lenghtTile;


            double workArea = sqrtArea - bench;
            double neededTiles = workArea / tile;
            double takeTime = neededTiles * time;

            Console.WriteLine(neededTiles);
            Console.WriteLine(takeTime);
        }
    }
}

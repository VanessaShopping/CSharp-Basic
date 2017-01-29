using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            //int bricks = int.Parse(Console.ReadLine());
            //int workers = int.Parse(Console.ReadLine());
            //int capacity = int.Parse(Console.ReadLine());

            //int courses = (bricks + capacity ) / (workers * capacity);
            //Console.WriteLine(courses);

            double bricks = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double courses = Math.Ceiling(bricks / (workers * capacity));
            Console.WriteLine(courses);
        }
    }
}

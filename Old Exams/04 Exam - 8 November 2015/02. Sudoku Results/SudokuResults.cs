using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuResults
{
    class SudokuResults
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int count = 0;
            int totalSeconds = 0;

            while (line != "Quit")
            {
                string[] MinSec = line.Split(':');
                int min = int.Parse(MinSec[0]);
                int sec = int.Parse(MinSec[1]);

                totalSeconds += min * 60 + sec;
                line = Console.ReadLine();
                count++;
            }

            double average = (double)totalSeconds / count;
            if (average < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (average >= 720 && average <= 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, Math.Ceiling(average));

        }
    }
}

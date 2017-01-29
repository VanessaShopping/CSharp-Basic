using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workDays = 365 - holidays;
            int workTime = workDays * 63;
            int holidayTime = holidays * 127;
            int totalTime = workTime + holidayTime;

            //int hours = totalTime / 60;
            //int minutes = totalTime % 60;

            if (totalTime <= 30000)
            {
                int timeRemaining = 30000 - totalTime;
                int hours = timeRemaining / 60;
                int minutes = timeRemaining % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                int overrunТime = totalTime - 30000;
                int hours = overrunТime / 60;
                int minutes = overrunТime % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}

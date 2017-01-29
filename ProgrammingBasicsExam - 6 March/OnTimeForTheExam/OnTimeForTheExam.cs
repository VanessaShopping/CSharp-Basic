using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourОfАrrival = int.Parse(Console.ReadLine());
            int minutesOfАrrival = int.Parse(Console.ReadLine());

            int totalMinutesExam = (hourExam * 60) + minutesExam;
            int totalMinutesOfArrival = (hourОfАrrival * 60) + minutesOfАrrival;

            Late(totalMinutesExam, totalMinutesOfArrival);

            OnTime(totalMinutesExam, totalMinutesOfArrival);

            Early(totalMinutesExam, totalMinutesOfArrival);
        }

        private static void Early(int totalMinutesExam, int totalMinutesOfArrival)
        {
            if (totalMinutesExam - totalMinutesOfArrival > 30)
            {
                Console.WriteLine("Early");
                int result = totalMinutesExam - totalMinutesOfArrival;
                int hours = result / 60;
                int minutes = result % 60;
                if (hours >= 1)
                {
                    if (minutes >= 10)
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);
                    }
                }
                else
                    Console.WriteLine("{0} minutes before the start", minutes);

            }
        }

        private static void OnTime(int totalMinutesExam, int totalMinutesOfArrival)
        {
            if (totalMinutesExam - totalMinutesOfArrival <= 30 && totalMinutesExam - totalMinutesOfArrival >= 0)
            {
                int result = totalMinutesExam - totalMinutesOfArrival;
                Console.WriteLine("On time");
                if (result != 0)
                    Console.WriteLine("{0} minutes before the start", result);
                //else if (result != 0 && result < 10)
                //    Console.WriteLine("0{0} minutes before the start", result);
            }
        }

        private static void Late(int totalMinutesExam, int totalMinutesOfArrival)
        {
            if (totalMinutesExam < totalMinutesOfArrival)
            {
                int result = totalMinutesOfArrival - totalMinutesExam;
                Console.WriteLine("Late");
                if (totalMinutesOfArrival - totalMinutesExam < 60)
                {
                    //if (result < 10)
                    //    Console.WriteLine("0{0} minutes after the start", result);
                    //else
                        Console.WriteLine("{0} minutes after the start", result);
                }
                else
                {
                    int hours = result / 60;
                    int minutes = result % 60;
                    if (minutes < 10)
                        Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
                    else
                        Console.WriteLine("{0}:{1} hours after the start", hours, minutes);
                }
            }
        }
    }
}

using System;

class TimePlus15Minutes
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        minute = minute + 15;

        if (minute <= 59)
        {
            if (hour < 10 && hour >= 0)
            {
                Console.WriteLine(hour + ":" + minute);
            }
            else
            {
                Console.WriteLine(hour + ":" + minute);
            }
        }


        else if (minute > 59 && minute <= 74)
        {
            hour += 1;
            minute -= 60;
            if (hour > 23)
            {
                hour = 0;
                if (minute < 10)
                {
                    Console.WriteLine(hour + ":0" + minute);
                }
                else
                {
                    Console.WriteLine(hour + ":" + minute);
                }
            }
            else if (hour <= 23)
            {
                if (minute < 10)
                {
                    Console.WriteLine(hour + ":0" + minute);
                }
                else
                {
                    Console.WriteLine(hour + ":" + minute);
                }
            }

        }
    }
}
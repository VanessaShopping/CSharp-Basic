using System;

class SumSeconds
{
    static void Main()
    {
        int racerOne = int.Parse(Console.ReadLine());
        int racerTwo = int.Parse(Console.ReadLine());
        int racerThree = int.Parse(Console.ReadLine());
        int seconds = racerOne + racerTwo + racerThree;
        int minutes = 0;

        if (seconds <= 59)
        {
            
        }
        if (seconds > 59 && seconds <= 119)
        {
            minutes += 1;
            seconds = seconds - 60;
        }
        if (seconds > 119 && seconds <= 179)
        {
            minutes += 2;
            seconds = seconds - 120;
        }
        if (seconds > 179)
        {
            minutes += 3;
            seconds = seconds - 180;
        }
        if (seconds < 10)
        {
            Console.WriteLine("{0}:0{1}", minutes, seconds);
        }
        else if (seconds <= 59)
        {
            Console.WriteLine(minutes + ":" + seconds);
        }
    }
}
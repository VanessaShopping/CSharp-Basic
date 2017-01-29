using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine().ToLower();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        var gameSofia = (48 - h) * 3.0 / 4;
        var gameP = p * 2.0 / 3;
        var result = gameSofia + gameP + h;
        if (year == "leap")
        {
            result = result + (result * 0.15);
        }
        Console.WriteLine(Math.Truncate(result));
    }
}
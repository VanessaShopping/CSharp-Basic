using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(c * 1.8 + 32);
    }
}
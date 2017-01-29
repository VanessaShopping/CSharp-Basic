using System;
using System.Collections.Generic;

class MetricConverterTwo
{
    static void Main()
    {
        var factors = new Dictionary<string, double> {
                { "m",1.0 },
                { "mm",1000.0 },
                { "cm",100.0 },
                { "mi",0.000621371192 },
                { "in",39.3700787 },
                { "km",0.001 },
                { "ft",3.2808399 },
                { "yd",1.0936133 }
            };
        var amount = double.Parse(Console.ReadLine());
        var mfrom = Console.ReadLine().ToLower();
        var mto = Console.ReadLine().ToLower();
        Console.WriteLine(amount / factors[mfrom] * factors[mto]);
    }
}
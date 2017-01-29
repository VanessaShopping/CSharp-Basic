using System;

class SquareArea
{
    static void Main()
    {
        Console.Write("Въведете страна на квадрат : ");
        var a = int.Parse(Console.ReadLine());
        var area = a * a;
        Console.WriteLine("Лицето на квадрата е: {0}", area);
    }
}
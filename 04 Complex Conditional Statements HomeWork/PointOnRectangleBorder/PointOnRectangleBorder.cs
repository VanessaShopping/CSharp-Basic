using System;


class PointOnRectangleBorder
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x =  double.Parse(Console.ReadLine());
        double y =  double.Parse(Console.ReadLine());

        var rightSide = (x == x1) && (y >= y1) && (y <= y2);
        var leftSide = (x == x2) && (y >= y1) && (y <= y2);
        var upSide = (y == y1) && (x >= x1) && (x <= x2);
        var downSide = (y == y2) && (x >= x1) && (x <= x2);

        if (rightSide || leftSide || upSide || downSide)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}
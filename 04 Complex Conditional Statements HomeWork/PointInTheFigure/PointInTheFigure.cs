using System;

class PointInTheFigure
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        // First Figure
        int x1 = h;
        int x2 = 2 * h;
        int y1 = 4 * h;
        int y2 = 7 * h;
        // Second Figure
        int a1 = 0;
        int a2 = 3 * h;
        int b1 = 7 * h;
        int b2 = 8 * h;
        // Border
        var right = (x == x1) && (y >= y1) && (y <= y2) || (x == a1) && (y >= b1) && (y <= b2);
        var left = (x == x2) && (y >= y1) && (y <= y2) || (x == a2) && (y >= b1) && (y <= b2);
        var up = (y == y1) && (x >= x1) && (x <= x2) || (y == b2) && (x >= a1) && (x <= a2);
        var down = (y == y2) && (x >= x1) && (x <= x2) || (y == b2) && (x >= a1) && (x <= a2);
        // Inside
        var inside = ((x > x1 && x < x2 && y > y1 && y < y2) || (x > a1 && x < a2 && y > b1 && y < b2));

        if (right || left || up || down)
        {
            Console.WriteLine("border");
        }
        else if (inside)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
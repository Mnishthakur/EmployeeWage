using System;
public class Program
{
    public static double GetLineLength(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    public static void Main()
    {
        double x1 = 1.0;
        double y1 = 1.0;
        double x2 = 4.0;
        double y2 = 5.0;
        double length = GetLineLength(x1, y1, x2, y2);
        Console.WriteLine("The length of the line is: {0}", length);
    }
}

using System;

class Program
{
    static void Main()
    {
        // Example points
        double x1 = 2;
        double y1 = 3;
        double x2 = 5;
        double y2 = 7;

        // Calculate the length of the line
        double length = CalculateLineLength(x1, y1, x2, y2);

        // Print the result
        Console.WriteLine("The length of the line is: " + length);
    }

    static double CalculateLineLength(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

        return length;
    }
}

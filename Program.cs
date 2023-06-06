using System;

class Line
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }

    public Line(double x1, double y1, double x2, double y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public double Length()
    {
        double deltaX = X2 - X1;
        double deltaY = Y2 - Y1;
        double length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

        return length;
    }

}

class Program
{
    static void Main()
    {
        // Example lines
        Line line1 = new Line(x1, y1, x2, y2);
        Line line2 = new Line(x1, y1, x2, y2);
        Line line3 = new Line(x1, y1, x2, y2);

        // Check equality using Equals method
        bool areEqual1 = line1.Equals(line2);
        bool areEqual2 = line1.Equals(line3);

        // Print the results
        Console.WriteLine("Are line1 and line2 equal? " + areEqual1);
        Console.WriteLine("Are line1 and line3 equal? " + areEqual2);
    }
}

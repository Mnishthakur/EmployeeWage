using System;

class Line : IComparable<Line>
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

    public int CompareTo(Line other)
    {
        if (other == null)
            return 1;

        double thisLength = Length();
        double otherLength = other.Length();

        if (thisLength < otherLength)
            return -1;
        else if (thisLength > otherLength)
            return 1;
        else
            return 0;
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

        // Compare lines using CompareTo method
        int comparison1 = line1.CompareTo(line2);
        int comparison2 = line1.CompareTo(line3);

        // Print the results
        Console.WriteLine("Comparison result between line1 and line2: " + comparison1);
        Console.WriteLine("Comparison result between line1 and line3: " + comparison2);
    }
}

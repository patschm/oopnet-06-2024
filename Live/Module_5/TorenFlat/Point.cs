namespace TorenFlat;

internal class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    //public static Point Add(Point a, Point b)
    public static Point operator+(Point a, Point b)
    {
        return new Point { X = a.X + b.X, Y = a.Y + b.Y };
    }

    public void Show()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}

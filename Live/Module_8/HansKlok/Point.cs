namespace HansKlok;

internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
    }
    public void Show()
    {
        Console.WriteLine(this) ;
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

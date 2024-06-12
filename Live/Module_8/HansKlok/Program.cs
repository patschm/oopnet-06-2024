
using System.Text;

namespace HansKlok;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };

        Console.WriteLine(p1);
        DoeIets(p1);
        //p1.Y = 2900;
        Console.WriteLine(p1);
    }

    static void DoeIets(Point px)
    {
        px.X = 100;
        px.Y = 200;
        Console.WriteLine(px);
    }
}

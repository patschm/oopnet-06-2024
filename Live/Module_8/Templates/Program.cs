
namespace Templates;

internal class Program
{
    static void Main(string[] args)
    {
        decimal a = 10;
        decimal b = 20;

        Console.WriteLine($"a={a}, b={b}");
        Swap<decimal>(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");

        Point<float> p = new Point<float> { X = 10F, Y = 20F };
        p.X = 30F;

    }

    //private static void Swap(ref int aa, ref int bb)
    //{
    //    int tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref long aa, ref long bb)
    //{
    //    long tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref float aa, ref float bb)
    //{
    //    float tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    private static void Swap<T>(ref T aa, ref T bb) where T: struct, IFormattable
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }

}

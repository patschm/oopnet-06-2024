namespace HetCern;

delegate int MathDel(int a, int b);

internal class WillemKlein
{
    public void Bereken(MathDel fun, int x, int y)
    {
        Console.WriteLine("Willem Klein gaat rekenen...");
        int result = fun(x,y);

        Console.WriteLine($"Willem roept: Het antwoord is {result}");
    }
}

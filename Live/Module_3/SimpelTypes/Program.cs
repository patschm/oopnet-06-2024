namespace SimpelTypes;

internal class Program
{
    static void Main(string[] args)
    {
        int ndag = 3;
        Weekdag dag = Weekdag.Maandag;
        Console.WriteLine(dag);
        Console.WriteLine((Weekdag)ndag);
    }
}

enum Weekdag:long
{
    Zondag =  1,
    Maandag = 2,
    Dinsdag = 4,
    Woensdag = 8,
    Donderdag = 16,
    Vrijdag = 32,
    Zaterdag = 64_000_000_000
}

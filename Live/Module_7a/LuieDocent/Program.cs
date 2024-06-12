namespace LuieDocent;

internal class Program
{
    static void Main(string[] args)
    {
        Patrick p1 = new Patrick();
        Kevin kevin = new Kevin();

        //p1.Bestelling();

        kevin.VoerUit(p1.Bestelling);
        kevin.VoerUit(Program.Ontplof);
    }

    static void Ontplof()
    {
        Console.WriteLine("Kaboooem!!");
    }
}

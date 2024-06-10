namespace DeWereld;

internal class Program
{
    static void Main(string[] args)
    {
       // Big bang

        Lamp l1 = new Lamp(100, ConsoleColor.Yellow);
        l1.Intensiteit = 2_000;
       // l1.intensiteit = 4_000_000_000;
        l1.Kleur = ConsoleColor.Yellow;

        Lamp l2 = new Lamp { Kleur = ConsoleColor.Green, Intensiteit = 300};
        //l2.intensiteit = 300;
        //l2.kleur = ConsoleColor.Green;

        l1.Aan();
        Console.WriteLine("Text");
        l2.Aan();
        Console.WriteLine("Text 2");
        l2.Uit();

        Lamp l3 = new Lamp(200, ConsoleColor.Cyan);
        l3.Aan();
        Console.WriteLine("Text 3");
        l3.Uit();

        // Big crunch
    }
}



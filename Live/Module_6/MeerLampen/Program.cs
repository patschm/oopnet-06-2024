namespace MeerLampen;

internal class Program
{
    static void Main(string[] args)
    {
        // Generaliseren.
        // Stel jezelf de vraag: Is het een?
        TL t1 = new TL { Intensiteit = 200, Kleur=ConsoleColor.Red, KnipperCount = 5 };

        t1.Aan();
        Console.WriteLine("Zomaar iets");
        t1.Uit();

        Zaklamp t2 = new Zaklamp { Intensiteit = 400, Kleur = ConsoleColor.Cyan };
        //t2.Aan();
        //t2.Uit();
        (t2 as Zaklamp)?.Signaleer();


        Lamp[] buizen1 = new Lamp[10];
        buizen1[0] = t1;
        buizen1[1] = t2;

        //Zaklamp[] buizen2 = new Zaklamp[10];
        //buizen2[0] = t2;

        foreach(Lamp x in buizen1)
        {
            // Dit is niet wenselijk. Dit zijn uitzonderingen.
            //if (x is Zaklamp)
            //{
            //    (x as Zaklamp).Signaleer();
            //}
            if (x != null)
            {
                x.Aan();
                Console.WriteLine("in foreach");
                x.Uit();
            }
        }
    }
}

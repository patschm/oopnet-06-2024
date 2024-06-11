namespace MeerLampen;

// van een sealed class kun je niet erven.
//sealed class Zaklamp:Lamp
class Zaklamp : Lamp
{
    public void Signaleer()
    {
        Aan();
        Console.WriteLine($"De zaklamp geeft een lichtsignaal");
        Uit();
    }
    public override void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De zaklamp brandt met {Intensiteit} lumen");
    }
    public override void Uit()
    {
        Console.WriteLine("De zaklamp gaat uit");
        Console.ResetColor();
    }
}

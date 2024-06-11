
namespace MeerLampen;

// De TL erft van Lamp
// Je mag maar van een class tegelijk erven.
// Bevordert het hergebruik
internal class TL : Lamp
{
    public int KnipperCount { get; set; } = 3;

    // Met override activeer ik polymorfisme
    public override void Aan()
    {
        _intensiteit = 10;
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De TL knippert {KnipperCount} keer en brand met {Intensiteit} lumen");
    }
    public override void Uit()
    {
        Console.WriteLine("De TL gaat uit");
        Console.ResetColor();
    }
}

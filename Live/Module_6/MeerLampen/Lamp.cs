namespace MeerLampen;

abstract class Lamp
{
    private int _intensiteit = 200;
    public int Intensiteit
    {
        get
        {
            return _intensiteit;
        }
        set
        {
            if (value >= 0 && value <= 10000)
            {
                _intensiteit = value;
            }
        }
    }
    public ConsoleColor Kleur  { get; set; }

    // virtual maakt het gedrag polymorf-ready.
    // override is vrijblijvend.
    public virtual void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is nu aan en brand met {Intensiteit} lumen");
    }

    // Bij abstract is het vrijblijvende eraf. Afgeleide classen MOETEN overidden.
    // De implementatie is overbodig
    public abstract void Uit();
    //{
    //    Console.WriteLine("De lamp gaat uit");
    //    Console.ResetColor();
    //}
}

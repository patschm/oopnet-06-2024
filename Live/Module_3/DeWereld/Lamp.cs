namespace DeWereld;

// Blauwdruk van een lamp.
class Lamp
{
    // Eigenschappen leg je vast in fields.
    private int _intensiteit = 200;
    //private ConsoleColor _kleur = ConsoleColor.Cyan;

    //public void SetIntensiteit(int val)
    //{
    //    if (val >= 0 && val <= 10000)
    //    {
    //        this.intensiteit = val;
    //    }
    //}

    // Property. Geeft toegang (gecontroleerd) tot private fields
    // Encapsulation
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

    // Auto-generating property. Genereert zijn eigen private field.
    public ConsoleColor Kleur  { get; set; }

    // Gedrag leg je vast in functions en/of procedures.
    // Die we gemakshalve dan maar Methods noemen.           
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is nu aan en brand met {Intensiteit} lumen");
        //Console.ResetColor();
    }
    public void Uit()
    {
        Console.WriteLine("De lamp gaat uit");
        Console.ResetColor();
    }

    // Constructor
    // Gebruik om fields een initiele waarde te geven.
    // Gebruik met mate
    public Lamp(int intensiteit, ConsoleColor kleur)
    {
        Console.WriteLine("Construct");
        Intensiteit = intensiteit;
        Kleur = kleur;
    }
    public Lamp()
    {
        
    }
}

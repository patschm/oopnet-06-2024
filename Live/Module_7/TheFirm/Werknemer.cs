namespace TheFirm;

abstract class Persoon
{
    public string? Naam { get; set; }
}


abstract class Werknemer : Persoon, IContract
{
    public abstract void Arbeiten();

    public void Werkt()
    {
        Arbeiten();
    }
}

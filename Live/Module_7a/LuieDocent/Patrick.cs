namespace LuieDocent;

internal class Patrick : IOpdracht
{
    public void Bestelling()
    {
        Console.WriteLine("1 Chai Laitte");
        Console.WriteLine("1 Ice tea");
        Console.WriteLine("1 Alcoholvrij biertje");
        Console.WriteLine("1 Cola Zero");
        Console.WriteLine("1 Iced Milktea");
    }

    public void Opdract()
    {
        Bestelling();
    }
}

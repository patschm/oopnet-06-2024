namespace RadioZender;

delegate void Bericht(string s);

internal class RadioStation
{
    public event Bericht Subscribers;

    public void Zenden()
    {
        Console.WriteLine("Radio gaat zenden");
        Subscribers("Hallo allemaal");
    }
}

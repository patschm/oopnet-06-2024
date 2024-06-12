namespace RadioZender;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation r538 = new RadioStation();
        r538.Subscribers += ViaSms;
        r538.Subscribers += ViaPostduif;
        r538.Subscribers += ViaEther;
        r538.Subscribers += ViaRooksignalen;
        r538.Subscribers += ViaKabel;
        r538.Subscribers += ViaSms;
        r538.Subscribers += ViaPostduif;
        r538.Subscribers += ViaEther;
        r538.Subscribers += ViaRooksignalen;
        r538.Subscribers += ViaKabel;

        r538.Zenden();

        //r538.Subscribers("Hey klojos!!");
    }

    static void ViaSms(string msg)
    {
        Console.WriteLine($"Via SMS ontvangen: {msg}");
    }
    static void ViaEther(string msg)
    {
        Console.WriteLine($"Via Ether ontvangen: {msg}");
    }
    static void ViaKabel(string msg)
    {
        Console.WriteLine($"Via Kabel ontvangen: {msg}");
    }
    static void ViaRooksignalen(string msg)
    {
        Console.WriteLine($"Via Rooksignalen ontvangen: {msg}");
    }
    static void ViaPostduif(string msg)
    {
        Console.WriteLine($"Via Postduif ontvangen: {msg}");
    }
}

namespace LuieDocent;

interface IOpdracht
{
    void Opdract();
}
// Blauwdruk van een function,procedure, method
delegate void OpdrachtDel();

class Kevin
{
    public void VoerUit(OpdrachtDel iets)
    {
        Console.WriteLine("Kevin sputtert wat tegen");
        iets();
    }
    public void VoerUit(IOpdracht iets)
    {
        Console.WriteLine("Kevin sputtert wat tegen");
        iets.Opdract();
    }
}

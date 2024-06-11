
namespace TheFirm;

internal class ChocoladeFabriek
{
    private IBonbonBouwer bouwer;

    public void Hire(IBonbonBouwer val)
    {
        if (val.Age > 18)
        {
            bouwer = val;
        }
    }
    public void Start()
    {
        Console.WriteLine("De chocoladefabriek produceert.");
        bouwer.CreeerBonbon();
    }
}

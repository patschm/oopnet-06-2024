namespace TheFirm;

// Bokito _IMPLEMENTEERT_ de interface IContract
internal class Bokitio : IContract, IBonbonBouwer
{
    public int Age
    {
        get
        {
            return 43;
        }
    }



    public void CreeerBonbon()
    {
        Console.WriteLine("Bokito draait een bonbon in elkaar");
    }

    public void Meppen()
    {
        Console.WriteLine("Bokito mept dames in elkaar");
    }

    public void Werkt()
    {
        Meppen();
    }
}

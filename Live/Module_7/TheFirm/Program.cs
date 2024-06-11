namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        ACME company = new ACME();
        ChocoladeFabriek comp2 = new ChocoladeFabriek();
        Valerie clone1 = new Valerie { Naam = "Valerie" };
        Maarten clone2 = new Maarten { Naam = "Maarten" };
        Jens clone3 = new Jens();
        Bokitio zombie1 = new Bokitio();

        company.Hire(clone2 );
        company.Hire(clone1);
        company.Hire(clone3);
        company.Hire(zombie1 );

        comp2.Hire(zombie1);

        company.Stoomfluit();
        comp2.Start();
          
    }
}

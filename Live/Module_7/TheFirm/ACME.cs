namespace TheFirm;

internal class ACME
{
    private List<IContract> employees = new List<IContract>();

    public void Hire(IContract val)
    {
        employees.Add(val);
    }

    public void Stoomfluit()
    {
        Console.WriteLine("De productiedag begint");
        foreach (IContract employee in employees)
        {
            employee.Werkt();
        }
    }
}

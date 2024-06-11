namespace TorenFlat;

internal class Etage
{
    // Static geeft aan dat dit gedeeld wordt door alle etage objecten.
    // class member genoemd (Etage.)
    private static  Elevator lift      = new Elevator();
    // Instance member. (this.)
    public int floorNumber = 0;

    public void CallElevator()
    {
        Console.WriteLine("De lift wordt aangeroepen");
        Etage.lift.Call(floorNumber);
    }
    public static void ShowLiftStatus()
    {
        //Console.WriteLine(this.floorNumber);
        Console.WriteLine($"De lift staat nu op de {Etage.lift.CurrentFloor}e verdieping");
    }
}

namespace TorenFlat;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };
        Point p2 = new Point { X = 100, Y = 200 };

        //Point p3 = Point.Add(p1, p2 );
        Point p3 = p1 + p2;
        p3.Show();

        //Console.WriteLine($"({p1.X}, {p1.Y})");
        p1.Show();
        //Console.WriteLine($"({p2.X}, {p2.Y})");
        p2.Show();


        Etage[] toren = new Etage[50];
        for (int i = 0; i < toren.Length; i++)
        {
            toren[i] = new Etage { floorNumber = i };
        }

        toren[23].CallElevator();

        //toren[43].CallElevator();

        foreach(Etage et in toren)
        {
            //Etage.ShowLiftStatus();
        }
    }
}

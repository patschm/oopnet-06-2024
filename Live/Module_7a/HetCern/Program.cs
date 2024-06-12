namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonVanDeMeer svdm = new SimonVanDeMeer();

        //wk.Bereken(svdm.Add, 5, 3);

        // Typenaam variabelenaam = initialisatie;
        int age = 42;
        age += 3;
        string name = "Jan";
        name += "!";
        MathDel varnaam = svdm.Add;
        varnaam += svdm.Subtract;
        varnaam += svdm.Add;
        varnaam += svdm.Add;
        varnaam += svdm.Subtract;

        //int result = 0;
        //foreach(var method in varnaam.GetInvocationList())
        //{
        //    Console.WriteLine($"{method.Method.Name}");
        //    result = (int)method.Method.Invoke(svdm, [1, 2]);
        //}

        int result = varnaam(1, 2);

        Console.WriteLine(result);
    }
}

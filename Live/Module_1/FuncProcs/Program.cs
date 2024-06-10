
namespace FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
        int rres = Add(1,2,3,4,5,6,7,8,9,10);
        Console.WriteLine(rres);
        long aaa;
        DoeIetsTwo(out aaa);


        DisplayNumber(prefix:"The number is ");
        long nummer = GetNumber();
        DoeIets(ref nummer);
        DisplayNumber(nummer);
    }

    // Pass by reference
    // long nummer = 2;
    // long getal = nummer;
    static void DoeIets(ref long getal)
    {
        getal *= 100;
    }
    static void DoeIetsTwo(out long getal)
    {
        getal  = 100;
    }

    // Function
    //static int GetNumber()
    //{
    //    Console.WriteLine("Geef een getal");
    //    string? snr = Console.ReadLine();
    //    return int.Parse(snr!);
    //}
    static long GetNumber()
    {
        Console.WriteLine("Geef een getal");
        string? snr = Console.ReadLine();
        return long.Parse(snr!);  
    }
    // Procedure
    static void DisplayNumber(int number = 42, string prefix = "Het nummer is ")
    {
        Console.WriteLine($"{prefix} {number}");
    }
    // Overload
    // Naam hoeft in C# niet uniek te zijn.
    // uniciteit wordt bepaald door de naam, het aantal argumenten en het type van de argumenten.
    // Return type speelt hierin geen rol
    static void DisplayNumber(long number)
    {
        Console.WriteLine($"Het nummer is {number}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static int Add(params int[] nrs)
    {
        return nrs.Sum();
    }
}

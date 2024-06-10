



using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading.Channels;

namespace Basics;


internal class Program
{

    static void Main(string[] args)
    {
        //Variables();
        //Expressions();
        //Flows();
        //Loops();
        Collecties();
    }

    private static void Collecties()
    {
        int[] arr;
        arr =  [1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
        //arr[1] = 2;
        Console.WriteLine(arr[4]);

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine(matrix[1,1]);

        int[,,] kubus = new int[3,3,3];

        int[][] jagged = new int[3][];
        jagged[0] = [1, 2, 3];
        jagged[1] = [1, 2, 3, 4, 5];
        jagged[2] = [1, 2];

        Console.WriteLine(string.Join(", ", arr[1..5]));

        for(int i = 0; i < arr.Length; i++)
        {
            int tmp = arr[i];
            Console.WriteLine(tmp);
        }
        foreach(int tmp in arr)
        {
            Console.WriteLine(tmp);
        }

        List<int> list = new List<int>(100);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        Console.WriteLine(list[1]);

        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("een", 1);

        Console.WriteLine(dict["een"]);

        Stopwatch sw = new Stopwatch();

        sw.Start();
        //string s = "";
        StringBuilder s = new StringBuilder();
        for(int i = 0;i< 100_000;i++)
        {
            //s += i.ToString();
            s.Append(i);
        }
        sw.Stop();
        Console.WriteLine($"Het duurde {sw.Elapsed}");
    }

    private static void Loops()
    {
        int age = 0;
        // Wordt 0 of meer keer uitgevoerd.
        // Bv tabellen uitlezen (kunnen leeg zijn)
        while (age < 10)
        {
            Console.WriteLine(age++);
        }

        // Wordt 1 of meer keer uitgevoerd.
        // User input
        do
        {
            Console.WriteLine(age++);
        }
        while(age < 10);

        // Gebruik je als je weet hoe vaak je iets moet herhalen
        int idx = 0;
        for (Console.WriteLine("Init");; idx++)
        {
            if (idx == 5) continue;
            if (idx == 10) break;
            Console.WriteLine(idx);
        }

        Console.WriteLine(idx);
    }

    private static void Flows()
    {
        // Bijvoorbeeld range checks
        if (Eval() || true)
        {
        }
        else
        {
        }

        int age = 18;
        // Voor bijvoorbeeld checks op concrete waardes
        switch (age)
        {
            case 17:
            case 18:
                Console.WriteLine("17 of 18");
                break;
            case 19:
                Console.WriteLine(19);
                break;
            default:
                Console.WriteLine("Default");
                break;
        }
    }



    private static void Expressions()
    {
        // Is een structuur waarin een operator op een of meer operands (variabele of literal) werkt.
        float x = 4 / 3f;
        Console.WriteLine(x);

        int a = 10;
        Console.WriteLine(a++);
        Console.WriteLine(a);

        bool ba = true;
        bool bb = false;

        bool br = bb && Eval();

        uint ca = 1;  // 0001
        uint cb = 2;  // 0010

        uint cc = ca ^ cb;
        Console.WriteLine(ca << 3);

        Console.WriteLine(2 < 2.5);

        int? age = null;

        Console.WriteLine(age ?? 42);

        string s = "h";

        Console.WriteLine(s?.Length);

        Console.WriteLine(s is string);


        short sa = 10;
        int ia = (int)sa;
        //int ib = sa as int; // Kan null zijn
        // string x = s as string;
    }

    static bool Eval()
    {
        Console.WriteLine("Evaluation");
        return true;
    }
    private static void Variables()
    {
        // Typenaam varnaam;
        // Moeten altijd geinitialiseerd worden.
        int a = 10;
        // Scope (levensduur variabelen) wordt bepaald door accolades
        {
            int b = 20;
            int c = a + b;
        }
        // Kan niet. c bestaat niet meer.
        //Console.WriteLine(c);
    }
}

namespace EvolutieTheorie;

internal class Program
{
    static void Main(string[] args)
    {
        // .NET Framework 1.0/1.1 (2002/2003)
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2);

        // .NET Framework 2.0 (2005)
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;

        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };
        result = m3(3, 4);

        // .NET Framework 3.0/3.5 (2007/2008)
        MathDel m4 = (a, b) => a + b + c;     
        result = m4(4, 5);

        // Procedures
        // Action
        Action< string, int> a1 = DoeIets;
        a1("Allemaal", 42);

        // Functions
        // Func
        Func<string> rl = Console.ReadLine;
        //string res = rl();
        //Console.WriteLine(res);

        Func<int, int, int> m5 = Add;
        result = m5(9,10);

        Func<int, int, int> m6 = (x, y) => x + y;

        result = InlineAdd(11, 12);

        result = WeirdAdd(12, 23);

        Console.WriteLine(result);

        // 2017
        int InlineAdd(int a, int b)
        {
            return a + b + c;
        }
    }
    static int Add(int a, int b)
    {
        return a + b;
    }

    // 2017
    static int WeirdAdd(int a, int b) => a + b;

    static void DoeIets(string extra, int magic)
    {
        Console.WriteLine($"Hoi {extra} ({magic})");
    }
}


delegate int MathDel(int a, int b);

namespace Kweerien;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>(); 
        list.Add(new Person { Firstname = "FirstAAA", Lastname="LastCCC", Age=23 });
        list.Add(new Person { Firstname = "FirstFFF", Lastname = "LastBBB", Age = 34 });
        list.Add(new Person { Firstname = "FirstBBB", Lastname = "LastDDD", Age = 18 });
        list.Add(new Person { Firstname = "FirstCCC", Lastname = "LastFFF", Age = 65 });
        list.Add(new Person { Firstname = "FirstDDD", Lastname = "LastAAA", Age = 6 });

        //var q = list.OrderBy(OrderByAge);
        string last = "F";
        var q = list.Where(p=>p.Firstname.EndsWith(last));
        foreach (Person person in q)
        {
            Console.WriteLine(person);
        }
    }

    static string OrderByFirstname(Person p)
    {
        return p.Firstname;
    }
    static string OrderByLastname(Person p)
    {
        return p.Lastname;
    }
    static int OrderByAge(Person p)
    {
        return p.Age;
    }

    static bool FirstNameEndsWithB(Person p)
    {
        return p.Firstname.EndsWith("B");
    }
}

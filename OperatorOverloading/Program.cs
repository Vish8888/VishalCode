class Program
{
    static void Main()
    {
        int a = 10;
        int b = a;

        if (a == b)
        {
            Console.WriteLine("a & b are Equal");
        }
        else

        {
            Console.WriteLine("a & b are Not Equal");
        }


        string s1 = "Akash";
        //string s2 = s1;
        string s2 = "Akash";
        if (s1 == s2)
        {
            Console.WriteLine("s1 & s2 are Equal");
        }
        else
        {
            Console.WriteLine("s1 & s2 are Not Equal");
        }
        //--------------------------------------

        FullName f1 = new FullName("Vishal","Chimkar");
        //FullName f2 = f1;
        FullName f2  = new FullName("Vishal", "Chimkar");

        if (f1 == f2)
        {
            Console.WriteLine("f1 & f2 are same");
        }
        else
        {
            Console.WriteLine("f1 & f2  are Not Same");
        }
        Console.ReadLine();
    }
}

class FullName
{
    public string FirstName;
    public string LastName;

    public FullName(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }
}
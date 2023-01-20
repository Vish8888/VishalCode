public class P
{
    internal void PrintP()
    {
        Console.WriteLine("P");
    }

}

public class Q : P
{
    void PrintQ()
    {
        P p = new P();
        p.PrintP();
    }

}

public class R
{
    void PrintR()
    {
        P p = new P();
        p.PrintP();
    }

}

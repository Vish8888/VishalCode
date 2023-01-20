class Program
{
    static void Main()
    {
        VIPCustomer vip = new VIPCustomer();

        ((ISilverCustomer)vip).PrintTicket();
        ((IGoldCustomer)vip).PrintTicket();

        vip.PrintS(); // method from silver customer class 
        vip.PrintG(); // method from gold customer class

        Console.ReadLine();
    }
}

abstract class Customer
{
    public abstract void PrintTicket();
}

interface ISilverCustomer
{
    void PrintTicket();
    void PrintS();
}

class SilverCustomer : Customer, ISilverCustomer
{
    public void PrintS()
    {
        Console.WriteLine("Silver class PrintS()");
    }

    public override void PrintTicket()
    {
        Console.WriteLine("Silver Customer Ticket");
    }
}

interface IGoldCustomer
{
    void PrintG();
    void PrintTicket();
}

class GoldCustomer : Customer, IGoldCustomer
{
    public void PrintG()
    {
        Console.WriteLine("Gold Customer PrintG()");
    }

    public override void PrintTicket()
    {
        Console.WriteLine("Gold Customer Ticket");
    }
}

class VIPCustomer : ISilverCustomer, IGoldCustomer
{
    SilverCustomer sc = new SilverCustomer();
    GoldCustomer gc = new GoldCustomer();

    public void PrintG()
    {
        gc.PrintG();
    }

    public void PrintS()
    {
        sc.PrintS();
    }

    void IGoldCustomer.PrintTicket()
    {
        gc.PrintTicket();
    }

    void ISilverCustomer.PrintTicket()
    {
        sc.PrintTicket();
    }
}
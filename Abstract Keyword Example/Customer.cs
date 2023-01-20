public abstract class Customer
{
    public Customer() //-------> Constructor In Abstract Class
    {
        Console.WriteLine("****Welcome to Abhiruchi****");
    }

    public void Showtiming()
    {
        Console.WriteLine("All Shows for Today");
    }

    public abstract int GetTicketAmount();

    public abstract void PrintTicket();
}

public class SilverCustomer : Customer
{


    public override int GetTicketAmount()
    {
        return 150;
    }
    public override void PrintTicket()
    {
        Console.WriteLine("Ticket Printed \t");
    }

}

public class GoldCustomer : Customer
{

    public override int GetTicketAmount()
    {
        return 250;
    }

    public override void PrintTicket()
    {
        Console.WriteLine("Ticket Printed \t");
    }


}

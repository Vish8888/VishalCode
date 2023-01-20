class Program
{
    static void Main()
    {
        Customer c1= new SilverCustomer();
        c1.Showtiming();
        int result = c1.GetTicketAmount();
        c1.PrintTicket();
        Console.WriteLine($"Silver Ticket Amount :{result}");
     
        Customer c2 = new GoldCustomer();
        c2.Showtiming();
        result=c2.GetTicketAmount();
        c2.PrintTicket();
        Console.WriteLine($"Gold Ticket Amount :{result}");
        
/*    Qu- Can we write Constructor in Abstract Class?
      Ans - Yes

 */

        Console.ReadLine();
    }
}

class Program
{
    static void Main()
    {
        CinemaCustomer c1=new CinemaCustomer();
        c1.Showtiming();

        SilverCustomer c2 = new SilverCustomer();
        c2.Showtiming();

        Console.ReadLine();
    }
}

class CinemaCustomer
{

    public void Showtiming()
    {
        Console.WriteLine("All show for today");
    }

}

class Food
{
    public void FoodOrder()
    {
        Console.WriteLine("Order Food");
    }
}

/*class SilverCustomer:CinemaCustomer ,Food (Severity Code    Description Project File    Line    Suppression State
                                           Error   CS1721  Class 'SilverCustomer' cannot have multiple 
                                           base classes: 'CinemaCustomer' and 'Food'   Multiple Class Inheritance	
                                           C:\Users\VISHAL CHIMKAR\source\repos\CSharp\Multiple Class Inheritance\Program.cs	33	Active)
*/


class SilverCustomer : CinemaCustomer
{

    public void Showtiming()
    {
        Console.WriteLine("All show for today");
    }

}
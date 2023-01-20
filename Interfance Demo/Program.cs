class Program
{
    static void Main()
    {
        // ICustomer = new ICustomer(); We cannot create the Insteance/Object of Interface, so we use Interface as Base Class
        ICustomer c1 = new SiverCustomer();//(Base class referance variable [c1] can pointing to derive class[SilverCustomer])
        c1.Print();
        c1.SaveCustomerDetails();
        //_____________________________
        ICustomer c2 = new GoldCustomer();
        c2.Print();
        c2.SaveCustomerDetails();
        //_____________________________

        IFood f1 = new SiverCustomer();
        f1.Orders();
        f1.SaveCustomerDetails();
        //_____________________________
        IFood f2 = new GoldCustomer();
        f2.Orders();
        f2.SaveCustomerDetails();

        /*           ::::::::::::::::::::IMPORTANT INTERVIEW QUESTION::::::::::::::::::::::::::::::::
                 if interviewer ask to call the savecustomerdetail method using derive class the we have to use type casting ex.
                 SiverCustomer sc1 = new SiverCustomer();
                 ((ICustomer)sc1).SaveCustomerDetails();  O/P --- ICustomer SaveCustomerDetails
         */
        Console.ReadLine();
    }
}

interface ICustomer // Always Use a naming-convantion (ICustomer)
{
    public void Print();
    public void SaveCustomerDetails();

    public string FirstName { get; set; }

    // public void PrintFirstName();

    public void PrintFirstName()
    {
        Console.WriteLine($"PrintFirstName()");
    }

}
/*  Interface is a type like a class, it help to achive multiple inheritance in C#
   When we are inheritaing more than one Interfaces, and when thoes interfaces Contains same Methods
   then we can go with 2ed type of Interface which is Expliicite Implimentation

Interface 
-	Interface is a type like class 
-	Interface contains incomplete members like abstract class
-	Interface we use as a base type 
-	We cannot create object of interface 
-	It is mandatory to implement all interface members in derived class 
-	There are two ways to implement interface 
o	Implement interface
o	Implement interface explicitly 
-	We cannot write fields inside interface
-	We cannot write constructor inside interface 
-	Interface members are by default public 
-	We can write property inside interface 
-	We can inherit more than one interfaces 
*/

interface IFood
{
    public void Orders();
    public void SaveCustomerDetails();
}

class SiverCustomer : ICustomer, IFood
{

    private string _firstName { get; set; }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public void Orders()
    {
        Console.WriteLine("Silver Customer Orders");
    }

    public void Print()
    {
        Console.WriteLine("Silver Customer");
    }


    void ICustomer.SaveCustomerDetails()
    {
        Console.WriteLine("ICustomer SaveCustomerDetails");
    }

    void IFood.SaveCustomerDetails()
    {
        Console.WriteLine("IFood SaveCustomerDetails");
    }



    //public void SaveCustomerDetails()----------------------- this is normal implimentation
    //{
    //    Console.WriteLine("Siver Customer SaveCustomerDetails");
    //}
}

class GoldCustomer : ICustomer, IFood
{
    private string _firstName { get; set; }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public void Orders()
    {
        Console.WriteLine("Gold Customer Orders");
    }

    public void Print()
    {
        Console.WriteLine("Gold Customer");
    }

    public void SaveCustomerDetails()
    {
        Console.WriteLine("Gold Customer SaveCustomerDetails");
    }




}
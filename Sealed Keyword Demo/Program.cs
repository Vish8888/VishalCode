class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Print();

        Employee e = new Employee(); 
        e.Print();



/*
                    :::::::::::::Sealed keyword::::::::::::
        if we want to make the such a class which can not allows Inheritance for that we use "SEALED keyword"
        sealed class we cant not iherit it, Compiler will show an Error:"Cannot derived form sealed type"
         if we wnat to use Sealed keyword with method then the method must be Overriden.it is mandetory,
         we can not use Sealed keyword with virtul or abstrack method
*/

        Console.ReadLine();
    }
}

 class Person
{
    //public sealed virtual void Print()  --------->// we can not use Sealed keyword with virtul or abstrack method
    public virtual void Print()
    {
        Console.WriteLine("Person");
    }

    public void PrintA()
    {
        Console.WriteLine("Person PrintA()");
    }

}
class Employee : Person
{
    public sealed override void Print()
    //public override void Print()
    {
        Console.WriteLine("Employee");
    }
}

//class PermanentEmployee : Employee
//{
//    public override void Print()
//    {
//        Console.WriteLine("PermanentEmployee");
//    }
//}
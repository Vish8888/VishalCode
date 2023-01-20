class Program
{
    static void Main()
    {
        //Person p1 = new Person();
        //Employee e1 = new Employee();
        //Person p2 = new Employee();
       
        Employee e1= new Employee("God morning");
        Console.ReadLine();
    }

}

class Mammals
{
    public Mammals()
    {
        Console.WriteLine("Mammals() Called");
    }

}

class Person //: Mammals
{

    public Person()
    {

        Console.WriteLine("Person() Called");
    }


    public Person(string Massage)
    {

        Console.WriteLine("Person(strig massage ) Called");
    }
}

class Employee : Person // here employee is a derived Class and  Person is a Base class
{

    //public Employee()
    //{
    //    Console.WriteLine("Employee() Called");
    //}

    public Employee( string Massage):base(Massage)
    {
        Console.WriteLine("Employee(string Massage) Called");
    }


}

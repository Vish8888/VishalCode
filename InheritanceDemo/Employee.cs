class Employee:Person
{
    public int EmployeeID;
    public string CompanyName;

    public new void PrintFullName()
    {
        Console.WriteLine($"Name:{Firstname}{Lastname} Employee");
    }

    public void Details()
    {
        Console.WriteLine($"*****EmployeeDetails******\n" +
            $"First Name: {Firstname}\n" +
            $"Last Name: {Lastname}\n" +
            $"EmoloyeeId: {EmployeeID}\n"+
            $"CompanyName: {CompanyName}\n");
    }
}


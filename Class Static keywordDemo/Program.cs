class Progam
{
    static void Main()
    {
        Student.CourseName = "DotNet";
        Student s1 = new Student()
        {
            Firstname = "Anil",
            Lastname = "Rathod",
            //CourseName = "DotNet"
        };
        s1.Details();

        Student s2 = new Student();
        s2.Firstname = "Akash";
        s2.Lastname = "Dighade";
        //s2.CourseName = "Dotnet";
        s2.Details();

        Student.Print();
        Country.Name = "India";
        Console.WriteLine(Country.Name);

        Console.ReadLine();
    }

}

class Student
{
    public string Firstname;
    public string Lastname;
    public static string CourseName;  // -----> Static Means Single Copy of object (Static Fild/Instence of student)
                                      // ----->  we can make static member if that member is not object specific.
                                      // ----->  Static member we can not access using object

    public static void Print()
    {
        Console.WriteLine($"Print Method");
    }

    public void Details()
    {
        Console.WriteLine($"**********Details********\n" +
            $"FirstName:{Firstname}\n" +
            $"LastName:{Lastname}\n" +
            $"CourseName :{CourseName}\n");
    }
}

static class Country
{
    public static string Name;
}
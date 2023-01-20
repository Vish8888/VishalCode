using System.Globalization;

class Student
{
    public string Firstname;
    public string Lastname;
    public static string Course;
    //public Student()
    //{
    //    //Console.WriteLine("Constructor Called"); 
    //    Firstname = "Vhassh";
    //    Lastname = "Tech";
    //}

    public Student() { } //--> Prameterless / Default Constructor.

    public Student(string fn, string ln) //---> Parameterised Constructor
    {
        Firstname = fn;
        Lastname = ln;
    }

    public Student(Student s) //---> this is nothing but copy constructor,Bcoz is copy all parameter of method.
    {
        Firstname = s.Firstname;
        Lastname= s.Lastname;
    }

    //public Student(string fn, string ln) //---> Using "this" Keyword
    //{
    //    this.Firstname = Firstname;
    //    this.Lastname = Lastname;
    //}


    public void FullName()
    {

        Console.WriteLine($"FullName: {this.Firstname} {this.Lastname}");

    }
    public void Initalize(string fn, string ln)
    {
        Firstname = fn; Lastname = ln;
    }

    
// Static Constructor,
// Purpose of Static Constructor is to Initalize Field
    static Student()
    {
        Course = "Dotnet";
        Console.WriteLine($"Static Student Called");
    }


}


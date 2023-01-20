class Program
{
    static void Main()
    {
        ///summary
        /// class is a custom complex data type
        ///class contain menber like , field , constructor, distructors, methods,properties.

        Console.WriteLine("Main Start");
        //s1 is a referance variable of type student,finding to object student
        Student s1 = new Student();
        s1.Firstname = "Anil";
        s1.Lastname = "Rathod";
        s1.PrintFullName();
        s1.Details();

        Student s2 = new Student();
        s2.Firstname = "Akash";
        s2.Lastname = "Dighade";
        s2.PrintFullName();
        s2.Details();

        //Calling With Obeject Initializer Syntax
        Student s3 = new Student(){Firstname = "Prashant", Lastname= "Malule"}; //<--------Obeject Initializer Syntax
        s3.PrintFullName();
        s3.Details();
        Console.WriteLine("Main End");

        Student s4 = new Student()//<-------- Using Obeject Initializer Syntax
        {
            Firstname ="Mayuri",
            Lastname="Deshpande",
            Email ="Mayuri@gmail.com",
            Mobile =8888837315
        };
        s4.Details();
        Console.WriteLine("--------------------------");

        Student s5 = new Student() {Firstname= "Snehal", Lastname="Jadhav",
        Email ="Snehal@gmail.com",Mobile=8486848684};
        s5.Details();



        Console.ReadLine();
    }

}

class Student
{
    public string Firstname;  //---->Class Fields declaring with public access specifier,which is always private.
    public string Lastname;   //---->Class Fields
    public string Email;      //---->Class Fields
    public long Mobile;       //---->Class Fields

    public void PrintFullName()
    {
        Console.WriteLine($"FullName: {Firstname} {Lastname}");
    }

    public void Details()
    {
        PrintFullName();
        Console.WriteLine($"********Details*************\nFirstname : {Firstname}\n"+
            $"\nLastName : {Lastname}\n" +
            $"\nEmail : {Email}\n"+
            $"\nMobile : {Mobile}\n"
            );
      
    }
   
}
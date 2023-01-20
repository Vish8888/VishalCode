using static System.Console;

class Program
{
    static void Main()
    {
        // WriteLine(Student.CourseName);

        Student s1 = new Student();
        s1.FirstName = "Anil";
        s1.LastName = "Rathod";
        // s1.CourseName = "Dot Net";
        s1.Print();

        // Student.CourseName = "Java";

        Student s2 = new Student();
        s2.FirstName = "Anil";
        s2.LastName = "Pawar";
        // s2.CourseName = "Java";
        s2.Print();

        Student s3 = new Student("Python");
        s3.FirstName = "Akash";
        s3.LastName = "Ade";
        s3.Print();

        ReadLine();
    }
}

class Student
{
    public string FirstName;
    public string LastName;
    // public static string CourseName = "Dot Net";
    // public const string CourseName = "Dot Net";

    /* Const Keyword- if we wnat to keep a single value through the program then we use "Const Keyword".
     * it is mandetory to initialize tha value for const keyword at the time of decleartion
     * we can not change value of condt field anywhere in program.
     * by deafult const field is access as Static field it means we need to access const field using class name.
     */

    // public static readonly string CourseName = "Dot Net";

    public readonly string CourseName = "Dot Net";
    /* readonly Keyword- if we wnat to keep a single value through the program then we use "readonly Keyword".
     * it is not mandetory to initialize tha value for readonly keyword at the time of decleartion
     * we can change value of readonly field onec in constructor only.
     * by deafult, readonly field is not Static field.
     */

    public Student()
    {
        CourseName = "Java";
    }
    public Student(string cn)
    {
        CourseName = cn;
    }

    public void Print()
    {
        //CourseName = "Data Science";

        WriteLine($"{CourseName} : {FirstName} {LastName}");
    }
}
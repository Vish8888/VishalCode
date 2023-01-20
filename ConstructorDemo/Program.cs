
class Program
{
    static void Main()
    {
        //Student s1= new Student(); // <----Here- Constructor Called Automatically
        //s1.Firstname = "Sachin";
        //s1.Lastname = "Chavan";
        //s1.FullName();

        //Student s2 = new Student() {Firstname="Akash",Lastname="Dighade"}; //->Object Initiallizer Syntax
        //s2.FullName();

        //Student s3 = new Student();
        //s3.Initalize("Suraj", "Jadhav");// <----Here- Constructor Called Automatically
        //s3.FullName();

        Student s4 = new Student("Kay be", "Lavdy"); // <----Here- Constructor Called Automatically
        s4.FullName();

        //Student s5 = new Student("Akash","Dighade1");// <----Here- Constructor Called Automatically
        //s5.FullName();

        Student s6 = new Student(s4);
        s6.FullName();

        Console.ReadLine();
    }
}
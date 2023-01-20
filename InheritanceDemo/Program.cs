class Program
{
    static void Main()
    {
        //Student s1 =  Student() { Firstname = "Anil", Lastname = "Rathod" };
        //s1.new PrintFullName();
       //------------------- Employee Details
        Employee e1 = new Employee();
        e1.Firstname = "Akash";
        e1.Lastname = "Dighade";
        e1.EmployeeID = 420;
        e1.CompanyName = "V#";
        e1.Details();
        e1.PrintFullName();

        //------------------- Student Details
        Student s2 = new Student();
        s2.Firstname = "Prashant";
        s2.Lastname = "Murmure";
        s2.RollNumber= 6;
        s2.CollegeName = "AAO or JAO College";
        s2.StudentDetail();
        
        //------------------Celebrity Details----
        Celebrity c1= new Celebrity();
        c1.Firstname = "Sunny";
        c1.Lastname = "Leonye";
        c1.Industry = "Chavat";
        c1.VistiExpances="50Lakh";
        c1.CDetails();
        Console.WriteLine("-------------------");
        Person p1 = new Employee() { Firstname="Anil",Lastname="Rathod"};
        p1.PrintFullName();

        Person p2 = new Person() { Firstname = "Anil", Lastname = "Rathod" };
        p2.PrintFullName();//

        Employee e2= new Employee() { Firstname="Vishal",Lastname="Chimkar"};
        e2.PrintFullName();
    }
}
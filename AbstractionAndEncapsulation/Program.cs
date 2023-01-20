using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        /*        Abstraction
        - What to show outside of class or assembly
        -	Showing necessary data to the world it is abstraction
        -	What?
        -	Design phase
        
        Encapsulation
        -	How to hide from outside class or assembly 
        -	Hiding irrelevant data from the world
        -	How?
        -	Implementation phase
        
        Abstraction is achieved with the help of encapsulation
          In coding we implement abstraction, encapsulation 
        -	Using access specifiers(Ex.public, private, internal, protected) 
        -	Using abstract class or interface
        */

        //Student s1 = new Student();
        //s1.FirstName = "Anil";
        //s1.LastName = "Rathod";
        //s1.Print();

        Student s1 = new Student("Anil", "Rathod");
        s1.Print();

        Student s2 = new Student("","");
        s2.Print();
      


        Console.ReadLine();
    }
}

class Student
{
    private string FirstName;
    private string LastName;

    private bool isValidData()
    {
        return !string.IsNullOrEmpty(FirstName)
            && !string.IsNullOrEmpty(LastName);
    }

    

    public Student(string firstName , string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Print()
    {
       
        if (isValidData())
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        else
        {
            Console.WriteLine("Please Check Data");
        }
    }

}
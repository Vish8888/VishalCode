class Program
{
    static void Main()
    {
     

        Person p1= new Employee();  //------> Abstract class Person object pointing to the derive class Employee class 
        p1.PrintSpeciality();

        Person p2= new Student();
        p2.PrintSpeciality();


        Console.ReadLine();
    }

}

public abstract class Person
{
    /*            ::::::::::::Abstract Class & Abstract Method::::::::::::::::::
          When we create a abstract method it is mandetory, 
          1) to Write that method in Abstract class,
          2) Also We have to make that method as abstract
          3) Abstract method dosent have body.
          4) abstract class can contain Abstract and Non-Abstract Method.
          5) we can not create the object of Abstract class
          6) abstrct class can use as base class
          7) if any class is inheriting Abstract class then that class needs to override all the abstract member of abstract class
          [NOTE: if any class Inheriting to a abstract class its mandetory to impliment all abstract Members
                Else Compiler will give an error:Does not implimented inherited abstract member]

                      :::::::::::::::Difference between virtual method & abstract method?:::::::::::::::::::::::::::::
            o	Virtual method we can write inside abstract or non abstract class whereas abstract method we can write only inside abstract class 
            o	Virtual method can have body whereas abstract method doesn’t have body 
            o	It is not mandatory to override virtual method whereas it is mandatory to override abstract method 
*/

    public abstract void PrintSpeciality();
}

public class Employee:Person
{
    public override void PrintSpeciality()
    {
        Console.WriteLine("PrintSpeciality");
    }
}

public class Student:Person
{
    public override void PrintSpeciality()
    {
        Console.WriteLine("Student");
    }

}
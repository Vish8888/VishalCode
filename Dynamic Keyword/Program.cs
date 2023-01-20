using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {

        #region Object Keyword
        /*      int v1 = 10;            this are type safe,  accept data from same data type
                char v2 = '$';
                double v3 = 15.5;
                Student v4 = new Student();
                v4.Print();
        */

        //object v1 = 10;
        //v1 = "Vishal";
        //object v2 = '$';
        //object v3 = 15.5;
        //object v4 = new Student();
        // v4.Print();

        /*object v1= new { FirstName ="Anil",LastName ="Rathod"} Anoymous Type */
        #endregion

        #region Var Keyword
        /*      //_________--__--__--__--__--Var Keyword--__--__--__--__--
                *//*                   var keyword
                            -It is introduced for anonymous types
                            -It is a implicit typed local variable
                            -Var keyword checks type at compile time
                            -Var we can use with only local variables
                            -we can not use "Var" with class field
                            -it is must to initialize the value for var type variable.
                            - we can not assing "Null" to var
                *//*
                //var v1 = new { FirstName = "Anil", LastName = "Rathod" };
                //Console.WriteLine(v1.FirstName);
                //Console.WriteLine(v1.LastName);

                var v1 = 10; // after this line v1 is int type
                // v1 = "Vishal"; after this line v1 is int type i.e type safe      -	Var keyword checks data type at compile time
                var v2 = '$';// after this line v2 is char type
                var v3 = 15.5;// after this line v3 is double type
                var v4 = new Student();// after this line v4 is of type Student
                v4.Print();
        */
        #endregion

        #region Dynamic Keyword

        //        Dynamic keyword
        //-It checks type at runtime
       
            ;
        dynamic v1 = 10;
        dynamic v2 = '$';
        dynamic v3 = 15.5;
        dynamic v4 = new Student();
        v4.Print();

        #endregion


        Console.ReadLine();
    }
}

class Student
{
    public void Print()
    {
        Console.WriteLine("Hello");
    }

}
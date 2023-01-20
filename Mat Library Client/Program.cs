//using Library2.Libraryv2;
//using l1 = Library1;
//using l2 = Library2.Libraryv2; //---using Nested Namespaces

class Program
{
    static void Main()    {

        /*        normally we can not execute this calculator beacues we can not
                Refere the math library. for that we have to add the math library to class program
                which is console app
        */
        //Calculator c1 = new Calculator();  // Calling form Library1
        //int result = c1.Sub(10, 20);
        //Console.WriteLine( result);

        /* if we trying to Make object of both Calculator class then there will be a Ambiguious method
         Compiler will confused to call Bcoz both class having same Method with same name.
        so we can not use "Namesapces"

        for that we can use Fully Qualified Namae
        i.e Fulll Name of Library
        (NOTE: if Library Name is too log then we can Use Allias For it) */


        #region Fully Qualified Name

        //Library1.Calculator c1 = new Calculator();  // Calling form Library1
        //int result = c1.Add(10, 20);
        //Console.WriteLine(result);

        //Library2.Calculator c2 = new Calculator();  // Calling form Library2
        //result = c2.Sub(10, 20);
        //Console.WriteLine(result);
        #endregion


        #region With Allias instated of Fully Qualified Name

        l1.Calculator c1 = new l1.Calculator();  // Calling form Library1
        int result = c1.Add(10, 20);
        Console.WriteLine(result);

        l2.Calculator c2 = new l2.Calculator();  // Calling form Library2
        result = c2.Sub(10, 20);
        Console.WriteLine(result);

        #endregion

        Utility u = new Utility();
        result = u.GetOtp();
        Console.WriteLine(result);
        /* here in Utility calss we dont need to declare "Using Utility" which is class name
         in C# .net6.0 it already declared the Globle namespace */

      



        Console.ReadLine();

        /* if we dont write "Namespace there will be a globlenamespace, 
         Name will same like Project name*/
    }
}
delegate void SampleDelegate();
delegate void SamDelegate(string s);
delegate int SampleDelegate1(int a, int b);
class Program
{
    static void Main()
    {
        /* :::::::::::::::::::::::::Delegate Summary:::::::::::::::::::::::::::::::
                -	Type safe function pointer
                -	Function pointer means delegate can point to a function
                -	Type safe means delegate signature and method signature should be same,
                    then we can pass the method as parameter to Delegates
                - We can create Delegate usnig delegate keyword  

               ::::::::Use of Delegates:::::::::::::::::::::::
                o	Using delegate we can pass method as a parameter
                o	Using delegate we can implement callback function/Method
                o	Using delegate we can implement loosely coupled architecture 

                ::: Types of Delegates:::
                1)Singlecast delegate
                              o	Delegate pointing to a single method
                2) Multicast delegate
                              o	Delegate pointing to multiple methods 

         Customer c1 = new Customer();   
        SampleDelegate d1 = new SampleDelegate(c1.PrintA); 
        this is syntax to access delegates
        To access delegate method first we have to create the insteance using Class Name
        then we can write the delegate syntax.
         */

        Customer c1 = new Customer();   
        SampleDelegate d1 = new SampleDelegate(c1.PrintA);  //------> here method PrintA is accessed
        c1.PrintB(d1);                                      //----->Sinnglecast Delegate is pointing to a single method

        SampleDelegate1 d2 = (c1.Add);
        int re = d2(10, 20);
        Console.WriteLine(re);

      

        SampleDelegate a1 = new SampleDelegate(Print1);
        SampleDelegate a2 = new SampleDelegate(Print2);
        SampleDelegate a3 = new SampleDelegate(Print3);
       SampleDelegate a =  a1+ a2+ a3;
        a();

        SamDelegate a4 = Print4;
        a4("Vishal");

    

        Console.ReadLine();
    }

    static void Print1()
    {
        Console.WriteLine("Print1() called");
    }     
    static void Print2()
    {
        Console.WriteLine("Print2() called");
    }     
    static void Print3()
    {
        Console.WriteLine("Print3() called");
    }    

    static void Print4(string s)
    {
        Console.WriteLine($"Print4 :{s}");
    }
}

class Customer
{
    public void PrintA()
    {
        Console.WriteLine("PrintA()");
    }

    /* public void PrintB(PrintA a)  
   {
       we can pass method as a parameter ,it is not possiable with out delegates( in general way we can not provide method as parameter

        *ERROR: Severity	Code	Description	Project	File	Line	Suppression State Error	CS0246	The type or namespace name
        *'PrintA' could not be found (are you missing a using directive or an assembly reference?)
       Console.WriteLine();
   }*/

    public void PrintB(SampleDelegate a)    
    {
       // Console.WriteLine($"Calling form PrintB :{a} \n");
        a();
    }

    public int Add(int a, int b) // When we are creating delegates of return type method we have to provide same arugment as method 
    {
        return a + b;
    }
}



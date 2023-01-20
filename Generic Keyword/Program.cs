using System.Runtime;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        /*       ::::::::::G Summary:::::::::::::::::::
               by using Polymorphis we can overload the Method,but we have to write the new mwthod everytime fort that we have GENERIC Keyword
              When we use Object type(Object is base class for all data type) there are chances of Boxing and unboxing

                      Resaon to use Generic Keyword
              Type Safe,  Avoid Boxing and Unboxing, Allow to create Decoupled datatype i.e able to create class, method, interface
               

           ::::::::::::::::::::Generic Keyword Summary::::::::::::::::::::::::::::::::::::::::::::::
            Object Type is not TypeSafe,We can not use an Oject type in in coding, It might create Ambiguity, instate
            using Generaic keyword we can create ,1)Generic Class, 2)Generic Method,3) Generic Interface
            Generic is decoupled form data type, [decoupled Meaning not work for single/individual datatype]
       Generic Kyword Dosent Support Constructor or we can not write generic constructor in non-Generic class 

           */

        Calculator c1 = new Calculator();
        bool b1 = c1.AreEqual(10, 10);
        Console.WriteLine(b1);

        b1 = c1.AreEqual("ABC", "ABC");
        Console.WriteLine(b1);

        //b1 = c1.AreEqual( 123, "ABC");
        //Console.WriteLine(b1);
        Calculator c2 = new Calculator();
        b1 = c2.AreEqual<int>(10, 10);
        Console.WriteLine($"Generic-I: {b1} ");

        b1 = c2.AreEqual<string>("Vishal", "Akash");
        Console.WriteLine($"Generic-S: {b1} ");

        c1.Add<int>(10, 10);                    //O/P - 20
        c1.Add<float>(100.25f, 10.021f);        //O/P-110.270996
        c1.Add<double>(100545.00, 1054682.215); //O/P-1155227.215

        Student<string, float, int> s1 = new Student<string, float, int>();
        s1.PrintA("Hello");

        //string result = s1.PrintB("Vishal");
        //Console.WriteLine($"For PrintB :{result}");

        float result = s1.Add(10.05f, 20.15f);
        Console.WriteLine($"Addition for T2 :{result}");


        //Student1<int, float, string> s2 = new Student1<int, float, string>();
        //int s = s2.Akash(30, 20);
        //Console.WriteLine(s);


        //Student1<int, int, string> x1 = new Student1<int, int, string>();
        //long r1 = x1.GetSum<int, long>(10, 10);
        //Console.WriteLine($"Prashant :{r1}");

        Student1<int, long, long> y1 = new Student1<int, long, long>(10);
        long o = y1.GetSum<int, long>(45, 646465464646465);
        Console.WriteLine();


        Console.ReadLine();
    }
}

class Calculator
{


    public bool AreEqual(int a, int b)
    {
        return a.Equals(b);
    }
    public bool AreEqual(string a, string b)
    {
        return a.Equals(b);
    }


    public bool AreEqual<T>(T a, T b)
    {
        return a.Equals(b);
    }

    public void Add<T>(T a, T b)
    {
        dynamic n1 = a;
        dynamic n2 = b;
        Console.WriteLine(n1 + n2);
    }

}


class Student<T1, T2, T3> // this class is generic only for 3 Type <T1-->string, T2-->int, T3-->string>
{
    public void PrintA(T1 a)
    {
        Console.WriteLine(a);
    }

    public T3 PrintB(T1 a)
    {
        dynamic result = $"Welcome,{a}";
        return result;
    }

    public T2 Add(T2 a, T2 b)
    {
        dynamic a1 = a;
        dynamic a2 = b;
        dynamic add = $"Addition is : {a1 + a2}";
        return add;

    }



}

class Student1<T1, T2, Prashant>   //<T1=int,T=2 long, Prashant=long>
{
    ////////////////public T1 RollN;

    ////////////////public Student1(T1 rn)
    ////////////////{
    ////////////////    RollN = rn;
    ////////////////}

    public T1 Akash(T1 a, T1 b)
    {
        dynamic b1 = a;
        dynamic b2 = b;
        dynamic s = b1 + b2;
        return s;
    }

    public Prashant GetSum<T1, T2>(T1 a2, T2 b2) //<T1=int,T=2 long, Prashant=long>
    {

        dynamic x = a2;
        dynamic y = b2;
        return x + y;
    }

    public void Add(int f1, int f2)
    {
        int j = f1 + f2;
        Console.WriteLine(j);
    }
}

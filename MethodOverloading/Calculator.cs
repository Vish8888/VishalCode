class Program
{
    static void Main()
    {
        Calculator C1 = new Calculator();
        C1.Add(10);
        C1.Add(20, 30);
        C1.Add(20, 30, 40);
        C1.Add("Vishal");
        C1.Add(45.554f, 50);
        C1.Add(10, 20);



        Console.ReadLine();
    }

}
class Calculator
{

    public void Add(int a) //method overloading With single parameter
    {
        Console.WriteLine($"Add : {a}");
    }

  

    public void Add(int a, int b)//method overloading With two parameter
    {
        Console.WriteLine($"Add : {a + b}");
    }

    public void Add(int a, int b, int c) //method overloading With three parameter
    {
        Console.WriteLine($"Add : {a + b + c}");
    }

    public void Add(string a) //method overloading With Diffrent datatype
    {
        Console.WriteLine($"Add : {a}");
    }

    public void Add(float a, int b) //method overloading With Diffrent datatype
    {
        Console.WriteLine($"Add : {a + b}");
    }

    //public void Add(ref int a, ref int b) //method overloading With Ref keyword
    //{
    //    Console.WriteLine($"Add ref : {a * b}");
    //}

    public void Add(out int a) //method overloading With out 
    {
        a = 20;
        Console.WriteLine($"{a}");
    }
    //we can not overload a method in the basis of "return type" and " ref and out keyword"

}
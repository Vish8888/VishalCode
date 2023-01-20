using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        PrintA(10,20);  //O/P=30 both aurgment are given
        PrintA(10);     //O/P=90  one argument is given for a=10 and b is optional parameter
        PrintB();     //O/P=130  here both argument are optional
        PrintC(b: 80);  //O/P= 80 

        Console.ReadLine();
    }
    #region Optional Parameter
    static void PrintA(int a, int b=80)
    {
        Console.WriteLine($"{a}+{b}={a+b}");
    }
    
    static void PrintB(int a = 50, int b = 80)
    {
        Console.WriteLine($"{a}+{b}={a + b}");
    }
    #endregion

    #region Optional Attribute
    static void PrintC([Optional]int a, int b)
    {
        Console.WriteLine($"{a}+{b}={a + b}");
    }
    #endregion
}
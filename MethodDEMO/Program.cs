class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Start");
        PrintA();

        string r1=PrintB();
        Console.WriteLine(r1);

        PrintC("Vishal"); 

        Console.WriteLine("Main End");
        Console.ReadLine();
    }
        #region Method
   /// <summary>
   /// Mothod does not have return type.
   /// </summary>
    static void PrintA()
    {
        Console.WriteLine("Print A Method");

    }

    //Method has returns type and no parameter

    static string PrintB()
    {
        Console.WriteLine("Print B Method");
        return "Hello from Print B";
    }


    //method has NO return type and hhas parameter
    static void PrintC(string name)
    {
        Console.WriteLine($"Hello, {name} ");
    }

    //method has return type and parameter
    //static int PrintD(string name)
    //{
    //    Console.WriteLine(name.Length);
    //}
    #endregion


}
class Program
{
    static void Main()
    {

       //int result= Add(10, 20);
       // Console.WriteLine(result);

        int a = 10, b = 20, Add, Sub,Mul, Div;
        Operation(a, b, out  Add, out  Sub, out Mul, out  Div);
        Console.WriteLine($"Add : {Add}");
        Console.WriteLine($"Add : {Sub}");
        Console.WriteLine($"Mul : {Mul}");
        Console.WriteLine($"Div : {Div}");
        Console.ReadLine();

    }

    //static int Add(int a, int b)
    //{
    //    int add = a + b;
    //    return add;
    //}

    static void Operation(int a, int b, out int Add, out int Sub, out int Mul, out int Div)
    {
        Add = a + b;
        Sub = a - b;
        Mul = a * b;
        Div = a / b;
    }
}
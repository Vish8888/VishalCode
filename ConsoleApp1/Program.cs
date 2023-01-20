using System.Security.Cryptography.X509Certificates;

class program
{
    static void Main()
    {
        Byte v1 = 10;
        Console.WriteLine(v1);
        Console.WriteLine($" byte Size : {sizeof(byte)} Minimum ={byte.MinValue} Maximum={byte.MaxValue} ");

        short v2 = 100;
        Console.WriteLine(v2);
        Console.WriteLine($" short Size : {sizeof(short)} Minimum ={short.MinValue} Maximum={short.MaxValue} ");

        int v3 = 1000;
        Console.WriteLine(v3);
        Console.WriteLine($" Int Size : {sizeof(int)} Minimum ={int.MinValue} Maximum={int.MaxValue} ");

        long v4 = 10000;
        Console.WriteLine(v4);
        Console.WriteLine($" long Size : {sizeof(long)} Minimum ={long.MinValue} Maximum={long.MaxValue} ");

        float v5 = 10000.025f;
        Console.WriteLine(v5);
        Console.WriteLine($" Float Size : {sizeof(float)} Minimum ={float.MinValue} Maximum={float.MaxValue} ");

        double v6 = 120000;
        Console.WriteLine(v6);
        Console.WriteLine($" double Size : {sizeof(double)} Minimum ={double.MinValue} Maximum={double.MaxValue} ");

        decimal v7 = 10000.4542m;
        Console.WriteLine(v7);
        Console.WriteLine($" decimal Size :  {sizeof(decimal)}  Minimum = {decimal.MinValue}  Maximum= {decimal.MaxValue} ");

        bool v8 = true;
        Console.WriteLine(v8);
        Console.WriteLine($" bool Size : {sizeof(bool)}");

        char division = 'A';
        Console.WriteLine(division);
        Console.WriteLine($" char Size : {sizeof(char)}");

        //var division1 = 'A';
        //Console.WriteLine(division1);
        //Console.WriteLine($" var Size : {sizeof(var)}");

        string name = "Vishal";
        Console.WriteLine(name);

        string S1 = "Vishal";
        Console.WriteLine(S1);

        Console.ReadLine();
       

        
    }

}
class Program
{
    static void Main()
    {
        int i = 1;

        for (i=0; i<=20; i+=2)
        {
            if (i == 10 && i == 12)
            {
                break;
                //continue;
            }
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}
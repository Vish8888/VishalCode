class Prgram
{
    static void Main()
    {
        #region Swap Two Number
        //Console.WriteLine("Please Enter first Number");
        //int a = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Please Enter Second Number");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"first Number:{a} \nSecond Number:{b}");

        ////int c = a; //using Third Vaariable
        ////a = b;
        ////b= c;
        ////a=20 ; b=10
        //a = a + b;// a=20 +10=30
        //b = a - b;// b= 30-10=20
        //a = a - b;// a=30-20=10

        //Console.WriteLine($"first Number:{a} \nSecond Number:{b}");

        #endregion
        string choice = "";
        do
        {
            
            Console.WriteLine("Please Enter first Number");
            int num = Convert.ToInt32(Console.ReadLine());
            isPrime(num);
            Console.WriteLine("Do you want to continue");
            choice = Console.ReadLine().ToUpper();
        } while (choice== "Y" || choice == "YES");

        Console.ReadLine();
    }

    static void isPrime(int num) 
    {
       
        bool IsPrime = false;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                IsPrime = true;
                break;
            }
        }
        if (IsPrime)
        {
            Console.WriteLine($"{num} is not a Prime number");
        }
        else
        {
            Console.WriteLine($"{num} is Prime Number");
        }
    }
}
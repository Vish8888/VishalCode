class Program
{
    static void Main()
    {
        /*   ::::::::::::::Exception ::::::::::::::::::::
         *   Exception is  a runtime Error, it is not good for user
         *   normal use will not be able to understand the error,he mau not visit the site again
         *   o	Smart user may use error information to hack site 
         *   
       :::::::::::::We need to handle exception because:::::::::::::::
        o	When exception occurs program gets terminated / break 
        o	Irrelevant information gets shown to end user

                        Exception handling 
                -	We use try catch block to handle exception 
                -	Exception class 
                o	Exception class is base class for all exception classes in dot net 
                o	We have many exception classes like
                1)	FormatException
                2)	InvalidCastException
                3)	OverflowException
                4)	NullReferenceException
                5)	IndexOutOfRangeException
                6)	DivideByZeroException
                7)	ArgumentNullException Etc.......... we can use such class in Exception handling to get more information about that error.
             
  */
        string choice = "";
        do
        {
            try
            {
                Console.WriteLine("Please Enter a Numerator");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter a Denomenetor");
                int j = Convert.ToInt32(Console.ReadLine());

                int Div = i / j;

                Console.WriteLine($"Your Answer is: {Div}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            Console.WriteLine("Do you want to continue");
            choice= Console.ReadLine().ToUpper();
        }while(choice== "Y"||choice== "YES");

        Console.WriteLine("Thank You Visit Again Bhenchod");

        Console.ReadLine();
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a Numbar");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine($"You Entered: {input}");

        #region if-else ladder 
        //if (input == 10)
        //{
        //    Console.WriteLine("Ten");
        //}
        //else if(input == 20)
        //{
        //    Console.WriteLine("Twenty");
        //}
        //else if(input == 30)
        //{
        //    Console.WriteLine("Thirty");
        //}
        //else
        //{
        //    Console.WriteLine("Wrong Input");
        //}
        #endregion

        #region Turnary Operator
        //    string result = (input == 10) ? "TEN" : "NOT TEN";
        //Console.WriteLine(result);      //<------- Turnary Operator

        #endregion

        #region Switch Statement
        switch (input)
        {
            case 10:
                Console.WriteLine("TEN");
                break;
            case 20:
                Console.WriteLine("Twenty");
                break;
            case 30:
                Console.WriteLine("Thirty");
                break;
            default:
                Console.WriteLine("Wrong Input");
                break;
        }
        #endregion

        Console.ReadLine();
    }

}
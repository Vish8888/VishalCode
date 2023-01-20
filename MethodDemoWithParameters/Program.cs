class Program
{
    static void Main()
    {
        int[] n = { 10, 20, 30 };
        PrintSum(n);

        PrintSum(new int[] { 10, 20, 30 });// inserting Array by using array syntax
        ///we can write give arry as parameter  in "PrintSum Method"

        int[] n2 = null;
        PrintSum(n2);

        PrintSum(null); 

        PrintSum(20, 30, 40); // by using params keyword we can directly put array values into Argument 
                              // without declearing array syntax
        Console.ReadLine();
    }

    static void PrintSum(params int[] Numbers)
    {
        if (Numbers != null && Numbers.Length > 0)
        {
            int sum = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += Numbers[i];
            }
            Console.WriteLine($"Sum is:{sum}");
        }
        else
        {
            Console.WriteLine("Array is Empty");
        }
    }
}
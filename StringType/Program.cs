class Program
{
    static void Main()
    {
        string firstName = "Vishal";
        Console.WriteLine(firstName);
        //string firstNameInUpper = firstName.ToUpper();
        //Console.WriteLine(firstNameInUpper);


        Console.WriteLine(firstName.ToUpper());
        Console.WriteLine(firstName.ToLower());

        Console.WriteLine(firstName.Reverse());
        Console.WriteLine(firstName.Length);

        firstName = "   Anli    ";
        Console.WriteLine(firstName.Trim());
        Console.WriteLine(firstName.TrimEnd());


        Console.ReadLine();
    }

}
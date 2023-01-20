class Program
{
    static void Main()
    {
       
        Program p1 = new Program();
        p1.Get();

        Console.ReadLine();
    }
    string Get()
    {
        string result = string.Empty;
        try
        {
            result = "Try";
            return result;
        }
        catch
        {
            result = "Catch";
            return result;
        }
        finally
        {
            result = "finally";
/* 
 
 */
        }
    }
}
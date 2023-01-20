class Celebrity : Person
{
    public string Industry;
    public String VistiExpances;

    public void CDetails()
    {

            Console.WriteLine($"********Celebrity Details\n" +
            $"First Name: {Firstname}\n"+
            $"Last Name: {Lastname} \n"+
            $"Industry: {Industry}\n" +
            $"VisitExpancess:{VistiExpances}\n");
    }
}

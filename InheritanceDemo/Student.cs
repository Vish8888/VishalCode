class Student:Person
{
    public int RollNumber;
    public string CollegeName;

    public void StudentDetail()
    {
        Console.WriteLine($"*****Student Details******\n" +
            $"First Name: {Firstname}\n" +
            $"Last Name: {Lastname}\n" +
            $"RollNumber: {RollNumber}\n"+
            $"CollegeName: {CollegeName}\n");
    }
}

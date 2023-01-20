class Program
{
    static void Main()
    {

    
        Student s1 = new Student();
        s1.FirstName = "Jonhy";
        s1.LastName = "Bhaiya";
       // s1.Gender = 1;
      s1.Gender=Gender.Male;

        Console.WriteLine($"First Name: {s1.FirstName}\n" +
            $"Last Name: {s1.LastName} \n" +
            $"Gender: {Gender.Male}");

        Student s2 = new Student();
        s2.FirstName = "Sunny";
        s2.LastName = "Bhabhi";
       // s2.Gender = 2;
       s2.Gender=Gender.Female;

        Console.WriteLine($"First Name: {s2.FirstName}\n" +
            $"Last Name: {s2.LastName} \n" +
            $"Gender: {Gender.Female} \n");

        Type t =Enum.GetUnderlyingType(typeof(Subject));
        Console.WriteLine($"UnderlyingType :{t.Name}");

        string [] names=Enum.GetNames(typeof(Subject));
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"{names[i]}  \n");
        }

        int[] values = (int[])Enum.GetValues(typeof(Subject));
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write($"{values[i]} ");
        }


        Console.ReadLine();
    }

    static string GetGender(int gender)
    {
        switch (gender)
        {
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Unknown";
        }

    }
}




class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public  Gender Gender { get; set; }

}

/*
 ::::::::::::::::::::Enumaration:::::::::::::::::::::::::::
Enum is a good repalcment of Integral Constant
it improve readability & Maintainbility
we declare Enum By using Small "e" and Capital E is Enum Class
by default Enum type is intigral

Enum Class
Enum Class is used ti get more informatin about any enum type
Ex- defalult UnderlyingType is intigral, but we can customize Enum Integral type out of(byte, int , short , long)
 */

enum Gender
{
    Male, Female
}

enum Subject 
{
    Marathi=10, Hindi=20, English, Mathematics, chemistry, physics =60 //After hindi all  subject values are Auto Incremented O/P=10,20,21,22,23,60
}
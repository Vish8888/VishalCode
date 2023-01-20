using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        #region Code1
        //Student s1 = new Student(); // here we are setting the values in field
        //s1.RollNumber = 1;
        //s1.Name = "Test";
        //s1.PassMark = 10;

        //Console.WriteLine($"RollNumber:{s1.RollNumber}" +  // we are reading the values from fields
        //    $"Name :{s1.Name}" +
        //    $"PassMark :{s1.PassMark}");
        #endregion

        #region Code2
        //Student s1 = new Student(); // here we are setting the values in field
        ////s1.SetRollNumber(-1); 
        //s1.SetRollNumber(1);
        ////s1.SetName(null); // if name null then while display it should show "No Name"
        //s1.SetName("Mahesh");
        ////s1.PassMark = 22; // we should not be able to change the value.

        //Console.WriteLine($"RollNumber:- {s1.GetRollNumber()} \t" +  // we are reading the values from fields
        //    $"Name:- {s1.GetName()} \t" +
        //    $"PassMark:- {s1.GetpassMark()}");
        #endregion

        Student s1 = new Student(); // here we are setting the values in field
        s1.RollNumber = 1;
        s1.Name = "Vishal";
        // s1.PassMark = 10;
        s1.City = "Pune";

        Console.WriteLine($"RollNumber:- {s1.RollNumber} \t" +  // we are reading the values from fields
            $"Name:- {s1.Name}\t" +
            $"PassMark:- {s1.PassMark}\t" +
            $"City:- {s1.City}");

        Console.ReadLine();
    }
}


/*class Student
{
    private int _rollNumber; *//* By deafult class fields are Private we can not access it by using object, for that we have to make them public *//*
    private string _name;
    private int _passMark=40;

    public int GetRollNumber()
    {
        return _rollNumber;
    }
    public void SetRollNumber(int rn)
    {
        if (rn > 0)
        {
            _rollNumber = rn;
        }
        else {

            Console.WriteLine("Rollnumber can not be negative");
        }

    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return string.IsNullOrEmpty(_name) ? "No Name" : _name;
    }

    public int GetpassMark()
    {
        return _passMark;
    }
}*/

#region Using Property
/// <summary>
/*                    Property 
                -We use to encapsulate and protect private fields
                -Before property we had getter and setter methods
                -	There was less readability and maintainability with getter and setter methods
                -	Property we write like a method and access like a public field
                -We have 2 access modifiers in property
                o	get – it executes when we read property 
                o	set – it executes when we assign value to property
                -	property types:
                o read only property (only get access modifier)
                o write only property (only set access modifier)
                o read write property (get & set both access modifiers)
                -auto implemented property*/
/// </summary>  
class Student
{
    private int _rollnumber;
    private string _name;
    private int _passmark = 40;
    private string _city;
    public int RollNumber
    {
        get
        {
            return _rollnumber;
        }
        set
        {
            if (value > 0)
            {
                _rollnumber = value;
            }
            else
            {
                Console.WriteLine("Rollnumer can not be empty or negative");
            }
        }
    }

    public string Name
    {
        get
        {
            return string.IsNullOrEmpty(_name) ? "No Name" : _name;
        }
        set
        {
            _name = value;
        }
    }

    public int PassMark
    {
        get
        {
            return _passmark;
        }
    }

    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }

    public string Email { get; set; }
}

#endregion
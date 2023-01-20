class Program
{
    static void Main()
    {


        Student[] students = new Student[]
        {
        new Student(){ RollNumber = 101, Name = "Vishal", City = "Pune"},
        new Student(){ RollNumber = 102, Name = "Mahesh", City = "Mumbai"},
        new Student(){ RollNumber = 103, Name = "Dipak", City = "Pune"},
        new Student(){ RollNumber = 104, Name = "Shital", City = "Pune"},
        new Student(){ RollNumber = 105, Name = "Snehal", City = "Mumbai"}
        };

        Institute i1 = new Institute(students);

        string name = i1[101];
        Console.WriteLine(name);

        i1[105] = "Priyanka";  //seting value
        name = i1[105];   // reading values
        Console.WriteLine(name); //getting values

        Student s = i1["Vishal"];
        Console.WriteLine($"{s.RollNumber} : {s.Name} : {s.City}");



        Console.ReadLine();
    }
}

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}

class Institute
{
    public string InstituteName { get; set; }
    private Student[] _students;

    public Institute(Student[] students)
    {
        _students = students;
    }

    public string this[int rn]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    return _students[i].Name;
                }

            }
            return $"Student not Found by Rollnumber{rn}";
        }

        set
        {

            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    _students[i].Name = value;
                }

            }

        }
    }

    public Student this[string name]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Name==name)
                {
                    return _students[i];
                }
            }
            return null;
        }
    }


}
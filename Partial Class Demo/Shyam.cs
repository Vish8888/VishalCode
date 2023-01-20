partial class Student
{
  public int RollNumber { get; set; }

    public string Name { get; set; }

    partial void PrintS();
}

interface IA
{
    void Print();
}

interface IB
{
    void Print();
}
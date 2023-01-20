class Program
{
    static void Main()
    {
        A c1 = new C(); c1.Print();// B
        //A c2 = new D(); c2.Print();//
        //B c3 = new C(); c3.Print();//

        Console.ReadLine();
    }

}
class A
{
    public virtual void Print()
    {

        Console.WriteLine("Calling A");
    }
}

class B:A
{
    public override void Print()
    {

        Console.WriteLine("Calling B");
    }
}

class D:C
{
    public new void Print()
    {

        Console.WriteLine("Calling D");
    }
}

class C:B
{
    public override void Print()
    {

        Console.WriteLine("Calling C");
    }
}
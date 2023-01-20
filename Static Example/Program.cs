class Program
{
    static void Main()
    {
       
        Circle c1= new Circle();
        c1.redius = 5;
        //c1.Pi = 3.145f;
        c1.Ares();

        Circle c2 = new Circle();
        c2.redius = 10;
        //c2.Pi = 3.145f;
        c2.Ares();

        Console.ReadLine();
    }

    class Circle
    {
        public int redius;
        public static float Pi =3.14f;

        public void Ares()
        {
            Console.WriteLine($"Area of Circle having Redius {redius} : {Pi*redius*redius}cm^2");
        }
    
    
    }
}
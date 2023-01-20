

class Program
{
    static void Main()
    {
        /* ::::::::::::::::::Partial Class Summary::::::::::::::::::::::::::::
       
        -	Partial means part or incomplete Class
        -	Using partial keyword we can split a class into multiple physical files
        -	In Partial Class very part should marked with partial keyword
        -	On build all parts gets merged and creates a final resultant class 
        -	If any one part marked with public then the final class will become public 
        -	We cannot mark one part with abstract another part with sealed in Partial method
        -	We can write partial method only inside partial class(abstract having same feature,)
        -	Using partial method we can split a method in two parts
        -IMP:If we do not provide implementation for any partial method, compiler removes its declaration as well as all its calls.
        	Due to following reason
        	Partial method is always private, we cannot specify any other access specifier with partial method
        	Partial method always has void as a return type 

       
        !!!!!!!!!!!Declaration & implementation !!!!!!!!!!!!!!
        -	Partial method implementation is optional 
        -	Partial method cannot be public, it is always private 
        -	Partial method does not have return type, its return type is always void 
           
        [NOTE:By default, partial methods are implicitly private, so no access modifiers are allowed, and they cannot be virtual. 
            Partial methods can have ref but not out parameters. Partial methods can be static and generic, but it can not be Public]
         */

        Student s1 = new Student();
        s1.RollNumber = 1;
        s1.Name = "Shyam";

        Console.ReadLine();
    }

}
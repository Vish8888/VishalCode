
class Program
{
    static void Main()
    {
        int i = 10;
        //        Value type & reference type

        //         ***   Value type  ***
        //        -   for ex.Int, long, bool etc
        //        -   in case of memory allocation, actual value gets stored on stack
        //       -  when value type variable goes out of scope it will get removed from stack


        //          *** Reference type ***
        //- for ex.String, array, object, class etc..
        //- in case of memory allocation, actual value actual data gets stored on heap and its reference will get stored on stack
        //-when reference type variable goes out of scope its reference will get removed from stack but,
        //its value in heap will remain there, which will get removed further by garbage collector

        //____________________________________________________________________________________
        i++;
        Console.WriteLine(i);
     
        object o = i;                   //int => object          //        ***Object type***
        Console.WriteLine(o); //------------>                    //boxing = conversion of value type to reference type
                                                                 //-object type is base type for all types in dot net
                                                                 //- it is reference type
        int j = (int)o; //---------------->                      //unboxing = conversion of reference type to value type
        Console.WriteLine(j);                                    //both operations are not good for performance.
               







        Console.ReadLine();
    }

}
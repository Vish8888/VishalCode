//namespace Library2;

/*Here we are using Nested Namespaces*/

namespace Library2
{
    public class Calculator
    {
        /*   here we can not directly add Class With Same name,it might create Ambiugity
           for that we have to specify it with "Namespaces" -Library2
            Namespaces we can Use to 
            1) Organize the Code
            2) To avoid Type Name Clashesh
        */
        public int Sub(int a, int b)
        {
            return a - b;
        }

    }

    namespace Libraryv2
    {
        public class A
        {

        }
    }
}
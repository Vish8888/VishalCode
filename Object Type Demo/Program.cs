/*using System.Numerics;*/

using System.Numerics;
using System;

namespace Vishal
{
    class Program
    {
        static void Main()
        {
            #region ToString(), GetType()
            ///summary
            /*        Object type
            -it is a base type for all types in dot net
            - we get methods from object class
            */
            ///
            //bool b1 = true;/* --> o1 is a object type vairable*/
            //Console.WriteLine(b1.ToString());

            //Type bt1 = b1.GetType();
            //Console.WriteLine(bt1.GetType());
            //Console.WriteLine(bt1.Name);
            //Console.WriteLine($"\n");   /*to show O/Parallel on next Line*/
            ////-----------------------------------------

            //int i1 = 10;
            //Console.WriteLine(i1.ToString());
            //Type it1 = i1.GetType();
            //Console.WriteLine(it1.GetType());
            //Console.WriteLine(it1.Name);
            //Console.WriteLine($"\n");  /*to show O/Parallel on next Line*/
            ////________________________________________

            //string s1 = "Vishal";
            //Console.WriteLine(s1);
            //Type st1 = s1.GetType();
            //Console.WriteLine(st1.GetType());
            //Console.WriteLine(st1.Name);
            //Console.WriteLine($"\n");  /*to show O/Parallel on next Line*/
            ////------------------------------------------------------

            //Student s2 = new Student("Anil", "Rathod");
            //Console.WriteLine(s2.ToString());
            //Type st = s2.GetType();
            //Console.WriteLine(st.GetType());
            //Console.WriteLine(st.FullName);  /*O/P =Vishal.Student*/
            //Console.WriteLine($"\n");  /*to show O/Parallel on next Line*/

            //Student s3 = new Student("Rahul", "Rathod");
            //Console.WriteLine(s3.ToString());
            #endregion

            #region Equal() 
            /*            o Equals method()
            	We use this method for comparison like ==, != operator
            	In case of complex type Equals() method check for reference equality and not value equality,
                we need to override Equals() method
            */
            /*int i = 10;
            int j = i;
            if (i== j)
                {
                    Console.WriteLine("i & j are Equal");
                }
            else
            {
                Console.WriteLine("i & j are Not Equal");
            }

            *//*   using Equals() Method*//*
            string x = "Vishal";
            string y = "Vishal";
            if (x.Equals(y))
            {
                Console.WriteLine("x & y are Equal");
            }
            else
            {
                Console.WriteLine("x & y are Not Equal");
            }   */

            #endregion

            #region GetHashCode

/*            ****** GetHashCode() *********
            	To check hashcode for value
            	We need to override this method to maintain unique hashcode for complex type object 

            if we declear two variable ,can we compair it?
            yes by using 
            int a = 10, b = 20;
            bool b1 = a==b; it  give correct in normal type but not in complex type
            b1= a.Equals(b);
            b1 =a.GetHashCode()==b.GetHashCode(); 
*/

            int i = 10;
            Console.WriteLine(i.GetHashCode());

            string s1 = "Vishal";
            Console.WriteLine(s1.GetHashCode()); // s1 & s2 both are giving same HashCode i.e = 401241767 when "string s2 = s1;
                                                 // string s2 = s1;
            string s2 = "Vishal"; /// different HashCode
            Console.WriteLine(s2.GetHashCode());


            #endregion

            Console.ReadLine();
        }  
    }
}

namespace Vishal
{
    class Student
    {
        string firstname;
        string lastname;

/*               ToString()
    	This method we use to represent value in string format
    	In case of complex type it returns type name
    	If we want meaningful string representation of any complex type object we can override this ToString() method
*/


        public Student(string fn, string ln)
        {
            Console.WriteLine($"{fn} {ln}");
        }

        public override string ToString()
        {
            return firstname + " " + lastname;
        }

        public void Print()
        {

        }
    }
}
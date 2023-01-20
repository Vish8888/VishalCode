
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main()
    {
        #region  Array
        //Array is a colletion of similar Data-type,array size is fixed, it can not grow automatically
        // array is type safe.it ask for same data type only.
        //int[] years = new int[2];
        //years[0] = 2020;
        //years[1] = 2021;

        //Console.WriteLine(years.Length);

        //for (int i =1; i <= years.Length; i++)
        //{
        //    Console.WriteLine(years[i]);
        //}
        #endregion

        #region Single Array
        //string[] car = new string[5] { "TATA", "Mahendra", "BMW", "Audi", "Volvo" };
        ////Console.WriteLine(car.Length);//-5

        //for (int i = 0; i < car.Length; i++)
        //{
        //    Console.WriteLine(car[i]);
        //}



        //string[] names = new string[] { "Mahesh", "Sartaj", "Shyam", "Shakti" };
        //Console.WriteLine(names[0]);
        //Console.WriteLine(names[1]);
        //Console.WriteLine(names[2]);
        //Console.WriteLine($"{names[3]} \n");

        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.Write($"{names[i]} \n");
        //}
        #endregion

        #region EVEN & ODD Number

        //int[] Numbers = new int[] { 1, 2, 3, 7, 11, 13, 17, 19, 23, 4, 55, 5, 7, 6, 4, 77, 88, 99 };

        //for (int i = 0; i < Numbers.Length; i++)
        //{

        //    if (Numbers[i] % 2== 0)
        //    {
        //        Console.WriteLine($"{Numbers[i]}:Even");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Numbers[i]}:Odd");
        //    }
        //}
        //Console.WriteLine("Array End");
        #endregion

        #region Sort Higest Number
        //int[] nums = { 105, 45, 21, 78, 55, 75 };
        //int highestNum = 0;

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    highestNum = nums[i];
        //    for (int j = 0; j < nums.Length; j++)
        //    {
        //        if (nums[i] == nums[j])
        //            continue;

        //        if (nums[j] > highestNum)
        //        {
        //            highestNum = nums[j];
        //        }

        //    }
        //    Console.WriteLine($"highestNum is : {highestNum}");
        //}
        #endregion

        #region Bubble Sort
        int[] arr = { 78, 55, 45, 98, 13 };
        int temp;
        for (int j = 0; j <= 4; j++)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        Console.WriteLine("Sorted:");
        foreach (int p in arr)
            Console.Write( p+ " ");

        #endregion

        #region String Concat
        //string s1 = "Akash";
        //string s2 = "Dighade";
        //string s3 = string.Join("_", s2, s1);
        //string s4 = string.Format($"{s1} \" \" {s2}");
        //Console.WriteLine(s3);
        //Console.WriteLine(s4);
        #endregion

        #region Multidimentional Array

        //string[,] names =
        //{
        //     { "Mahesh", "M"},
        //     {"Praksh","P"},
        //     {"Vikas","V"}
        // };

        // for (int i=0; i< 3; i++)    //i = controls Row
        // {
        //     for (int j = 0; j < 2; j++)    //j = controls Coloumn
        //     {
        //         Console.Write($"{names[i, j]}  ");
        //     }
        //     Console.WriteLine();
        // }
        #endregion

        #region Digonal Element addition
        //int[,] num =
        //{{11,12,13 },
        // {21,22,23 },
        // {31,32,33 }
        //};
        //int sum = 0;

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {

        //        if (i == j)
        //        {
        //            Console.WriteLine(num[i, j]);
        //            sum += num[i, j];
        //        }
        //        Console.Write($"{num[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine(": Sum : " + sum);
        #endregion






        Console.ReadLine();
    }
}
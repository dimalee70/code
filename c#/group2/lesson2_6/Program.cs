using System;

namespace lesson2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass m = new myClass();
            m.arr = new string[]{"dfsf"};
            int [] arr = {1,2,3,5,6};

            
            // for(int i = 0; i < arr.Length; i++)
            // {
            //     System.Console.WriteLine(arr[i]);
            // }

            // foreach(int t in arr)
            // {
            //     System.Console.WriteLine(t);
            // }

            System.Console.WriteLine(myArr<int>(6));

            System.Console.WriteLine
            (returnGeneric<string>("Hello"));


             System.Console.WriteLine
            (returnGeneric<int>(6));


             System.Console.WriteLine
            (returnGeneric<bool>(true));

            // Console.WriteLine("Hello World!");
        }

        public static int myArr<T>(T a)
        {
            return 4;
        }

        public static T returnGeneric<T>(T a)
        {
            return a;
        }
    }
}

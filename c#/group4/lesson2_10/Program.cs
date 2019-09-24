using System;
using System.Collections.Generic;

namespace lesson2_10
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> myList = new List<int>();
            // do
            // {
            //     System.Console.WriteLine("hello");
            //     return;
            // }
            // while(true);

            while(true)
            {
                System.Console.WriteLine("Enter the number");
                int i = Convert.ToInt32(Console.ReadLine());
                if(i == -1) 
                    break;
                myList.Add(i);
            }



            // for(int i = 0; i < 10; i++)
            // {
            //     if(i % 2 == 0)
            //         break;
            //     System.Console.WriteLine(i);
            // }

            Action<List<int>> myFunc = 
                new Action<List<int>>(sum);

            myFunc += minus;
            myFunc += multiply;
            myFunc += divide;

            myFunc(myList);
        }

        public static void sum(List<int> list)
        {
            int s = 0;
            for(int i = 0; i < list.Count; s += list[i++]);
            System.Console.WriteLine(s);
        }

        public static void minus(List<int> list)
        {
            int s = 0;
            for(int i = 0; i < list.Count; s -= list[i++]);
            System.Console.WriteLine(s);
        }

        public static void multiply(List<int> list)
        {
            int s = 1;
            for(int i = 0; i < list.Count; s *= list[i++]);
            System.Console.WriteLine(s);
            return;
        }

        public static void divide(List<int> list)
        {
            int s = 100000;
            for(int i = 0; i < list.Count; s /= list[i++]);
            System.Console.WriteLine(s);
        }
    }
}

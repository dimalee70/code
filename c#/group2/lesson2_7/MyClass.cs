using System;
namespace lesson2_7
{
    public class MyClass
    {
        public static void increment(ref int t)
        {
            t++;
        }

        public static void decrement(ref int t)
        {
            t--;
        }

        public static string returnGeneric<T>(T arg)
        {
            return arg.ToString();
        }

        public override string ToString()
        {
            return "Hello from MyClass";
        }

        public static string myFunc(int t)
        {

            return "number is " + t;
        }

        public static void Message(string message)
        {
            System.Console.WriteLine("Hello from message");
            System.Console.WriteLine(message);
        }

        public static void descSort(int [] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach(int t in arr)
            {
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
        }

        public static void ascSort(int [] arr)
        {
            Array.Sort(arr);
            foreach(int t in arr)
            {
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
        }
    }
}
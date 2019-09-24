using System;

namespace lesson2_7
{
    delegate void MyDelegate(ref int t);
    delegate string ReturnDelegate<T>(T arg);


    class Program
    {
        static void Main(string[] args)
        {

            Action<int []> sortArr;

            Action<string> action;
            Func<int, string> myFunk;
            ReturnDelegate<MyClass> returnDelegate
            = MyClass.returnGeneric;
            // MyDelegate myDelegate = null; 
            // int t = 5;
            // Console.WriteLine("Enter the number");
            // int answer = 
            // Convert.ToInt32(Console.ReadLine());
            // switch(answer)
            // {
            //     case 1:
            //         myDelegate = 
            //         MyClass.increment;
            //         break;
            //     case 2:
            //         myDelegate = 
            //         MyClass.decrement;
            //         break;
            //     case 3:
            //         myDelegate = 
            //         MyClass.increment;
            //         myDelegate += 
            //         MyClass.decrement;
            //         break;
            // }
            
            // myDelegate(ref t);
            // System.Console.WriteLine(t);
            // if(answer == 3)
            // {
            //     myDelegate -= MyClass.decrement;
            // }
            // myDelegate(ref t);
            // System.Console.WriteLine(t);

            // System.Console.WriteLine
            // (returnDelegate(new MyClass()));

            myFunk = MyClass.myFunc;
            System.Console.WriteLine(myFunk(5));
            action = MyClass.Message;
            action("dsdds");

            sortArr = MyClass.ascSort;
            sortArr += MyClass.descSort;

            sortArr(new int []{6,2,8,1,10,20,55});
            


        }
    }
}

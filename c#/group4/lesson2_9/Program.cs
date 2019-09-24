using System;

namespace lesson2_9
{
    class Program
    {
        public delegate void myDelegate();
        public delegate int Calculator(int a, int b);

        public delegate void print(string text);

        public delegate int returnNum(int t);
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Enter the text");
            // System.Console.WriteLine("Enter the number");
            // int a = Convert.ToInt32(Console.ReadLine());
            
            // myDelegate del = new myDelegate(printDefault);
            // switch(a)
            // {
            //     case 1 :
            //         del = new myDelegate(printHello);
            //         break;
            //     case 2: 
            //         del = new myDelegate(printWorld);
            //         break;
            //     case 3:
            //         del = new myDelegate(printName);
            //         break;
            // }

            // del();


            // System.Console.WriteLine("Enter two numbers");
            // int a = Convert.ToInt32(Console.ReadLine());
            // int b = Convert.ToInt32(Console.ReadLine());

            // int op = Convert.ToInt32(Console.ReadLine());

            // Calculator c = new Calculator(summ);

            // switch (op)
            // {
            //     case 1: 
            //         c = new Calculator(summ);
            //         break;
            //     case 2:
            //         c = new Calculator(minus);
            //         break;
            //     case 3: 
            //         c = new Calculator(multiply);
            //         break;
            //     case 4 :
            //         c = new Calculator(divide);
            //         break;
            //     case 5:
            //         c += minus;
            //         c += multiply;
            //         c += divide;

            //         c -= divide;
            //         break;
                
                
            // }

            // c = new Calculator(summ);
            // int result = c(a,b);
            // System.Console.WriteLine(result);


            // string text = Console.ReadLine();

            // print p = delegate(string t)
            // {
            //     System.Console.WriteLine("You word id " + t);
            // };

            // returnNum r = delegate(int t)
            // {
            //     return t + 5;
            // };

            // System.Console.WriteLine(r(a));


            // r = delegate(int t )
            // {
            //     return t - 5;
            // };

            // System.Console.WriteLine(r(a));



            Func<int, int, int> 
                myFunc = new Func<int, int, int>(summ);

            System.Console.WriteLine(myFunc(3,4));
            myFunc += minus;
            System.Console.WriteLine(myFunc(3,4));

            Action
                myAction = new Action(printHello);  

            myAction();

            User u = new User();
            u.Name = "Test";
            u.age = 20;

            Action myPrint = new Action(u.print);

            myPrint();




            // p(text);
        }

        static void printDefault()
            {
                System.Console.WriteLine("Default");
            }
        static void printHello()
        {
            System.Console.WriteLine("Hello");
        }
        static void printWorld()
        {
            System.Console.WriteLine("World");
        }
        static void printName()
        {
            System.Console.WriteLine("Name");
        }

        static int summ(int a, int b)
        {
            System.Console.WriteLine("sum");
            return a+b;
        }

        static int minus(int a,int b)
        {
            System.Console.WriteLine("minus");
            return a - b;
        }

        static int multiply (int a, int b)
        {
            System.Console.WriteLine("miltiply");
            return a*b;
        }

        static int divide (int a , int b)
        {
            System.Console.WriteLine("divide");
            return a/b;
        }



    }
}

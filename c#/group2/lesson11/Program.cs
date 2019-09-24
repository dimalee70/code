using System;

namespace lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            // if(args.Length > 0)
            // {
            //     int t = Convert.ToInt32(args[0]);
            //     int t2 = Convert.ToInt32(args[1]);
            //     System.Console.WriteLine(t+t2);
            // }
            // else
            // {
            //     System.Console.WriteLine("Hi");
            //     PrintHello();
            //     System.Console.WriteLine("End");
            // }
            // string myName = "Dima";
            // PrintHello();
            // PrintHello(myName);
            // PrintHello(25);
            // PrintHello(myName, 25);

            // methodParams(1,2,3,4,5,6,7,9,0,10);


            // int [] myArr = {1,2,4};
            // methodWithoutParams(new int [] {1,23,4,6,78,9});

            // methodWithoutParams(myArr);


            // summ(1,2,3);

            // summ(b:5,c:10);

            // int [] arr2 = {5,1,8,4,10};

            // mySortDesc(arr2);

            // foreach(int t in arr2)
            // {
            //     System.Console.Write(t+" ");
            // }
            // System.Console.WriteLine();


            // int i = 0;
            // increment(ref i);

            // System.Console.WriteLine(i);

            // int t;
            // incrementOut(out t);

            // System.Console.WriteLine(t);


            // returnMethod('q','w','r','e','b','n');

            // string text = returnStringMethod(10);


            // System.Console.WriteLine("Hello " + text);

            printHelloNTimes(5);



        }

        static void PrintHello()
        {
            System.Console.WriteLine("Hello wolrd");
        }

        static void PrintHello(string name)
        {
            System.Console.WriteLine("Hello wolrd, " + name);
        }
        static void PrintHello(int age)
        {
            System.Console.WriteLine("Your age " + age);
        }

        static void PrintHello(string name, int age)
        {
            System.Console.WriteLine($"Hello wolrd, {name}, age {age}" );
        }

        static void methodParams( params int[] arr)
        {
            foreach(int t in arr)
            {
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
        }
        static void methodParams(int ind, params int[] arr)
        {
            foreach(int t in arr)
            {
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Index {ind}");
        }


        static void methodWithoutParams(int[] arr)
        {
            foreach(int t in arr)
            {
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
        }

        static void summ(int a = 1, int b = 2, int c = 3)
        {
            System.Console.WriteLine($"Summ {a+b+c}");
            System.Console.WriteLine(b);
        }

        static void mySortDesc(int [] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            foreach(int t in arr)
            {
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
        }

        static void increment(ref int t)
        {
            t++;
            System.Console.WriteLine(t);
        }


        static void incrementOut(out int t)
        {
            t = 5;
            System.Console.WriteLine(t++);
        }

        static void returnMethod(params char [] arrChar)
        {
            foreach(char c in arrChar)
            {
                if(c == 'e')
                {
                    System.Console.WriteLine();
                    return;
                }
                System.Console.Write(c + " ");
            }
            System.Console.WriteLine();
        }

        static string returnStringMethod(int age)
        {
            string text = "Your age is " + age;
            return text;
        }

        static void printHelloNTimes(int n)
        {
            if(n == 0)
            {
                return;
            }
            System.Console.WriteLine("Hello World");
            printHelloNTimes(--n);
        }

        
    }
}

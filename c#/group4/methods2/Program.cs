using System;

namespace methods2
{
    class Program
    {
        
        static void HelloWorld()
        {
            System.Console.WriteLine("Hello Wolrd");
        }

        static void HelloWorld(string name)
        {
            System.Console.WriteLine("Your name is " + name);
        }

        static void HelloWorld(string name, int age)
        {
            System.Console.WriteLine
            ($"Your name is {name}\nYour age is {age}");
        }

        // static void sum(int a = 1, int b = 2, int c = 3)
        // {
        //     System.Console.WriteLine(a+b+c);
        // }


        static void sum(params int [] arr)
        {
            int s = 0;
            foreach(int i in arr)
            {
                s += i;
            }
            System.Console.WriteLine(s);
        }

        static void sum2(int [] arr)
        {
            int s = 0;
            foreach(int i in arr)
            {
                s += i;
            }
            System.Console.WriteLine(s);
        }
        
        static void refMethod (ref int t)
        {
            t++;
            System.Console.WriteLine(t);
        }

        static void outMethod (out int t)
        {
            t = 12;
            t++;
            System.Console.WriteLine(t);
        }

        static void sumArrBigger5(int [] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (i < 5)
                    sum += arr[i];
                else
                {
                    System.Console.WriteLine(sum);
                    return;
                }
            }
            // foreach(int i in arr)
            // {
            //     if 
            //     sum+=i;
            // }
        }

        static int minus(int a, int b)
        {
            return a-b;
        }

        static string hello()
        {
            return "Hello";
        }

        static int myFact(int f)
        {
            int factorial = 0;
            if(f == 0)
            {
                return factorial;
            }
            
            return factorial += f+myFact(--f);
            
        }

        static int GCD(int a, int b)
        {
            if(b == 0)
                return a;
            return GCD(b, a%b);
        }



        static void Main(string[] args)
        {
            System.Console.WriteLine(myFact(4));

            System.Console.WriteLine(GCD(4,2));
            // if(args == null || args.Length <= 0)
            // {
            //     Console.WriteLine("Hello World!");
            // }
            // else if (args.Length == 1)
            // {
            //     System.Console.WriteLine(args[0]);
            // }
            // HelloWorld();
            // System.Console.WriteLine("Enter your name");
            // string n = Console.ReadLine();
            // int age = Convert.ToInt32(Console.ReadLine());
            // HelloWorld(n);
            // HelloWorld(n, age);

            // sum();
            // sum(5);
            // sum(5,6);
            // sum(5,6,7);
            // sum(b:10);



            // sum(1,2,3,4,5,6,7,8,9,10);
            // sum(1);
            // int [] arr = new int[2];
            // arr.SetValue(0,1);
            // arr.SetValue(1,5);
            // // sum2(new int []{1,2,34,7,6});
            // sum2(arr);

            // System.Console.WriteLine("Hello" + "World");
            // System.Console.WriteLine(10 + 15);


            // int t = 5;
            // refMethod(ref t);
            // System.Console.WriteLine(t);

            // int outT;
            // outMethod(out outT);
            // System.Console.WriteLine(outT);

            // sumArrBigger5(new int []{1,2,3,4,5,6,7,8,9,10});

            // string trim = "Hello ";
            // trim = trim.Trim();

            // int m = minus(5,2);
            // System.Console.WriteLine(m);

            // System.Console.WriteLine(hello());

        }


    }
}

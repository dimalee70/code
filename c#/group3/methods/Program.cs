using System;

namespace methods
{
    class Program
    {


        static void incrementOutValue(out int t)
        {
            t = 5;
            System.Console.WriteLine(++t);
        }
        static void incrementValue(ref int t)
        {
            System.Console.WriteLine(++t);
        }
        static void Main(string[] args)
        {
            // HelloWorld();
            // HelloWorld(Console.ReadLine());

            // string name2 = Console.ReadLine();
            // int age2 = Convert.ToInt32(Console.ReadLine());

            // HelloHuman(name2, age2);

            // printSumm(4);
            // printSumm(1,2,3,4,5,6,7,8);

            // printSumm(new int [] {1,2,3,4,5,6,7,8,9});
            // int [] arr = {1,2,3,4,5,6,7,8,9};
            // printSumm(arr);
            // int sum2 = returnSumm(arr);

            // System.Console.WriteLine("dsfdsfds");
            // System.Console.WriteLine("sdfdsfdsds");

            // System.Console.WriteLine(sum2);

            // int r = 5;

            // incrementValue(ref r);

            // System.Console.WriteLine(r);

            // int r;
            // incrementOutValue(out r);

            // System.Console.WriteLine(r);

            // System.Console.WriteLine(fact(4));


            System.Console.WriteLine(GCD (10, 4));




            
        }

        // static void HelloWorld()
        // {
        //     System.Console.WriteLine("Hello world");
        // }
        // static void HelloWorld(string world)
        // {
        //     System.Console.WriteLine("Hello " + world);
        // }

        // static void HelloHuman(string name, int age)
        // {
        //     System.Console.WriteLine($"Hello, {name}\nyour age is {age}");
        // }

        // static void printSumm(int a = 1, int b = 2, int c = 3)
        // {
        //     System.Console.WriteLine(a);
        //     System.Console.WriteLine(b);
        //     System.Console.WriteLine(c);
        //     System.Console.WriteLine("Summ " + (a+b+c));
        // }

        // static void printSumm(int u , params int [] arr)
        // {
        //     int sum = 0;
        //     foreach(int t in arr)
        //     {
        //         sum += t;
        //     }
        //     System.Console.WriteLine(sum);

        //     System.Console.WriteLine(u);
        // }
        // static void printSumm(int [] arr)
        // {
        //     int sum = 0;
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         sum += arr[i];
        //         if(arr[i] > 5)
        //         {
        //             System.Console.WriteLine(sum);
        //             return;
        //         }
        //     }
        // }

        // static int returnSumm(int [] arr )
        // {
        //                int sum = 0;
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         sum += arr[i];
        //         if(arr[i] > 5)
        //         {
        //             System.Console.WriteLine(sum);
        //             return sum;
        //         }
        //     }
        //     return sum;
        // }

        static int fact(int t)
        {
            int n = 1;
            if(t == 0)
            {
                return n;
            }
            return n *= t * fact(--t);
            // if(t == 1)
            // {
            //     return n;
            // }
            return  n;
        }

        static int GCD(int a, int b)
        {
            if(b == 0)
            {
                return a;
            }
            return GCD(b , a%b);
        }
    }
}

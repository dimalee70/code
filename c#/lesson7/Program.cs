using System;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] arr = {1,2,3,4,5,6,7,8};
            // // string hello = "hello";
            // // for(int i = hello.Length-1; i >= 0; i--){
            // //     System.Console.Write(hello[i] + " ");
            // // }
            // // System.Console.WriteLine();
            // //
            // //Функции и методы
            // System.Console.WriteLine("Hello");
            // int [] t = (int [] )arr.Clone();
            // PrintHello("Dima");
            // PrintHello("323");
            // PrintHello("wdwed");
            // PrintHello("wdefg"); 
            // PrintHello("Eferfr"); 
            // PrintHello("fregg");
            // int t =  Summ(2,3);
            // int w;
            // Increment(out w);
            // System.Console.WriteLine(w);
            // System.Console.WriteLine(SummAll(1,2,3,4,5,6,7,8,9,10));
            // System.Console.WriteLine(SummAllStr("1","2","3","4","5","6","7","8","9","10"));
            //System.Console.WriteLine(Average(a:1,c:3));
            System.Console.WriteLine(t(5));
            // System.Console.WriteLine(SummAllStr("1","2","3","4","5","6","7","8","9","10"));
            // Increment(w);
            // System.Console.WriteLine(w);
            // System.Console.WriteLine(PrintHello("HHefefe"));
            // System.Console.WriteLine(t);
            System.Console.WriteLine(multiply(2,2));
        }

        //Войд метод
        static void PrintHello(string name){
            System.Console.WriteLine($"Hello , {name}");
        }

        //ретэрн метод
        static int Summ(int a,int b){
            return a+b;
        }
        
        //parameter ref
        // static void Increment(ref int q){
        //     q++;
        //     System.Console.WriteLine(q);
        // }
        static void Increment(int q){
            q++;
            System.Console.WriteLine(q);
        }

        static void Increment(out int q){
            q = 5;
            q++;
            System.Console.WriteLine(q);
        }

        //params множественные аргументы
        // static int SummAll(params int [] a){
        //     int sum = 0;
        //     foreach(int t in a){
        //         sum+=t;
        //     }
        //     return sum;
        // }
        // static string SummAllStr(params string [] a){
        //     string sum = " ";
        //     foreach(string t in a){
        //         sum+=t;
        //     }
        //     return sum;
        // }

    //обязательные и необязательные аргументы
    static float Average(int a,int b = 3,int c = 4){
        return ((a+b+c)/3f);
    }

    //рекурсия
    static int t (int a){
        if (a == 0){
            return 0;
        }
        System.Console.WriteLine(a);
        return t(a - 1);
    }
    // static int GCD(int a,int b){
    //     if(b == 0){
    //         return a;
    //     }
    //     return GCD(b,a%b);
    // }


        // public = публичный для всех
        // private = личность класса
        // protected = личность пакета
        static int multiply(int a,int b){
            int mul  = a*b;
            return Sqrt(mul);
        }
        static int Sqrt(int a){
            return (int)Math.Sqrt(a);
        }
    }
}

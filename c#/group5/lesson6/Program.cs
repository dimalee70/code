using System;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            // if(args.Length > 0)
            // {
            //     string t = args[0];
            //     System.Console.WriteLine(t);
            // }
            // Console.WriteLine("Hello World!");
            // hello();
            // printName();
            // string n = "Aslan";
            // printName("Dima");
            // printName(n);

            // System.Console.WriteLine("Enter the name");
            // string name = Console.ReadLine();
            // System.Console.WriteLine("Enter the age");
            // int age = Convert.ToInt32(Console.ReadLine());

            // printInfo(name, age);


            // Sum();
            // Sum(5);
            // Sum(5,6);
            // Sum(5,6,7);
            // Sum(b: 7);

            // Multiply(1,2,34,5,67,8,9);

            // MultiplyWithoutParams(new int[]{1,2,4,6,7,8});

            // int t = 5;
            // methodRef(ref t);
            // System.Console.WriteLine(t);

            // int t = 20;
            // printOut(out t);
            // System.Console.WriteLine(t);

            // int.TryParse()

            // returnVoid();

            // int we = sum(4,4,1);

            // System.Console.WriteLine(we);

            //System.Console.WriteLine(fact(5));
            //System.Console.WriteLine(fraction(10,20));
            int [] arr = {1,4,2,10,13};
            resArr(ref arr);

            for(int i=0; i<arr.Length; i++)
                System.Console.Write(arr[i]+" ");
            System.Console.WriteLine();    
        }

        public static int GCD(int a, int b)
        {
            if(b == 0)
                return a;
            return GCD(b, a%b);
        }
        
        public static void resArr(ref int []arr){
             for(int i=0; i<arr.Length; i++){
                 for(int j=0; j<arr.Length-1; j++){
                     if(arr[j]<arr[j+1]){
                         int temp = arr[j];
                         arr[j]=arr[j+1];
                         arr[j+1]=temp;
                     }
                 }
             }

        }

        public static string fraction(int numer, int dnumer){
            int x = Func(numer, dnumer);
            numer/=x;
            dnumer/=x;
            return (numer+"/"+dnumer);
        }
        public static int Func(int numer, int dnumer){
            if(dnumer == 0)
                return numer;
            return Func(dnumer, numer%dnumer);    
        }
        public static int fact(int n){
            if(n==1)
                return 1;
            else    
                return n*fact(n-1);   
        }
        public static int sum(int a, int b, int op)
        {

            if(op == 1)
                return a+b;
            return a-b;
               
        }


        static void hello()
        {
            System.Console.WriteLine("hello");
        }

        public static void printName()
        {
            System.Console.WriteLine("NoName");
        }

        public static void printName(string name)
        {
           System.Console.WriteLine("Your name is " + name);
        }

        public static void printInfo(string name, int age)
        {
            System.Console.WriteLine("Your name is " + name 
                +"\nYou are " + age );
        }

        public static void Sum(int a = 1, int b = 2, int c = 3)
        {
            System.Console.WriteLine("a = " + a);
            System.Console.WriteLine("b = " + b);
            System.Console.WriteLine("c = " + c);
            System.Console.WriteLine(a+b+c);
            System.Console.WriteLine();
        }

        public static void Multiply(int t, params int [] arr)
        {
            int mult = 1;
            for(int i = 0; i < t; i++)
            {
                mult*= arr[i];
            }

            System.Console.WriteLine(mult);
        }

        public static void MultiplyWithoutParams(int [] arr)
            {
                int mult = 1;
                foreach(int t in arr)
                {
                    mult *= t;
                }
                System.Console.WriteLine(mult);
            }

        
        // private
        //protected

        public static void methodRef(ref int t)
        {
            t++;
            System.Console.WriteLine(t);
        }

        public static void printOut(out int t)
        {
            
            t = 10;
            System.Console.WriteLine(t);
        }

        public static void returnVoid(int t = 5)
        {
            if(t == 5)
                return;
            System.Console.WriteLine(t);
        }
    }


}

using System;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            // printArgs(args);
            // if(args.Length > 0){
            //     helloName(args[0]);
            // }else{
            //     printHello();
            // }
            // Console.WriteLine("Hello World!");
            // printHello();
            // string n = "Victor";
            // helloName(n);

            // System.Console.WriteLine("Enter the name");
            // string name = Console.ReadLine();
            // System.Console.WriteLine("Enter the age");
            // int age = Convert.ToInt32(Console.ReadLine());
            // printInfo(name, age);

            // sum(b:20);
            // sumParams(40, 1,2,3,4,5,6);
            // sumParams(10, 20 ,12 ,1 ,2, 3,4,5);
            // sumParams(1,2,3,4,5);

            // string text = "    dddd  Hello my name is Dmitriydddffffd";
            // text = text.Trim('d', ' ', 'f');
            // text = text.Trim(' ');
            // System.Console.WriteLine(text);

            // int numArg = 10;
            // incremetnByOne(ref numArg);
            // System.Console.WriteLine(numArg);
            // incremetnByOne(ref numArg);
            // System.Console.WriteLine(numArg);

        
            // int n = 10;
            // int num;
            // initialize(ref n, out num, 5);
            // System.Console.WriteLine(n);
            // System.Console.WriteLine(num);

            // int resultMethodSum = sum(20, 30);
            // System.Console.WriteLine(resultMethodSum);

            // int[] arr = {9,8,7,1,2,3,4};
            // printArray(arr);
            // int [] arrFromMethod = sortReverse(arr);
            // printArray(arrFromMethod);
            // printArray(arrFromMethod, 3);

            // System.Console.WriteLine("Hello " + 10);
            // System.Console.WriteLine(10 + 20);

            // double [] doubleArray = {1.2, 2.3, 3.4, 5.6, 7.8};
            // printArray(doubleArray);

            // int gcd = GCD(25, 100);
            // System.Console.WriteLine($"GCD = {gcd}");
            // while(true){
            //     System.Console.WriteLine("Enter the number of day");
            //     int day = Convert.ToInt32(Console.ReadLine());
            //     if(day < 0)
            //         break;
            //     System.Console.WriteLine(printDay(day));

            // string name = null;

            // int? age = null;
            // char? c = null;

            DateTime dateTime = DateTime.Now;
            System.Console.WriteLine(dateTime);

            DateTime today = DateTime.Today;
            System.Console.WriteLine(today);

            DateTime date = new DateTime(2018, 12, 26);
            // System.Console.WriteLine(date - DateTime.Now);

            System.Console.WriteLine(date.ToString("yyyy-MMMM-dd HH:mm:ss"));




        }

        static int GCD(int a, int b){
            if(b == 0)
                return a;
            return GCD(b, a%b);
        }

        static string printDay(int num){
            switch(num){
                case 1:
                    return "Mon";
                case 2: 
                    return "Tue";
                case 3: 
                    return "Wed";
                case 4: 
                    return "Thur";
                case 5: 
                    return "Fri";
                case 6:
                    return "Sat";
                case 7: 
                    return "Sun";
            }
            return "error";
        }

        static void printArray(int [] arr, int limit){
            for(int i = 0; i < arr.Length; i++){
                if(i == limit)
                    break;
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
        }
        static void printArray(int [] arr){
            foreach(var item in arr){
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }

        static void printArray(double [] arr){
            foreach(var item in arr){
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }

        static int sum(int a, int b){
            int sum = a + b;
            return sum;
        }

        static int[] sortReverse(int [] arr){
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }
        static void printInfo(string name, int age){
            if(age <= 0)
                return;
            System.Console.WriteLine($"Your name is {name}"+
            $"\nYour age is {age}");
        }

        // static void initialize(ref int n, out int num, int m){
        //     n += m;
        //     num = n + m;
        // }

        // static void incremetnByOne(ref int number){
        //     number++;
        //     System.Console.WriteLine(number);
        // }

        // static void printHello(){
        //     System.Console.WriteLine("Hello from method");
        // }

        // static void helloName(string name){
        //     System.Console.WriteLine("Hello, " + name);
        // }

     

        // static void printArgs(string[] args){
        //     foreach(var item in args){
        //         System.Console.WriteLine(item);
        //     }
        // }
        // static void sum(int a = 1, int b = 2, int c = 3){
        //     System.Console.WriteLine($"a = {a}, b = {b}, c = {c} sum = {a+b+c}");
        // }

        // static void sumParams(int sum, params int [] numbers){
        //     for(int i = 0; i < numbers.Length; sum +=i++);
        //     System.Console.WriteLine($"Sum = {sum}");
        // }



    }
}

using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Enter integer");
            // int myInt = Convert.ToInt32(Console.ReadLine());

            // bool myBool = myInt > 10;
            // if(myBool){
            //     System.Console.WriteLine("Integer bigger than 10");
            // }
            // if(myInt >= 10){
            //     if(myInt < 100)
            //         System.Console.WriteLine("myInt less then 100");
            //     System.Console.WriteLine("Integer bigger than 10");
            //     System.Console.WriteLine("End");
            // }
            // else if(myInt == 10)
            //     System.Console.WriteLine("Integer is equal then 10");
            // else if(myInt == 10)
            //     System.Console.WriteLine("Integer is equal than 10");
            // else{
            //     System.Console.WriteLine("Integer less than ten");
            //     System.Console.WriteLine("ELSE");
            // }

            // int day = 5;

            // switch(day){
            //     case 5:
            //         break;
            //     case 6:
            //     case 4: 
            //         System.Console.WriteLine("четверг");
            //         break;
            //         System.Console.WriteLine("end"); 
            //     default:
            //         System.Console.WriteLine("ELSE");
            //         break;
            // }

            // if(true){
            //     System.Console.WriteLine("dfvdfvfv");
            // }


            // Console.WriteLine("Hello World!");


            // for(int i = 0; i < 5; ++i){
            //     System.Console.WriteLine("Hello "+i);
            // }


            // int i = 5;
            // for(i = 5; i >= 0; i--){
            //     System.Console.WriteLine("Hello "+i);
            // }


            // System.Console.WriteLine(i);


            // for(;;){
            //     System.Console.WriteLine();
            // }

            // int i = 0;

            // for(;i < 5;)
            // {
            //     System.Console.WriteLine(i++);
            // }

            // for(;i < 5;i++)
            // {
            //     System.Console.WriteLine(i);
            // }

            // int sum = 0;

            // for(int i = 0; i < 5; sum += i++);
            // System.Console.WriteLine(sum);

            // for(int i = 0; i < 5;i++){
            //     if(i == 3)
            //         break;
            //     System.Console.WriteLine(i);
            // }

            // for(int i = 0; i < 10;i++){
            //     if(i % 2 == 0)
            //         continue;
            //     System.Console.WriteLine(i);
            // }

            for(int i = 0, j = 10; i < j;i++, j--){
                System.Console.WriteLine(i +" "+ j);
            }
        }
    }
}

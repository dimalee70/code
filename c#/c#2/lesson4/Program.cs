using System;
using System.Collections.Generic;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans;
            Random random = new Random();
            int [] arr = new int [0];
            while(true)
            {
                System.Console.WriteLine("Enter the number ");
                System.Console.WriteLine("1 . Add");
                System.Console.WriteLine("2 . Sort");
                System.Console.WriteLine("3 . Exit");
                Int32.TryParse(Console.ReadLine(),out ans);
                if(ans == 1)
                {
                    int[] arr2 = new int[arr.Length + 1];
                    for(int i = 0; i < arr.Length; i ++){
                        arr2 [i] = arr[i];
                    }
                    arr2[arr2.Length - 1] = random.Next(0,10);
                    arr = arr2;
                    foreach(int t in arr){
                        System.Console.Write(t + " ");
                    }
                    System.Console.WriteLine();

                }
                if(ans == 2){
                    Array.Sort(arr);
                    foreach(int t in arr){
                        System.Console.Write(t + " ");
                    }
                    System.Console.WriteLine();

                }
                if(ans == 3)
                {
                    System.Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Try another number");
                }


            }

            foreach(int t in arr){
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("GoodBye");
            Console.WriteLine("Hello World!");
        }

    
    }
}
 // inherFromAbs inherFromabs = new inherFromAbs();
            // inherFromabs.Hello();
            // inherFromabs.HelloFromAbs();
            // myList ml = new myList();
            // // Array arr = new int[4]{1,2,3,4};
            // // ml.CopyTo(arr,3);
            // myClass mc = new myClass();
            // myClass2 mc2 = new myClass2();
            // mc.Hello();
            // mc2.Hello();
            // // List<string> list = new List<string>();
            // // LinkedList <string> linkedList = new LinkedList<string>();
            // C

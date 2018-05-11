using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // int sum =0;
            // Console.WriteLine("Hello World!");
           
            

            // label1: //creating label with colon(:)
            //     System.Console.WriteLine("Your text");
            //     string text = Console.ReadLine();
            //     if(text == "E" || text == "Exit"){
            //         goto exit;
            //     }
            //     foreach(char c in text){
            //         if(c == ' '){
            //             Console.WriteLine();
            //             continue;
            //         }
            //         System.Console.Write(c);
            //     }
            //     System.Console.WriteLine();
            //     goto label1; 
            // exit:
            //     System.Console.WriteLine("Exit");
            // System.Console.WriteLine("Your number");
            // int t;
            // Int32.TryParse(Console.ReadLine(),out t);
            // for (int i = 0; i <= t/2; i++){
            //     // for (int j = 0; j < t ;j++){
            //     //     System.Console.Write(" ");
            //     // }
            //     for (int j=t/2-i;j<= t/2+i;j++){
            //         System.Console.Write("#");
            //     }
            //     System.Console.WriteLine();
            // }
            
            // int t;
            // Int32.TryParse(Console.ReadLine(),out t);
            // // for (int i = 1; i <= t; sum += i++);
            // for (int i = 1; i <= t;i++){
            //     sum = sum + i;
            // }
              //for (int i = 1; i <= 5; sum += ++i);
            // Console.WriteLine(sum);
            // int t = 5;
            // int [] arr = new int[10];
            // char [] arr2 = {'H','e','l','l','o'};
            // System.Console.WriteLine($"Length = {arr2.Length}");
            Random random = new Random();
            // System.Console.WriteLine($"Length = {arr.Length}");
            // for(int i = 0; i < arr.Length;i++){
            //     arr[i] = random.Next(1,10);
            // }
            // // arr [0] = 6;
            // // arr[1] = 7;
            // // arr [2] = 8;
            // System.Console.WriteLine(arr[1]);
            // for (int i=0; i < arr.Length; i++){
            //     System.Console.WriteLine("Index = {0}, Value = {1}",i,arr[i]);
            // }
            // object[] myarr = {'H',43,23,2.2,"fdfsdfsdf"};
            // foreach(object o in myarr){
            //     System.Console.WriteLine(o);
            // }
            
            // int [,] myarr2 = new int[4,6];
            // myarr2[0,0] = 4;
            // // System.Console.WriteLine(myarr2.Length);
            // // System.Console.WriteLine(myarr2.GetLength(1));
            // // System.Console.WriteLine(myarr2.GetLength(0));
            // for(int i = 0;i < myarr2.GetLength(0);i++){
            //     for(int j = 0;j < myarr2.GetLength(1);j++){
            //         myarr2[i,j] = random.Next(1,10);
            //     }
            // }
            // for(int i = 0;i < myarr2.GetLength(0);i++){
            //     for(int j = 0;j < myarr2.GetLength(1);j++){
            //         System.Console.Write("{0} ",myarr2[i,j]);
            //     }
            //     System.Console.WriteLine();
            // }
            int [,,] dAr = new int[4,6,7];
            for(int i = 0;i < dAr.GetLength(0);i++){
                for(int j = 0;j < dAr.GetLength(1);j++){
                    for(int z = 0 ; z < dAr.GetLength(2);z++)
                    dAr[i,j,z] = random.Next(1,10);
                }
            }
            for(int i = 0;i < dAr.GetLength(0);i++){
                for(int j = 0;j < dAr.GetLength(1);j++){
                    for(int z = 0 ; z < dAr.GetLength(2);z++)
                    System.Console.WriteLine($"Index {i} {j} {z}, Value = {dAr[i,j,z]}");
                }
            }
            int [] ar = new int[10];
            ar.SetValue(10,0);
            int [] ar3 = new int[10];
            System.Console.WriteLine(ar.GetValue(0));
            //var ar2; 
            int [] ar2 = (int [])ar.Clone();
            Array.Copy(ar,ar3,ar.Length);
            System.Console.WriteLine(ar3.GetValue(0));
            // foreach(int i in arr){
            //     System.Console.WriteLine("{0} ", i);
            // }

        }
    }
}
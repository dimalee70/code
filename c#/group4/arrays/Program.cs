using System;

namespace arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
        //     while(true)
        //         {
        //         Console.WriteLine("запишите число от 0 до 5");
        //         int c = Convert.ToInt32(Console.ReadLine());
        //         if (c == 1)
        //         {
        //             Console.WriteLine("запишите любое число");
        //             int n = Convert.ToInt32(Console.ReadLine());
        //             for (int i = 0; i < n; i++)
        //             {
        //                 if (i % 2 == 1)
        //                 {
        //                     Console.WriteLine(i);
        //                 }
        //             }
        //         }
        //         else if (c == 2)
        //         {
        //             Console.WriteLine("запишите любое число");
        //             int sum = 0;
        //             int n = Convert.ToInt32(Console.ReadLine());
        //             for (int i = 0; i < n; i++)
        //             {
        //                 sum += i;
        //             }
        //             System.Console.WriteLine(sum);
        //         }
        //         else if (c == 3)
        //         {
        //             Console.WriteLine("запишите любое число");
        //             int n = Convert.ToInt32(Console.ReadLine());
        //             int m = Convert.ToInt32(Console.ReadLine());
        //             for (int i = 0; i < (n * m + 1); i++)
        //             {
        //                 if ((i % m) == 0 && (i % n) == 0)
        //                 {
        //                     int nok = i;
        //                     if (i != 0)
        //                     {
        //                         Console.WriteLine($"nok ={0}");
        //                     }
        //                 }
        //             }
        //         }
        //         else if (c == 4)
        //         {
        //             Console.WriteLine("запишите любое число");
        //             int n = Convert.ToInt32(Console.ReadLine());
        //             int sum0 = 0;
        //             int sum1 = 0;
        //             for (int i = 1; i <= n; i++)
        //             {
        //                 sum1 += i;
        //             }
        //             for (int j = 0; j <= n; j++)
        //             {
        //                 sum0++;
        //             }
        //             int r = sum1 / sum0;
        //             Console.WriteLine(r / 2);

        //         }
        //         else if (c == 5)
        //         {
        //             Console.WriteLine("Выход");
        //             break;
        //         }

        //     }



            int [] arr;
            int t = 43;
            arr = new int[10];

            int [] tempArr = {1,2,3,5,6,7,8};
            int [] temp = new int[]{1,3,5,6,8};
            // int t
            // arr[0] = t;
            // arr[1] = t;

            // System.Console.WriteLine(arr.Length);

            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10, 100);
            }

            // for(int i = 0; i < arr.Length; i++)
            // {
            //     System.Console.Write(arr[i] + " ");
            // }
            // System.Console.WriteLine();

            // foreach(int a in arr)
            // {
            //     System.Console.Write(a + " ");
            // }

            // System.Console.WriteLine();

            // char [] arrChar = {'d', 's', 'w'};

            // foreach(char d in arrChar)
            // {
            //     System.Console.Write(d + " ");
            // }
            // System.Console.WriteLine();
 
            // // System.Console.WriteLine(arr[0]); 
            // string [] myArrStr = {"dfdf", "dsfw", "efrgr"};

            // for(int i = 0; i < myArrStr.Length; i++)
            // {
            //     System.Console.Write(myArrStr[i] + " ");
            // }

            // foreach(var s in myArrStr)
            // {
            //     System.Console.Write(s + " ");
            // }
            // System.Console.WriteLine();


            int [,] my2DArr = new int[3,5];

            System.Console.WriteLine(my2DArr.Length);

            my2DArr[0,0] = 5;
            
            for(int i = 0; i < my2DArr.GetLength(0); i++)
            {
                for(int j = 0; j < my2DArr.GetLength(1); j++)
                {
                    my2DArr[i, j] = random.Next(0, 50);
                }
                // my2DArr
            }

            for(int i = 0; i < my2DArr.GetLength(0); i++)
            {
                for(int j = 0; j < my2DArr.GetLength(1); j++)
                {
                    System.Console.Write(my2DArr[i, j] + " ");
                }
                System.Console.WriteLine();
                // my2DArr
            }

            // foreach(int r in my2DArr)
            // {
            //     System.Console.WriteLine(r);
            // }

            // int [][] my2DArrT = new int [5][];
            // int [] arr1 = new int [3];
            // my2DArrT[0] = arr1 ;

            // for(int i = 0, j = 3; i < my2DArrT.GetLength(0); i++, j+=2)
            // {
            //     my2DArrT[i] = new int[j];
            // }

            // for(int i = 0; i < my2DArrT.GetLength(0); i++)
            // {
            //     for(int j = 0; j < my2DArrT[i].Length; j++)
            //     {
            //         my2DArrT[i][j] = random.Next(0,10);
            //     }
            // }

            
            // for(int i = 0; i < my2DArrT.GetLength(0); i++)
            // {
            //     for(int j = 0; j < my2DArrT[i].Length; j++)
            //     {
            //         System.Console.Write(my2DArrT[i][j] + " ");
            //     }
            //     System.Console.WriteLine();
            // }


            int [] arr2 = {2,3,4,5,5};
            int t2 = arr2[0];

            for(int i = 1; i < arr2.Length; i++)
            {
                int temp2 = arr2[i];
                arr2[i - 1] = temp2;
            }
            arr2[arr2.Length - 1] = t2;

            foreach(int r in arr2)
            {
                System.Console.Write(r + " ");
            }
            System.Console.WriteLine();


        }
    }
}

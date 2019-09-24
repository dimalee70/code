using System;

namespace classArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int t = 3;
            // int t2 = 4;
            // int [,] matrix = new int[t,t2];
            // int  num = 1;
            // for(int i =0; i < matrix.GetLength(0); i++)
            // {
            //     for(int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         matrix[i,j] = num++;
            //     }
            // }

            
            // matrix[0,2] = 100;

            // for(int i =0; i < matrix.GetLength(0); i++)
            // {
            //     for(int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         System.Console.Write(matrix[i,j] + "\t");
            //     }
            //     System.Console.WriteLine();
            // }
            // // Console.WriteLine("Hello World!");

            // int max = matrix[0,0];
            // int column = 0;


            // for(int i =0; i < matrix.GetLength(0); i++)
            // {
            //     for(int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         if(matrix[i,j] > max)
            //         {
            //             max = matrix[i,j];
            //             column = j;
            //         }
            //     }
            // }


            // int [] arr = new int [t];

            // for(int i = 0; i < t; i++)
            // {
            //     arr[i] = matrix [i,0];
            // }
            
            // for(int i =0; i < matrix.GetLength(0); i++)
            // {
            //     matrix[i, 0] = matrix[i, column];
            //     matrix[i, column] = arr[i];
            // }
            // System.Console.WriteLine();



            // for(int i =0; i < matrix.GetLength(0); i++)
            // {
            //     for(int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         System.Console.Write(matrix[i,j] + "\t");
            //     }
            //     System.Console.WriteLine();
            // }
            // Console.WriteLine("Hello World!");
            

            
            // arr = matrix[]

            int [] arr = {7,6,1,0,7,1,7,9,2,};

            // Array.Sort(arr);

            foreach(int i in arr)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

            // int  search = Array.BinarySearch(arr,1);
            // System.Console.WriteLine(search);

            // for(int i = 0; i < arr.Length; i++)
            // {
            //     if(arr[i] == 7)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }
            int [] arr2 = new int[arr.Length+1];
            // Array.Copy(arr, arr2, arr.Length);
            // Array.Copy(arr, 3 ,arr2, 3, 4);
            // arr2[arr2.Length-1] = 100;
            // arr = arr2;

            foreach(int i in arr)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

            // Array.Resize(ref arr, arr.Length-2);
            // arr[arr.Length-1] = 123;

            // foreach(int i in arr)
            // {
            //     System.Console.Write(i + " ");
            // }
            // System.Console.WriteLine();

            Array.Sort(arr);
            Array.Reverse(arr);

            foreach(int i in arr)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

            // Array.Fill(arr, 10);
            Array.Fill(arr, 10, 3,2);
            
            foreach(int i in arr)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

            int[] arr3 = (int[])arr.Clone();
            foreach(int a in arr3)
            {
                System.Console.Write(a + " ");
            }
            System.Console.WriteLine();

            arr3.SetValue(10, 0);

            foreach(int a in arr3)
            {
                System.Console.Write(a + " ");
            }
            System.Console.WriteLine();

            // int getN = arr3[0];
            int getN = (int )arr3.GetValue(0);
            System.Console.WriteLine(getN);
            System.Console.WriteLine(Array.IndexOf(arr, 10));
            System.Console.WriteLine(Array.LastIndexOf(arr,10));
            Array.Clear(arr, 3, 4);

            foreach(int a in arr)
            {
                System.Console.Write(a + " ");
            }
            System.Console.WriteLine();



            // arr3[0] = 10;





        }
    }
}

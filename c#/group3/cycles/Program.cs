using System;

namespace cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int i = 0;

            // while(true)
            // {

            // }

            // while(i < 5)
            // {
            //     Console.WriteLine("Hello World!");
            //     i++;
            // }

            // for(int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine("Hello");
            // }

            // int t = 10;
            // do 
            // {
            //     System.Console.WriteLine(t--);
            // }
            // while(t >=0);

            // for(;;)
            // {

            // }


            // for(int i = 0, j = 10; i <= j; i++, j--)
            // {
            //     System.Console.WriteLine("i | j " + i + " | " +j);
            // }

            // int  t = 100;
            // bool isTen = false;

            // for(;!isTen;t--) 
            // {
            //     if(t == 10)
            //     {
            //         isTen = true;
            //     }
            //     System.Console.Write(t+" ");
            // }
            // System.Console.WriteLine();

            // int n = 10;
            // int summ = 0;
            // for(int i = 0; i <= n; summ+=i++);
            // System.Console.WriteLine(summ);



            
            // forlabel:
            //     int y = 20;
            //     for(;;y--)
            //     {
            //         if (y == 10)
            //             goto label1;
            //         System.Console.WriteLine(y);
            //     }

            // label1:
            //     System.Console.WriteLine("Exit");
            //     System.Console.WriteLine("end");
            //     goto forlabel
                
            // while(true)
            // {
            //     System.Console.WriteLine("Enter the number ");
            //     int t = Convert.ToInt32(Console.ReadLine());
            //     if (t == -1)
            //         break;
            //     System.Console.WriteLine(t);
            // }

            // for(int i = 0; i <= 10; i++)
            // {
            //     if(i % 2 != 0)
            //         continue;
            //     System.Console.WriteLine(i);
            // }


            // int i  = 10;
            // while( i >= 0)
            // {
            //     if(i % 2 != 0)
            //     {
            //         i--;
            //         continue;
            //     }
            //     System.Console.WriteLine(i--);
            // }

            // for(int i = 0; i < 10; i++)
            // {
            //     for(int j = 0; j < 10; j++)
            //     {
            //         System.Console.Write("*");
            //     }
            //     System.Console.WriteLine();
            // }

            // int [] arr = {1,2,3,4,5,6};

            // foreach(int t in arr)
            // {
            //     System.Console.Write(t + " ");
            // }
            // System.Console.WriteLine();

            // int [] arr = new int [10];
            // arr[0] = 10;

            // System.Console.WriteLine(arr[0]);

            Random rand = new Random();

            // for(int i = 0; i < arr.Length; i++)
            // {
            //     arr[i] = rand.Next(50,100);
            // }


            // foreach(int t in arr)
            // {
            //     System.Console.Write(t+ " ");
            // }
            // System.Console.WriteLine();



            // int [] initArr = {1,2,3,4,5,6,7,8,9};
            // int [] decInitArr = new int[10]{1,2,3,4,5,6,7,8,9,10};


            // object [] myObject = {true, 'a', 2313, 3.2232, 4.55F};

            // foreach(object o in myObject)
            // {
            //     System.Console.WriteLine(o);
            // }


            // int [,] my2DArr = new int[3,5];

            // System.Console.WriteLine(my2DArr.Length);

            // for(int i = 0; i < my2DArr.GetLength(0);i++)
            // {
            //     for(int j = 0; j < my2DArr.GetLength(1); j++)
            //     {
            //         my2DArr[i,j] = rand.Next(10);
            //     }
            // }

            // for(int i = 0; i < my2DArr.GetLength(0);i++)
            // {
            //     for(int j = 0; j < my2DArr.GetLength(1); j++)
            //     {
            //         System.Console.Write(my2DArr[i,j] + " ");
            //     }
            //     System.Console.WriteLine();
            // }
            
            // int [,] my2dInitArr = {
            //                         {1,2,3},
            //                         {4,5,6},
            //                         {7,8,9},
            //                         {8,9,0}
            //                         };

            // int [][] myArr = new int[3][];

            // // myArr [0] = new int[5];

            // int [] fstEl = new int[5];
            // int [] secEl = new int[7];
            // int [] thdEl = new int[9];

            // for(int i = 0, j = 1; i < fstEl.Length; i++, j++)
            // {
            //     fstEl[i] = j;
            // }  
            // myArr[0] = fstEl;
            
            // for(int i = 0, j = 1; i < secEl.Length; i++, j++)
            // {
            //     secEl[i] = j;
            // }  
            // myArr [1] = secEl;

                   
            // for(int i = 0, j = 1; i < thdEl.Length; i++, j++)
            // {
            //     thdEl[i] = j;
            // }  
            // myArr [2] = thdEl;



            // for(int i = 0; i < myArr[0].Length; i++)
            // {
            //     System.Console.Write(myArr[0][i] + " ");
            // }
            // System.Console.WriteLine();

            // for(int i = 0; i < myArr[1].Length; i++)
            // {
            //     System.Console.Write(myArr[1][i] + " ");
            // }
            // System.Console.WriteLine();

            // for(int i = 0; i < myArr[2].Length; i++)
            // {
            //     System.Console.Write(myArr[2][i] + " ");
            // }
            // System.Console.WriteLine();

            // Array array = Array.CreateInstance(typeof(int),5);
            // array.SetValue(3,2);
            // // array[2] = 3;
            // System.Console.WriteLine(array.GetValue(2));

            // int [] array2 = (int [])array.Clone();

            // for(int i = 0; i < array.Length; i++)
            // {
            //     // System.Console.Write(array.GetValue(i) + " "); 
            //     System.Console.Write(array2[i]);
            // }
            // System.Console.WriteLine();



            // char [] charArr = {'a', 'b', 'c', 'd', 'e'};


            // char [] charArr2 = new char[charArr.Length+1];

            // // Array.Copy(charArr, charArr2, charArr.Length);
            // Array.Copy(charArr, 0, charArr2, 1, 2);

            // // charArr2[charArr2.Length - 1] = 'd';

            // charArr2[0] = 'd';

            // charArr = charArr2;

            // foreach(char c in charArr)
            // {
            //     System.Console.Write(c + " ");
            // }
            // System.Console.WriteLine();




        }
    }
}

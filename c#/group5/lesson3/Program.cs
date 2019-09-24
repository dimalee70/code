using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myIntArr = new int [12];
            int [] myInitIntArr = {1,2,34,5,6};
            int [] arr = new int [2]{1,2};

            bool [] myArrBool = new bool[5];

            int firstIndArr = myIntArr[0];
            System.Console.WriteLine(firstIndArr);
            myIntArr[0] = firstIndArr = 10; 
            System.Console.WriteLine(firstIndArr);


            // for(int i = 0; i < myIntArr.Length; i++)
            // {
            //     myIntArr[i] = i;
            // }

            // for(int i = 0; i < myIntArr.Length; i++)
            // {
            //     System.Console.Write(myIntArr[i] + " ");
            // }
            // System.Console.WriteLine();
            
            // foreach(int i in myIntArr)
            // {
            //     System.Console.Write(i + " ");
            // }
            // System.Console.WriteLine();

            // foreach(bool b in myArrBool)
            // {
            //     System.Console.WriteLine(b);
            // }


            // int t = 5;

            // for(int i = myIntArr.Length - 1; i >= 0; i--)
            // {
            //     System.Console.Write(myIntArr[i] + " ");
            // }
            // System.Console.WriteLine();

            Random random = new Random();

            // for(int i = 0; i < myIntArr.Length; i++)
            // {
            //     // myIntArr[i] = random.Next();
            //     // myIntArr[i] = random.Next(100);
            //     myIntArr[i] = random.Next(10,20);
            // }

            // foreach(int i in myIntArr)
            // {
            //     System.Console.Write(i + " ");
            // }
            // System.Console.WriteLine();

            int [,] myIntTwoDArr = new int[3,5];

            System.Console.WriteLine(myIntTwoDArr.Length);

            System
            .Console
            .WriteLine
            (myIntTwoDArr.GetLength(0));

            // int [,,] arr3 = new int [1,2,3];

            // for(int i = 0; i < myIntTwoDArr
            //                     .GetLength(0); i++)
            // {
            //     for(int j = 0; j < myIntTwoDArr.GetLength(1);
            //         j++)
            //     {
            //         myIntTwoDArr[i,j] = 
            //             random.Next(0,10);
            //     }
            // }


            //       for(int i = 0; i < myIntTwoDArr
            //                     .GetLength(0); i++)
            // {
            //     for(int j = 0; j < myIntTwoDArr.GetLength(1);
            //         j++)
            //     {
            //         System
            //         .Console
            //         .Write(myIntTwoDArr[i,j] + "\t");
            //     }
            //     System.Console.WriteLine();
            // }


            // int [][] stairArrayInt = 
            // new int [5][];

       
            // for(int i = 0, j = 5; i < stairArrayInt
            // .GetLength(0); i++, j+=2)
            // {
            //     stairArrayInt[i] = 
            //     new int [j];
            // }

            // for(int i = 0; i < stairArrayInt.GetLength(0); i++)
            // {
            //     for (int j = 0; 
            //     j < stairArrayInt[i].Length; 
            //     j++)
            //     {
            //         stairArrayInt[i][j] = random.Next(0,200);
            //     }
            // }

            // for(int i = 0; i < stairArrayInt.GetLength(0); i++)
            // {
            //     for (int j = 0; 
            //     j < stairArrayInt[i].Length; 
            //     j++)
            //     {
            //         System
            //         .Console
            //         .Write(stairArrayInt[i][j] + "\t");
            //     }
            //     System.Console.WriteLine();
            // }


            int [] arrBubleSort = {1,43,56,12,43,89,2};



            // for(int i = 0; i < arrBubleSort.Length - 1;
            // i++)
            // {
            //     for(int j = i + 1; 
            //     j < arrBubleSort.Length; j++)
            //     {
            //         if(arrBubleSort[i] > 
            //         arrBubleSort[j])
            //         {
            //             int temp = 
            //                 arrBubleSort[j];
                        
            //             arrBubleSort[j] = 
            //                 arrBubleSort[i];
            //             arrBubleSort[i] = temp;
            //         }
            //     }
            // }

            // foreach(int i in arrBubleSort)
            //     {
            //         System.Console.Write(i + " ");
            //     }
            //     System.Console.WriteLine();

            // int idx = -1;
            // for(int i = arrBubleSort
            //                 .Length - 1; i > idx; i--)
            // {
            //     if(arrBubleSort[i] == 43)
            //     {
            //         idx = i;
            //         break;
            //     }
            // }

            // System
            //     .Console
            //     .WriteLine
            //         ($"Индекс = {idx}");

            // char [] myArrChar = {'H', 'e', 'l', 'l', 'o'};

            // Array.Sort(myArrChar);
            
            // foreach(char c in myArrChar)
            // {
            //     System.Console.Write(c + "\t");
            // }
            // System.Console.WriteLine();

            int [] intArr = {
                            4, 3, 1, 
                            7, 3, 1,
                            2, 6, 3,
                            };


            // Array.Sort(intArr);

            // Array.Reverse(intArr);

            // int findIdx = Array.BinarySearch(intArr, 6);

            // System.Console.WriteLine(findIdx);




            foreach(int i in intArr)
            {
                System.Console.Write(i + "\t");
            }
            System.Console.WriteLine();

            int t = Array.IndexOf(intArr, 3);
            System
                .Console
                .WriteLine
                    ($"Index {t}");

            int lastIdx = 
                Array.LastIndexOf(intArr, 3);

            System
                .Console
                .WriteLine
                    ($"Index {lastIdx}");

            int centerIdx = Array.IndexOf(intArr,
                                    3, 3, intArr.Length - 3);
            System
                .Console
                .WriteLine
                    ($"Index {centerIdx}");

            int [] copyArr = new int 
                [intArr.Length + 1];

            Array.Copy(intArr, copyArr, intArr.Length);

            int [] cloneArr = (int[])intArr.Clone();

            // System.Console.WriteLine("CopyTo");
            // foreach(int i in cloneArr)
            // {
            //     System.Console.Write(i + "\t");
            // }
            // System.Console.WriteLine();

            copyArr[copyArr.Length - 1] = 100;

            intArr = copyArr;

            copyArr [0] = 200; 

            foreach(int i in intArr)
            {
                System.Console.Write(i + "\t");
            }
            System.Console.WriteLine();

            // Array.Clear(intArr, 2, intArr.Length-2);
            // Array.Resize(ref intArr, 
            //     intArr.Length - 3);
            
            // intArr[intArr.Length - 1] = 100;


            // foreach(int i in intArr)
            // {
            //     System.Console.Write(i + "\t"); 
            // }
            // System.Console.WriteLine();


            // int w = 4;
            // int c = w;
            // w = 5;
            // System.Console.WriteLine(c);

            intArr.SetValue(222, 1);
            System
                .Console
                .WriteLine
                    (intArr.GetValue(1));

            
            // intArr[]

            Array initArr
                = Array.CreateInstance(typeof(int), 10); 
            System.Console.WriteLine(initArr.GetType());

            System.Console.WriteLine(initArr.GetValue(0));

            int [] r = (int []) initArr;
            r[0] = 12;
            
        }
    }
}

using System;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // string [] arrStr = {"Hello", "My", "name", "is", "Islam"};
                            // {"", "Hello", "my", "name", "is"}
            
            // arrStr[arrStr.Length-1] = "";
            // for(int i = 0; i < 13; i++)
            // {
                // string [] arrStr2 = new string[arrStr.Length];
                
            //     Array.Copy(arrStr, 0, arrStr2, 1, arrStr.Length - 1);
            //     // foreach(string s in arrStr2)
            //     // {
            //     //     System.Console.Write(s + " ");
            //     // }
            //     System.Console.WriteLine();
            //     arrStr2[0] = arrStr[arrStr.Length-1];
            //     // arrStr2[arrStr2.Length-1] = arrStr[0];
            //     arrStr = arrStr2;

            //     foreach(string s in arrStr)
            //     {
            //         System.Console.Write(s + " ");
            //     }
            //     System.Console.WriteLine();

            // }

            // int [] arrInt = {1,2,3,4,5};

            // for(int j = 0; j < 13; j++)
            //     {
            //     int [] arrInt2 = new int[arrInt.Length];

            //     for(int i = 0; i < arrInt.Length - 1; i++)
            //     {
            //         arrInt2[i+1] = arrInt[i];
            //     }
            //     arrInt2[0] = arrInt[arrInt.Length-1];
            //     arrInt = arrInt2;

            //     foreach(int t in arrInt)
            //     {
            //         System.Console.Write(t + " ");
            //     }
            //     System.Console.WriteLine();
            // }

            int [] arrInt = {1,2,3,4,5,6,7,8,9,10};
            int j = 0;
            int [] arrInt2 = new int[0];
            for(int i = 0; i < arrInt.Length; i++)
            {
                if(arrInt[i] > 5)
                {
                    continue;
                }
                int [] arrInt3 = new int[arrInt2.Length+1];
                Array.Copy(arrInt2, arrInt3,arrInt2.Length);
                arrInt3[j] = arrInt[i];
                j++; 
                arrInt2 = arrInt3;
            }
            arrInt = arrInt2;

            foreach(int i in arrInt)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

        }
    }
}

using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter the number");
            // int n = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("enter the word");
            // string word = Console.ReadLine();

            // System.Console.WriteLine();
            // for(int i= 1; i <= n;i++)
            // {
            //     System.Console.WriteLine(word);
            // }

            // System.Console.WriteLine("Enter the from number");
            // int from = Convert.ToInt32(Console.ReadLine());

            // System.Console.WriteLine("Enter the to number");

            // int to = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine();
            // for(int i = from; i <= to; i++)
            // {
            //     if(i % 3 == 0 && i % 5 != 0)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }

            System.Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            // for(int i = 0; i <= (n/2);i++)
            // {
            //     for(int j = 0; j < n/2 - i; j++)
            //     {
            //         System.Console.Write(" ");
            //     }
            //     for(int j = n/2 - i; j <= n/2+i;j++ )
            //     {
            //         System.Console.Write("*");
            //     }
            //     System.Console.WriteLine();
            // }

            int [] arr = new int[0];
            while(true)
            {

                System.Console.WriteLine("Enter the number");
                int t = Convert.ToInt32(Console.ReadLine());
                if(t == -1)
                {
                    break;
                }
                int [] arr2 = new int[arr.Length + 1];
                Array.Copy(arr, arr2, arr.Length);
                arr2[arr2.Length-1] = t;

                arr = arr2;

            }

            foreach(int t in arr)
            {
                System.Console.Write(t + " ");
            }
            System.Console.WriteLine();
            

        }
    }
}

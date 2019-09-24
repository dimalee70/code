using System;

namespace lesson2B
{
    class Program
    {
        static void Main(string[] args)
        {

            // for(int i = 5; i > 0; i--)
            // {
            //     Console.WriteLine("Hello World!");
            // }

            // for(;;)
            // {

            // }

            // for(int i = 0, j = 5; j >= i; i++, j-- )
            // {
            //     System.Console.WriteLine(i +" " +j);
            // }

            // for(int i = 0; (i < 5) && i < 10;i++ )
            // {
            //     System.Console.WriteLine(i);
            // }

            // int i;
            // for(i = 0;i < 5;i+=2)
            // {
            //     System.Console.WriteLine(i);
            // }
           
            // int sum = 0;
            // for(int i = 0; i < 10; sum+=i++);
            // System.Console.WriteLine(sum);

            // int t = 0;
            // while (t < 10)
            // {
            //     System.Console.WriteLine(t);
            //     t++;
            // }

            // while(true)
            // {
            //     System.Console.WriteLine();
            // }

            // int t = 0;
            // do
            // {
            //     System.Console.WriteLine("Hello");
            // }
            // while(t > 0);

            // for(int t = 1; t < 10; t++)
            // {
            //     if(t % 2 == 0)
            //         break;
            //     System.Console.WriteLine(t);
            // }

            // for(int t = 1; t < 10; t++)
            // {
            //     if(t % 2 == 0)
            //         continue;
            //     System.Console.WriteLine(t);
            // }

            // int t = 0;
            // while (t < 10)
            // {
            //     if(t % 2 == 0)
            //     {
            //         t++;
            //         continue;
            //     }
            //     System.Console.WriteLine(t++);
            // }

            //             int t = 1;
            // while (t < 10)
            // {
            //     if(t % 2 == 0)
            //     {
            //         t++;
            //         break;
            //     }
            //     System.Console.WriteLine(t++);
            // }


            // program:
            //     System.Console.WriteLine("Enter the number");
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     if(num == -1)
            //         goto exit;
            //     else
            //         goto program;




            
            // exit:
            //     System.Console.WriteLine("Exit");


            // for(int i = 0; i < 5; i++)
            // {
            //     for (int j = 0; j < i;j++)
            //     {
            //         System.Console.Write("*");
            //     }
            //     System.Console.WriteLine();
            // }

            for (int i=1; i<=9; i++){
                for (int j=1; j<=10; j++){
                    Console.Write(j +"*"+i +"="+(i*j) + "\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}
